using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Final_Manager.Staff
{
    public partial class FormDelivery_Details : Form
    {
        string _orderID;
        public FormDelivery_Details(string OrderID)
        {
            InitializeComponent();
            _orderID = OrderID;
        }

        private void FormDelivery_Details_Load(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection(Program.strConn);
            conn.Open();
            String sSQL = "SELECT OrderDetails.ProductID, Products.ProductName,OrderDetails.Quantity,Products.UnitPrice,(OrderDetails.Quantity * Products.UnitPrice) AS Total\r\nFROM OrderDetails\r\nINNER JOIN Products ON OrderDetails.ProductID = Products.ProductID\r\nWHERE OrderDetails.OrderID = @OrderID";
            SqlCommand cmd = new SqlCommand(sSQL, conn);
            cmd.Parameters.Add(new SqlParameter("@OrderID", _orderID));
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            DataGridViewDeliveryDetail.DataSource = dt;
            double total = 0.0;

            for (int i = 0; i < DataGridViewDeliveryDetail.RowCount - 1; i++)
            {
                total += Convert.ToDouble(DataGridViewDeliveryDetail.Rows[i].Cells[4].Value);
            }
            TextBoxTotal.Text = total.ToString();
            //MessageBox.Show(DataGridViewDeliveryDetail.Rows[0].Cells[4].Value.ToString());

        }
    }
}
