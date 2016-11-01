namespace Game_of_Life
{
    partial class MainForm
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label_draw = new System.Windows.Forms.Label();
            this.label_step = new System.Windows.Forms.Label();
            this.label_pen_width = new System.Windows.Forms.Label();
            this.label_frame = new System.Windows.Forms.Label();
            this.button_size = new System.Windows.Forms.Button();
            this.button_color = new System.Windows.Forms.Button();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.label_cursor = new System.Windows.Forms.Label();
            this.label_x = new System.Windows.Forms.Label();
            this.label_y = new System.Windows.Forms.Label();
            this.label_alive = new System.Windows.Forms.Label();
            this.label_stable = new System.Windows.Forms.Label();
            this.label_rules = new System.Windows.Forms.Label();
            this.label_save = new System.Windows.Forms.Label();
            this.label_born = new System.Windows.Forms.Label();
            this.button_rules = new System.Windows.Forms.Button();
            this.label_history = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox1.BackColor = System.Drawing.Color.Black;
            this.pictureBox1.Location = new System.Drawing.Point(130, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(303, 360);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Paint += new System.Windows.Forms.PaintEventHandler(this.pictureBox1_Paint);
            this.pictureBox1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseDown);
            this.pictureBox1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseMove);
            this.pictureBox1.MouseUp += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseUp);
            // 
            // label_draw
            // 
            this.label_draw.AutoSize = true;
            this.label_draw.Location = new System.Drawing.Point(15, 110);
            this.label_draw.Name = "label_draw";
            this.label_draw.Size = new System.Drawing.Size(30, 13);
            this.label_draw.TabIndex = 1;
            this.label_draw.Text = "draw";
            // 
            // label_step
            // 
            this.label_step.AutoSize = true;
            this.label_step.Location = new System.Drawing.Point(15, 130);
            this.label_step.Name = "label_step";
            this.label_step.Size = new System.Drawing.Size(27, 13);
            this.label_step.TabIndex = 2;
            this.label_step.Text = "step";
            // 
            // label_pen_width
            // 
            this.label_pen_width.AutoSize = true;
            this.label_pen_width.Location = new System.Drawing.Point(15, 250);
            this.label_pen_width.Name = "label_pen_width";
            this.label_pen_width.Size = new System.Drawing.Size(78, 13);
            this.label_pen_width.TabIndex = 4;
            this.label_pen_width.Text = "толщина пера";
            // 
            // label_frame
            // 
            this.label_frame.AutoSize = true;
            this.label_frame.Location = new System.Drawing.Point(15, 150);
            this.label_frame.Name = "label_frame";
            this.label_frame.Size = new System.Drawing.Size(26, 13);
            this.label_frame.TabIndex = 5;
            this.label_frame.Text = "шаг";
            // 
            // button_size
            // 
            this.button_size.Location = new System.Drawing.Point(20, 335);
            this.button_size.Name = "button_size";
            this.button_size.Size = new System.Drawing.Size(75, 36);
            this.button_size.TabIndex = 6;
            this.button_size.Text = "изменить размер";
            this.button_size.UseVisualStyleBackColor = true;
            this.button_size.MouseClick += new System.Windows.Forms.MouseEventHandler(this.button_size_MouseClick);
            this.button_size.MouseWheel += new System.Windows.Forms.MouseEventHandler(this.mouse_wheel);
            this.button_size.PreviewKeyDown += new System.Windows.Forms.PreviewKeyDownEventHandler(this.preview_key_down);
            // 
            // button_color
            // 
            this.button_color.Location = new System.Drawing.Point(20, 375);
            this.button_color.Name = "button_color";
            this.button_color.Size = new System.Drawing.Size(75, 38);
            this.button_color.TabIndex = 7;
            this.button_color.Text = "изменить цвет";
            this.button_color.UseVisualStyleBackColor = true;
            this.button_color.MouseClick += new System.Windows.Forms.MouseEventHandler(this.button_color_MouseClick);
            this.button_color.MouseWheel += new System.Windows.Forms.MouseEventHandler(this.mouse_wheel);
            this.button_color.PreviewKeyDown += new System.Windows.Forms.PreviewKeyDownEventHandler(this.preview_key_down);
            // 
            // colorDialog1
            // 
            this.colorDialog1.Color = System.Drawing.Color.Green;
            // 
            // label_cursor
            // 
            this.label_cursor.AutoSize = true;
            this.label_cursor.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label_cursor.Location = new System.Drawing.Point(15, 270);
            this.label_cursor.Name = "label_cursor";
            this.label_cursor.Size = new System.Drawing.Size(48, 13);
            this.label_cursor.TabIndex = 8;
            this.label_cursor.Text = "курсор";
            // 
            // label_x
            // 
            this.label_x.AutoSize = true;
            this.label_x.Location = new System.Drawing.Point(50, 285);
            this.label_x.Name = "label_x";
            this.label_x.Size = new System.Drawing.Size(15, 13);
            this.label_x.TabIndex = 9;
            this.label_x.Text = "x:";
            // 
            // label_y
            // 
            this.label_y.AutoSize = true;
            this.label_y.Location = new System.Drawing.Point(50, 300);
            this.label_y.Name = "label_y";
            this.label_y.Size = new System.Drawing.Size(15, 13);
            this.label_y.TabIndex = 10;
            this.label_y.Text = "y:";
            // 
            // label_alive
            // 
            this.label_alive.AutoSize = true;
            this.label_alive.Location = new System.Drawing.Point(15, 190);
            this.label_alive.Name = "label_alive";
            this.label_alive.Size = new System.Drawing.Size(63, 13);
            this.label_alive.TabIndex = 11;
            this.label_alive.Text = "популяция:";
            // 
            // label_stable
            // 
            this.label_stable.AutoSize = true;
            this.label_stable.Location = new System.Drawing.Point(15, 210);
            this.label_stable.Name = "label_stable";
            this.label_stable.Size = new System.Drawing.Size(71, 13);
            this.label_stable.TabIndex = 12;
            this.label_stable.Text = "стабильные:";
            // 
            // label_rules
            // 
            this.label_rules.AutoSize = true;
            this.label_rules.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label_rules.Location = new System.Drawing.Point(15, 15);
            this.label_rules.Name = "label_rules";
            this.label_rules.Size = new System.Drawing.Size(56, 13);
            this.label_rules.TabIndex = 13;
            this.label_rules.Text = "правила";
            // 
            // label_save
            // 
            this.label_save.AutoSize = true;
            this.label_save.Location = new System.Drawing.Point(18, 35);
            this.label_save.Name = "label_save";
            this.label_save.Size = new System.Drawing.Size(68, 13);
            this.label_save.TabIndex = 14;
            this.label_save.Text = "выживание:";
            // 
            // label_born
            // 
            this.label_born.AutoSize = true;
            this.label_born.Location = new System.Drawing.Point(18, 55);
            this.label_born.Name = "label_born";
            this.label_born.Size = new System.Drawing.Size(60, 13);
            this.label_born.TabIndex = 15;
            this.label_born.Text = "рождение:";
            // 
            // button_rules
            // 
            this.button_rules.Location = new System.Drawing.Point(20, 75);
            this.button_rules.Name = "button_rules";
            this.button_rules.Size = new System.Drawing.Size(75, 23);
            this.button_rules.TabIndex = 16;
            this.button_rules.Text = "изменить";
            this.button_rules.UseVisualStyleBackColor = true;
            this.button_rules.MouseClick += new System.Windows.Forms.MouseEventHandler(this.button_rules_MouseClick);
            this.button_rules.PreviewKeyDown += new System.Windows.Forms.PreviewKeyDownEventHandler(this.preview_key_down);
            // 
            // label_history
            // 
            this.label_history.AutoSize = true;
            this.label_history.Location = new System.Drawing.Point(15, 170);
            this.label_history.Name = "label_history";
            this.label_history.Size = new System.Drawing.Size(51, 13);
            this.label_history.TabIndex = 17;
            this.label_history.Text = "история:";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(434, 434);
            this.Controls.Add(this.label_history);
            this.Controls.Add(this.button_rules);
            this.Controls.Add(this.label_born);
            this.Controls.Add(this.label_save);
            this.Controls.Add(this.label_rules);
            this.Controls.Add(this.label_stable);
            this.Controls.Add(this.label_alive);
            this.Controls.Add(this.label_y);
            this.Controls.Add(this.label_x);
            this.Controls.Add(this.label_cursor);
            this.Controls.Add(this.button_color);
            this.Controls.Add(this.button_size);
            this.Controls.Add(this.label_frame);
            this.Controls.Add(this.label_pen_width);
            this.Controls.Add(this.label_step);
            this.Controls.Add(this.label_draw);
            this.Controls.Add(this.pictureBox1);
            this.MinimumSize = new System.Drawing.Size(270, 450);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Game of Life";
            this.Load += new System.EventHandler(this.Form_Load);
            this.ResizeEnd += new System.EventHandler(this.MainForm_ResizeEnd);
            this.Resize += new System.EventHandler(this.MainForm_Resize);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label_draw;
        private System.Windows.Forms.Label label_step;
        private System.Windows.Forms.Label label_pen_width;
        private System.Windows.Forms.Label label_frame;
        private System.Windows.Forms.Button button_size;
        private System.Windows.Forms.Button button_color;
        private System.Windows.Forms.ColorDialog colorDialog1;
        private System.Windows.Forms.Label label_cursor;
        private System.Windows.Forms.Label label_x;
        private System.Windows.Forms.Label label_y;
        private System.Windows.Forms.Label label_alive;
        private System.Windows.Forms.Label label_stable;
        private System.Windows.Forms.Label label_rules;
        private System.Windows.Forms.Label label_save;
        private System.Windows.Forms.Label label_born;
        private System.Windows.Forms.Button button_rules;
        private System.Windows.Forms.Label label_history;
    }
}

