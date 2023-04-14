using Final_Manager.Staff;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
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
        String strConn = ConfigurationManager.ConnectionStrings["MyConn"].ConnectionString;
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

        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection(Program.strConn);
            //conn.ConnectionString = @"Data Source=(local); Initial Catalog=LabDB;Integrated Security=True";
            conn.Open();
            String sSQL = "SELECT Username, Password FROM ManagerLogin WHERE Username=@Name and Password=@PWD";

            SqlCommand cmd = new SqlCommand(sSQL, conn);
            //cmd.Parameters.Add("@Name", textBoxUserName.Text.ToString());
            //cmd.Parameters.Add("@PWD", textBoxPassWord.Text.ToString());
            cmd.Parameters.Add(new SqlParameter("@Name", textBoxUserName.Text.ToString()));
            cmd.Parameters.Add(new SqlParameter("@PWD", textBoxPassWord.Text.ToString()));
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            if (dt.Rows.Count > 0)
            {
                FormMain formMain = new FormMain();
                formMain.ShowDialog();
                formMain.Show();
                this.Close();
            }
            else
            {
                MessageBox.Show("Invalid Login. Please check userID or Password!");
            }
        }
    }
}
