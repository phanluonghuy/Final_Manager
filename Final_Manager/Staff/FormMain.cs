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
        private void guna2ButtonImport_good_Click(object sender, EventArgs e)
        {
            FormImport formAddItems  = new FormImport();
            formAddItems.TopLevel = false;
            this.PanelMain.Controls.Clear();
            this.PanelMain.Controls.Add(formAddItems);
            formAddItems.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            formAddItems.Dock = DockStyle.Fill;
            formAddItems.Show();
            //Load_Form(formAddItems,this.PanelMain);
        }

        private void ButtonGoodsDelivery_Click(object sender, EventArgs e)
        {
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
            FormReport formReport = new FormReport();
            formReport.TopLevel = false;
            this.PanelMain.Controls.Clear();
            this.PanelMain.Controls.Add(formReport);
            formReport.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            formReport.Dock = DockStyle.Fill;
            formReport.Show();
            //Load_Form(formReport, this.PanelMain);
        }
    }
}
