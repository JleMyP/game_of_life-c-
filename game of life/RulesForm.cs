using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Game_of_Life {
    public partial class RulesForm: Form {
        public List<CheckBox> save;
        public List<CheckBox> born;
        
        public RulesForm() {
            InitializeComponent();
            save = new List<CheckBox>{checkBox1, checkBox2, checkBox3, checkBox4, checkBox5, checkBox6, checkBox7, checkBox8};
            born = new List<CheckBox>{checkBox9, checkBox10, checkBox11, checkBox12, checkBox13, checkBox14, checkBox15, checkBox16};
        }

        private void button_ok_Click(object sender, EventArgs e) {
            int s1 = 0, s2 = 0;
            foreach(CheckBox c in save) if(c.Checked) s1++;
            foreach(CheckBox c in born) if(c.Checked) s2++;
            if(s1 == 0)
                MessageBox.Show("не отмечены правила выживания", "ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else if(s2 == 0)
                MessageBox.Show("не отмечены правила рождения", "ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else this.DialogResult = DialogResult.OK;
        }
    }
}
