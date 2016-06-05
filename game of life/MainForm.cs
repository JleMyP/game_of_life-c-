using System;
using System.Linq;
using System.Drawing;
using System.Windows.Forms;
using System.Collections.Generic;
using System.Diagnostics;

namespace Game_of_Life {
    public partial class MainForm: Form {
        public const int max_map_width = 600, max_map_height = 300, max_cell_size = 10;
        public int map_width, map_height, cell_size;
        List<int> save = new List<int> { 2, 3 };
        List<int> born = new List<int> { 3 };
        int[,] map = new int[max_map_width, max_map_height];
        int[,] new_map = new int[max_map_width, max_map_height];
        List<int[,]> history = new List<int[,]>();
        public int max_history = 200;
        int alive, stable;
        ulong frame;

        bool drow = false;
        int pen = 1, pen_width = 1, max_pen_width = 100;
        SolidBrush pen_color = new SolidBrush(Color.Lime);
        Random rand = new Random();
        Timer timer = new Timer();
        Stopwatch SW = new Stopwatch();

        public MainForm() {
            InitializeComponent();
        }

        private void Form_Load(object sender = null, EventArgs e = null) {
            label_pen_width.Text = string.Format("толщина пера: {0}", pen_width);
            label_save.Text = "выживание: " + string.Join(", ", save);
            label_born.Text = "рождение: "+ string.Join(", ", born);
            timer.Tick += Step;
            timer.Interval = 1;
            resize(250, 200, 3);
            CenterToScreen();
            Step();
        }

        private void MainForm_Resize(object sender, EventArgs e) {
            int w = Math.Min(max_map_width, (ClientSize.Width - pictureBox1.Location.X) / cell_size);
            int h = Math.Min(max_map_height, ClientSize.Height / cell_size);
            Text = string.Format("Game of Life ({0}x{1})", w, h);
            if(WindowState == FormWindowState.Maximized) MainForm_ResizeEnd(sender, e);
        }

        private void MainForm_ResizeEnd(object sender, EventArgs e) {
            int w = Math.Min(max_map_width, pictureBox1.Width / cell_size);
            int h = Math.Min(max_map_height, pictureBox1.Height / cell_size);
            if(w != map_width || h != map_height) resize(w, h, cell_size);
        }

        public void resize(int w, int h, int c) {
            map_width = w; map_height = h; cell_size = c;
            Text = string.Format("Game of Life ({0}x{1})", map_width, map_height);
            ClientSize = new Size(cell_size * map_width + pictureBox1.Location.X, Math.Max(cell_size * map_height, MinimumSize.Height));
            pictureBox1.Size = new Size(cell_size * map_width, cell_size * map_height);
            New_game();
        }

        private void New_game(bool empty=false){
            frame = 1;
            Generate(map, empty);
            Generate(new_map, true);
            history.Clear();
            history.Add((int[,])new_map.Clone());
            label_frame.Text = "шаг: 1";
            label_history.Text = string.Format("история: {0}/{1}", history.Count, max_history);
            timer.Enabled = false;
            pictureBox1.Refresh();
        }

        private void Generate(int[,] dest_map, bool zero=false){
            for (int x = 0; x < map_width; x++){
                for (int y = 0; y < map_height; y++){
                    if (zero) dest_map[x, y] = 0;
                    else dest_map[x, y] = rand.Next(2);
            }
          }
        }

        private int Get_value(int x, int y){
            if (x == map_width) x = 0;
            else if (x == -1) x += map_width;
            if (y == map_height) y = 0;
            else if (y == -1) y += map_height;
            return map[x, y];
        }

        private void Set_value(int x, int y, int v) {
            if(x >= map_width) x -= map_width;
            else if(x < 0) x += map_width;
            if(y >= map_height) y -= map_height;
            else if(y < 0) y += map_height;
            map[x, y] = v;
        }

        private int Get_sum_mur(int x, int y){
            int sum = 0;
            for(int xx = x - 1; xx < x + 2; xx++) {
                for (int yy = y - 1; yy < y + 2; yy++) {
                    sum += Get_value(xx, yy);
                }
            }
            return sum-map[x, y];
        }

        private void Step(object sender = null, EventArgs e = null) {
            SW.Start();
            int sum;
            alive = stable = 0;
            for(int x = 0; x < map_width; x++) {
                for(int y = 0; y < map_height; y++) {
                    sum = Get_sum_mur(x, y);
                    if(map[x, y] == 1 && save.Contains(sum) || map[x, y] == 0 && born.Contains(sum)) {
                        new_map[x, y] = 1;
                        alive++;
                        //alive += new_map[x, y] = 1;
                    } else new_map[x, y] = 0;
                }
            }

            if(history.Count == max_history) history.RemoveAt(0);
            history.Add((int[,])map.Clone());
            label_history.Text = string.Format("история: {0}/{1}", history.Count, max_history);

            int[,] tmp = map; map = new_map; new_map = tmp;
            SW.Stop();
            label_step.Text = string.Format("step per {0} millis", SW.ElapsedMilliseconds);
            SW.Reset();
            frame++;
            label_frame.Text = string.Format("кадр: {0}", frame);
            label_alive.Text = string.Format("популяция: {0}", alive);
            pictureBox1.Refresh();
        }

