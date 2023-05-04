using Final_Manager.Staff.Setting;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Final_Manager.Staff
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }
        //private void Load_Form(Form form,Panel panel)
        //{
        //    form = new Form();
        //    form.TopLevel = false;
        //    panel.Controls.Clear();
        //    panel.Controls.Add(form);
        //    form.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
        //    form.Dock = DockStyle.Fill;
        //    form.Show();

        //}
        private void set_default_color_button()
        {
            Color dfColor = Color.FromArgb(15, 157, 88);
            ButtonImport_good.FillColor = dfColor;
            ButtonGoodsDelivery.FillColor = dfColor;
            ButtonReport.FillColor = dfColor;
            ButtonSettings.FillColor = dfColor;
        }
        private void guna2ButtonImport_good_Click(object sender, EventArgs e)
        {
            set_default_color_button();
            ButtonImport_good.FillColor = Color.DarkCyan;
            FormImport formAddItems  = new FormImport();
            formAddItems.TopLevel = false;
            this.PanelMain.Controls.Clear();
            this.PanelMain.Controls.Add(formAddItems);
            formAddItems.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            formAddItems.Dock = DockStyle.Fill;
            formAddItems.Show();
            //MessageBox.Show(DateTime.Now.ToString("ssHHddyy"));
            //Load_Form(formAddItems,this.PanelMain);
            
        }

        private void ButtonGoodsDelivery_Click(object sender, EventArgs e)
        {
            set_default_color_button();
            ButtonGoodsDelivery.FillColor = Color.DarkCyan;
            FormDelivery formDelivery = new FormDelivery();
            formDelivery.TopLevel = false;
            this.PanelMain.Controls.Clear();
            this.PanelMain.Controls.Add(formDelivery);
            formDelivery.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            formDelivery.Dock = DockStyle.Fill;
            formDelivery.Show();
            //Load_Form(formDelivery, this.PanelMain);
        }

        private void ButtonReport_Click(object sender, EventArgs e)
        {
            set_default_color_button();
            ButtonReport.FillColor = Color.DarkCyan;
            FormReport formReport = new FormReport();
            formReport.TopLevel = false;
            this.PanelMain.Controls.Clear();
            this.PanelMain.Controls.Add(formReport);
            formReport.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            formReport.Dock = DockStyle.Fill;
            formReport.Show();
            //Load_Form(formReport, this.PanelMain);
        }

        private void ButtonSettings_Click(object sender, EventArgs e)
        {
            set_default_color_button();
            ButtonSettings.FillColor = Color.DarkCyan;
            FormSetting setting = new FormSetting();
            setting.TopLevel = false;
            this.PanelMain.Controls.Clear();
            this.PanelMain.Controls.Add(setting);
            setting.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            setting.Dock = DockStyle.Fill;
            setting.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void FormMain_Load(object sender, EventArgs e)
        {
           //FormLogin.
        }
    }
}
