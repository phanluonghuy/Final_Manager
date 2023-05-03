using Final_Manager.Staff.Delivery;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Final_Manager.Staff
{
    public partial class FormDelivery : Form
    {
        public FormDelivery()
        {
            InitializeComponent();
        }

        private void FormDelivery_Load(object sender, EventArgs e)
        {
            //SqlConnection conn = new SqlConnection(Program.strConn);
            //conn.Open();
            //String sSQL = "SELECT Orders.OrderID, Orders.AgentID, Agents.AgentName, Orders.OrderDate, Orders.TotalAmount, Orders.PaymentMethod, Orders.PaymentStatus\r\nFROM Orders\r\nINNER JOIN Agents ON Orders.AgentID = Agents.AgentID\r\nWHERE Orders.OrderDate BETWEEN " +DateTimePickerFrom.Value.ToString() + "AND" + DateTimePickerTo.Value.ToString();
            //SqlCommand cmd = new SqlCommand(sSQL, conn);
            //SqlDataAdapter da = new SqlDataAdapter(cmd);
            //DataTable dt = new DataTable();
            //da.Fill(dt);
            //DataGridViewDelivery.DataSource = dt;
        }

        private void DataGridViewDelivery_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
        


            if (this.DataGridViewDelivery.SelectedRows.Count > 0)
            {
                
                //DataGridViewRow row = this.DataGridViewDelivery.Rows[e.RowIndex];
                //FormDelivery_Details formDelivery_Details = new FormDelivery_Details(row.Cells[0].Value.ToString());
                //formDelivery_Details.ShowDialog();
                DataGridViewRow row = this.DataGridViewDelivery.Rows[e.RowIndex];
                FromDelivery_Report fromDelivery_Report = new FromDelivery_Report(row.Cells[0].Value.ToString());
                fromDelivery_Report.ShowDialog();
            }

        }

        private void ButtonLoad_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection(Program.strConn);
            conn.Open();
            String sSQL = "SELECT Orders.OrderID, Orders.AgentID, Agents.AgentName, Orders.OrderDate, Orders.TotalAmount, Orders.PaymentMethod, Orders.Status\r\nFROM Orders\r\nINNER JOIN Agents ON Orders.AgentID = Agents.AgentID\r\nWHERE Orders.OrderDate BETWEEN '" + DateTimePickerFrom.Value.ToString("yyyy/MM/dd") + "' AND '" + DateTimePickerTo.Value.ToString("yyyy/MM/dd") + "'";
            SqlCommand cmd = new SqlCommand(sSQL, conn);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            DataGridViewDelivery.DataSource = dt;
        }

        private void guna2Button1_Click_1(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection(Program.strConn);
            conn.Open();
            String sSQL = "SELECT  * FROM Orders_Guest \r\nWHERE OrderDate BETWEEN '" + DateTimePickerFromGuest.Value.ToString("yyyy/MM/dd") + "' AND '" + DateTimePickerToGuest.Value.ToString("yyyy/MM/dd") + "'";
            SqlCommand cmd = new SqlCommand(sSQL, conn);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            DataGridViewGuest.DataSource = dt;

        }

        private void DataGridViewGuest_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (this.DataGridViewDelivery.SelectedRows.Count > 0)
            {

                //DataGridViewRow row = this.DataGridViewDelivery.Rows[e.RowIndex];
                //FormDelivery_Details formDelivery_Details = new FormDelivery_Details(row.Cells[0].Value.ToString());
                //formDelivery_Details.ShowDialog();
                DataGridViewRow row = this.DataGridViewGuest.Rows[e.RowIndex];
                FormDeliveryGuest formDeliveryGuest = new FormDeliveryGuest(row.Cells[4].Value.ToString());
                formDeliveryGuest.ShowDialog();
            }

        }
    }
}
