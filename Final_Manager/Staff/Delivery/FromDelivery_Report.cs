using Microsoft.ReportingServices.Diagnostics.Internal;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Final_Manager.Staff.Delivery
{
    public partial class FromDelivery_Report : Form
    {
        string _orderID,_name,_phone,_email,_payment, _orderdate;

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            e.Graphics.DrawImage(bmp, 0, -50);
        }

        private void ButtonExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ButtonAccept_Click(object sender, EventArgs e)
        {
            SqlConnection connection = new SqlConnection(Program.strConn);
            string sSQL = "UPDATE Orders\r\nSET Status = 'Delivery'\r\nWHERE OrderID='" + _orderID + "';";
            SqlCommand command = new SqlCommand(sSQL, connection);
            connection.Open();
            command.ExecuteNonQuery();
            MessageBox.Show("You accepted this invoice. Please print invoices");
        }

        private void textBoxEmail_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBoxOrderID_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBoxTotal_TextChanged(object sender, EventArgs e)
        {

        }

        Bitmap bmp;
        private void ButtonPrint_Click(object sender, EventArgs e)
        {
            var frm = Form.ActiveForm;
            using (bmp = new Bitmap(frm.Width, frm.Height))
            {
                frm.DrawToBitmap(bmp, new Rectangle(0, 0, bmp.Width, bmp.Height));
                //bmp.Save(@"D:\C# SE\FINAL\screenshot.png");
                printPreviewDialog1.ShowDialog(this);
            }

        }
        public FromDelivery_Report(string OrderID)
        {
            InitializeComponent();
            _orderID = OrderID;
        }

        public void getData()
        {
            string query = "SELECT Orders.OrderID, Agents.AgentName, Agents.Phone, Agents.Email, Orders.OrderDate, Orders.PaymentMethod\r\nFROM Orders\r\nINNER JOIN Agents ON Orders.AgentID = Agents.AgentID\r\nWHERE Orders.OrderID = " + _orderID;

            using (SqlConnection connection = new SqlConnection(Program.strConn))
            {
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.Clear();
                //command.Parameters.Add(new SqlParameter("@OrderID", _orderID));
                connection.Open();

                SqlDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {
                    string orderID = reader.GetString(0);
                    _name = reader.GetString(1);
                    _phone = reader.GetString(2);
                    _email = reader.GetString(3);
                    _orderdate = reader.GetDateTime(4).ToString();
                    _payment = reader.GetString(5);

                    // Do something with the retrieved data, e.g. add it to a list or display it in a table
                }

                reader.Close();
            }

        }
        private void FromDelivery_Report_Load(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection(Program.strConn);
            conn.Open();
            String sSQL = "SELECT OrderDetails.ProductID, Products.ProductName,OrderDetails.Quantity,Products.UnitPrice,(OrderDetails.Quantity * Products.UnitPrice) AS Total\r\nFROM OrderDetails\r\nINNER JOIN Products ON OrderDetails.ProductID = Products.ProductID\r\nWHERE OrderDetails.OrderID = @OrderID";
            SqlCommand cmd = new SqlCommand(sSQL, conn);
            cmd.Parameters.Add(new SqlParameter("@OrderID", _orderID));
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            DataGridViewReport.DataSource = dt;
            double total = 0.0;

            for (int i = 0; i < DataGridViewReport.RowCount - 1; i++)
            {
                total += Convert.ToDouble(DataGridViewReport.Rows[i].Cells[4].Value);
            }
            getData();
            textBoxTotal.Text = total.ToString();
            textBoxOrderID.Text = _orderID;
            textBoxName.Text = _name;
            textBoxEmail.Text = _email;
            textBoxPhone.Text = _phone;
            textBoxDate.Text = _orderdate;
            textBoxPayment.Text = _payment;
            textBoxCurrentDate.Text = DateTime.Now.ToString("g");
        }
    }
}
