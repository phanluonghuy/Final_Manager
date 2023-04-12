using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Final_Manager
{
    public partial class FormLogin : Form
    {
        public FormLogin()
        {
            InitializeComponent();
        }

        private void FormLogin_Load(object sender, EventArgs e)
        {
            textBoxPassWord.UseSystemPasswordChar = true;
        }

        private void checkBoxShowPw_CheckedChanged(object sender, EventArgs e)
        {
            textBoxPassWord.UseSystemPasswordChar = !checkBoxShowPw.Checked;
        }

        private void buttonForgot_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Please contact admin to restore password!!");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