        private void pictureBox1_Paint(object sender, PaintEventArgs e) {
            SW.Start();
            Graphics g = e.Graphics;
            for(int x = 0; x < map_width; x++) {
                for(int y = 0; y < map_height; y++) {
                    if(map[x, y] == 1)
                        g.FillRectangle(pen_color, x * cell_size, y * cell_size, cell_size, cell_size);
                }
            }
            SW.Stop();
            label_draw.Text = string.Format("draw per {0} millis", SW.ElapsedMilliseconds);
            SW.Reset();
        }

        private void button_rules_MouseClick(object sender, MouseEventArgs e) {
            RulesForm r = new RulesForm();
            r.ShowDialog();
            if(r.DialogResult != DialogResult.OK) return;

            save = r.save.Where(c => c.Checked).Select(c => r.save.IndexOf(c) + 1).ToList();
            label_save.Text = "выживание: " + string.Join(", ", save);
            born = r.born.Where(c => c.Checked).Select(c => r.born.IndexOf(c) + 1).ToList();
            label_born.Text = "рождение: " + string.Join(", ", born);
        }

        private void button_size_MouseClick(object sender, MouseEventArgs e) {
            SizeForm f = new SizeForm(map_width, map_height, cell_size);
            f.ShowDialog();
            if(f.DialogResult == DialogResult.OK) resize(f.map_width, f.map_height, f.cell_size);
        }
                
        private void button_color_MouseClick(object sender, MouseEventArgs e) {
            if(colorDialog1.ShowDialog() == DialogResult.OK) {
                pen_color = new SolidBrush(colorDialog1.Color);
                pictureBox1.Refresh();
            }
        }
        
        private void pictureBox1_MouseDown(object sender, MouseEventArgs e) {
            drow = true;
            if(e.Button == MouseButtons.Left) pen = 1;
            else if(e.Button == MouseButtons.Right) pen = 0;
            pictureBox1_MouseMove(sender, e);
        }

        private void pictureBox1_MouseUp(object sender, MouseEventArgs e) {
            drow = false;
        }

        private void pictureBox1_MouseMove(object sender, MouseEventArgs e) {
            label_x.Text = string.Format("x: {0}", e.X/cell_size);
            label_y.Text = string.Format("y: {0}", e.Y / cell_size);
            if(drow) {
                int x = e.X / cell_size;
                int y = e.Y / cell_size;
                for(int xx = x - (pen_width - pen_width % 2) / 2 + (1 - pen_width % 2); xx <= x + (pen_width - pen_width % 2) / 2; xx++) {
                    for(int yy = y - (pen_width - pen_width % 2) / 2 + (1 - pen_width % 2); yy <= y + (pen_width - pen_width % 2) / 2; yy++) {
                        Set_value(xx, yy, pen);
                    }
                }
                pictureBox1.Refresh();
            }
        }

        private void preview_key_down(object sender, PreviewKeyDownEventArgs e) {
            Key_callback(e.KeyCode);
        }

        private void mouse_wheel(object sender, MouseEventArgs e) {
            if(e.Delta > 0) {
                pen_width = (pen_width + 1) % (max_pen_width + 1);
                if(pen_width == 0) pen_width = 1;
                label_pen_width.Text = string.Format("толщина пера: {0}", pen_width);
            } else {
                pen_width = (pen_width + max_pen_width) % (max_pen_width + 1);
                if(pen_width == 0) pen_width = max_pen_width;
                label_pen_width.Text = string.Format("толщина пера: {0}", pen_width);
            }
        }

        private void Key_callback(Keys k) {
            switch(k) {
                case Keys.Escape: Application.Exit(); break;
                case Keys.Left:
                    if(history.Count > 1) {
                        map = history[history.Count-1];
                        new_map = history[history.Count - 2];
                        history.RemoveAt(history.Count - 1);
                        label_history.Text = string.Format("история: {0}/{1}", history.Count, max_history);
                        pictureBox1.Refresh();
                    }
                    break;
                case Keys.Right:
                    if(!timer.Enabled) Step();
                    break;
                case Keys.Space: timer.Enabled = !timer.Enabled; break;
                case Keys.Enter: New_game(); break;
                case Keys.N: timer.Enabled = false; New_game(true); break;
                case Keys.Up:
                    pen_width = (pen_width + 1) % (max_pen_width + 1);
                    if(pen_width == 0) pen_width = 1;
                    label_pen_width.Text = string.Format("толщина пера: {0}", pen_width);
                    break;
                case Keys.Down:
                    pen_width = (pen_width + max_pen_width) % (max_pen_width + 1);
                    if(pen_width == 0) pen_width = max_pen_width;
                    label_pen_width.Text = string.Format("толщина пера: {0}", pen_width);
                    break;
                case Keys.B:
                    New_game(true);
                    for(int x = 1; x < map_width - 1; x = x + 3) {
                        //int y = 1;
                        for(int y = 1; y < map_height - 1; y = y + 3) {
                            map[x, y] = 1;
                            map[x + 1, y] = 1;
                            map[x, y + 1] = 1;
                            map[x + 1, y + 1] = 1;
                        }
                    }
                    pictureBox1.Refresh();
                    break;
                default: break;
            }
        }
    }
}