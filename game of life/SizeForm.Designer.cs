namespace Game_of_Life {
    partial class SizeForm {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if(disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.button_ok = new System.Windows.Forms.Button();
            this.button_cancle = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox_width = new System.Windows.Forms.TextBox();
            this.textBox_height = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox_cell = new System.Windows.Forms.TextBox();
            this.label_max_w = new System.Windows.Forms.Label();
            this.label_max_h = new System.Windows.Forms.Label();
            this.label_max_c = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // button_ok
            // 
            this.button_ok.Location = new System.Drawing.Point(15, 146);
            this.button_ok.Name = "button_ok";
            this.button_ok.Size = new System.Drawing.Size(75, 23);
            this.button_ok.TabIndex = 0;
            this.button_ok.Text = "применить";
            this.button_ok.UseVisualStyleBackColor = true;
            this.button_ok.Click += new System.EventHandler(this.button_ok_Click);
            // 
            // button_cancle
            // 
            this.button_cancle.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.button_cancle.Location = new System.Drawing.Point(147, 146);
            this.button_cancle.Name = "button_cancle";
            this.button_cancle.Size = new System.Drawing.Size(75, 23);
            this.button_cancle.TabIndex = 1;
            this.button_cancle.Text = "отмена";
            this.button_cancle.UseVisualStyleBackColor = true;
            this.button_cancle.Click += new System.EventHandler(this.button_cancle_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "длина поля";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 65);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "ширина поля";
            // 
            // textBox_width
            // 
            this.textBox_width.Location = new System.Drawing.Point(106, 29);
            this.textBox_width.Name = "textBox_width";
            this.textBox_width.Size = new System.Drawing.Size(55, 20);
            this.textBox_width.TabIndex = 4;
            // 
            // textBox_height
            // 
            this.textBox_height.Location = new System.Drawing.Point(106, 65);
            this.textBox_height.Name = "textBox_height";
            this.textBox_height.Size = new System.Drawing.Size(55, 20);
            this.textBox_height.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 103);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(89, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "размер ячейкии";
            // 
            // textBox_cell
            // 
            this.textBox_cell.Location = new System.Drawing.Point(106, 100);
            this.textBox_cell.Name = "textBox_cell";
            this.textBox_cell.Size = new System.Drawing.Size(55, 20);
            this.textBox_cell.TabIndex = 7;
            // 
            // label_max_w
            // 
            this.label_max_w.AutoSize = true;
            this.label_max_w.Location = new System.Drawing.Point(187, 29);
            this.label_max_w.Name = "label_max_w";
            this.label_max_w.Size = new System.Drawing.Size(54, 13);
            this.label_max_w.TabIndex = 8;
            this.label_max_w.Text = "max width";
            // 
            // label_max_h
            // 
            this.label_max_h.AutoSize = true;
            this.label_max_h.Location = new System.Drawing.Point(187, 65);
            this.label_max_h.Name = "label_max_h";
            this.label_max_h.Size = new System.Drawing.Size(58, 13);
            this.label_max_h.TabIndex = 9;
            this.label_max_h.Text = "max height";
            // 
            // label_max_c
            // 
            this.label_max_c.AutoSize = true;
            this.label_max_c.Location = new System.Drawing.Point(187, 100);
            this.label_max_c.Name = "label_max_c";
            this.label_max_c.Size = new System.Drawing.Size(45, 13);
            this.label_max_c.TabIndex = 10;
            this.label_max_c.Text = "max cell";
            // 
            // DialogFrom
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.button_cancle;
            this.ClientSize = new System.Drawing.Size(261, 187);
            this.ControlBox = false;
            this.Controls.Add(this.label_max_c);
            this.Controls.Add(this.label_max_h);
            this.Controls.Add(this.label_max_w);
            this.Controls.Add(this.textBox_cell);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBox_height);
            this.Controls.Add(this.textBox_width);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button_cancle);
            this.Controls.Add(this.button_ok);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "DialogFrom";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "размер поля";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button_ok;
        private System.Windows.Forms.Button button_cancle;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox_width;
        private System.Windows.Forms.TextBox textBox_height;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox_cell;
        private System.Windows.Forms.Label label_max_w;
        private System.Windows.Forms.Label label_max_h;
        private System.Windows.Forms.Label label_max_c;
    }
}