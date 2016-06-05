using System;
using System.Windows.Forms;

namespace Game_of_Life {
    public partial class SizeForm: Form {
        public int map_width, map_height, cell_size;

        public SizeForm(int width, int hight, int cell) {
            InitializeComponent();
            textBox_width.Text = width.ToString();
            textBox_height.Text = hight.ToString();
            textBox_cell.Text = cell.ToString();
            label_max_w.Text = string.Format("{0} max", MainForm.max_map_width);
            label_max_h.Text = string.Format("{0} max", MainForm.max_map_height);
            label_max_c.Text = string.Format("{0} max", MainForm.max_cell_size);
        }

        private void button_cancle_Click(object sender, EventArgs e) {
            Close();
        }

        private void button_ok_Click(object sender, EventArgs e) {
            try {
                map_width = Convert.ToInt32(textBox_width.Text);
                if(map_width <= 0) {
                    MessageBox.Show("длина должна быть больше нуля", "ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                } else if(map_width > MainForm.max_map_width) {
                    MessageBox.Show("длина превышает максимальное значение", "ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                map_height = Convert.ToInt32(textBox_height.Text);
                if(map_height <= 0) {
                    MessageBox.Show("ширина должна быть больше нуля", "ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                } else if(map_height > MainForm.max_map_width) {
                    MessageBox.Show("ширина превышает максимальное значение", "ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                cell_size = Convert.ToInt32(textBox_cell.Text);
                if(cell_size <= 0) {
                    MessageBox.Show("размер ячейки должен быть больше нуля", "ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                } else if(cell_size > MainForm.max_cell_size) {
                    MessageBox.Show("размер ячейки превышает максимальное значение", "ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                DialogResult = DialogResult.OK;
                Close();
            } catch(Exception ex) {
                MessageBox.Show(ex.Message, "ошибка ввода", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
