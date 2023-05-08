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

namespace Final_Manager.Staff.Delivery
{
    public partial class FormDeliveryGuest : Form
    {
        string _orderID;
        public FormDeliveryGuest(string OrderID)
        {
            InitializeComponent();
            _orderID = OrderID;
        }

        private void FormDeliveryGuest_Load(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection(Program.strConn);
            conn.Open();
            String sSQL = "select Products.ProductID,Products.ProductName,Products.Brand,OrderDetails_Guest.Quantity,Products.UnitPrice from OrderDetails_Guest \r\nINNER JOIN Products ON Products.ProductID = OrderDetails_Guest.ProductID\r\nwhere OrderDetails_Guest.OrderID = @OrderID";
            SqlCommand cmd = new SqlCommand(sSQL, conn);
            cmd.Parameters.Add(new SqlParameter("@OrderID", _orderID));
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            DataGridViewGuest.DataSource = dt;
        }

        private void ButtonExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ButtonAccept_Click(object sender, EventArgs e)
        {
            SqlConnection connection = new SqlConnection(Program.strConn);
            string sSQL = "UPDATE Orders_Guest\r\nSET Status = 'Delivery'\r\nWHERE OrderID='" + _orderID + "';";
            SqlCommand command = new SqlCommand(sSQL, connection);
            connection.Open();
            command.ExecuteNonQuery();
            MessageBox.Show("You accepted this invoice.");
        }
    }
}
