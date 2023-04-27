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
    public partial class FormReport : Form
    {
        public FormReport()
        {
            InitializeComponent();
        }

        private void FormReport_Load(object sender, EventArgs e)
        {
           PanelReport.Hide();

        }

        private void ButtonLoad_Click(object sender, EventArgs e)
        {
            try { 
            PanelReport.Show();
            SqlConnection conn = new SqlConnection(Program.strConn);
            conn.Open();

            //String sSQL = "SELECT Orders.OrderID, Orders.AgentID, Agents.AgentName, Orders.OrderDate, Orders.TotalAmount, Orders.PaymentMethod, Orders.PaymentStatus\r\nFROM Orders\r\nINNER JOIN Agents ON Orders.AgentID = Agents.AgentID\r\nWHERE Orders.OrderDate BETWEEN '" + DateTimePickerFrom.Value.ToString("yyyy/MM/dd") + "' AND '" + DateTimePickerTo.Value.ToString("yyyy/MM/dd") + "'";
            string sSQL = "SELECT TOP 10 p.ProductName, SUM(od.Quantity) AS TotalQuantitySold\r\nFROM OrderDetails od\r\nJOIN Orders o ON od.OrderID = o.OrderID\r\nJOIN Products p ON od.ProductID = p.ProductID\r\nWHERE o.OrderDate BETWEEN '" + DateTimePickerFrom.Value.ToString("yyyy/MM/dd") + "' AND '" + DateTimePickerTo.Value.ToString("yyyy/MM/dd") + "'\r\nGROUP BY p.ProductName\r\nORDER BY TotalQuantitySold DESC";

            SqlCommand cmd = new SqlCommand(sSQL, conn);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            DataGridViewBest.DataSource = dt;

            sSQL = "SELECT SUM(o.TotalAmount) \r\nFROM Orders o\r\nWHERE o.OrderDate BETWEEN '" + DateTimePickerFrom.Value.ToString("yyyy/MM/dd") + "' AND '" + DateTimePickerTo.Value.ToString("yyyy/MM/dd") + "'";

            cmd = new SqlCommand(sSQL, conn);
            double TotalRevenue = Convert.ToDouble(cmd.ExecuteScalar());
            TextBoxTotal.Text = TotalRevenue.ToString();

            sSQL = "SELECT SUM(Quantity) AS OutgoingStock\r\nFROM OrderDetails od\r\nJOIN Orders o ON od.OrderID = o.OrderID\r\nWHERE o.OrderDate BETWEEN '" + DateTimePickerFrom.Value.ToString("yyyy/MM/dd") + "' AND '" + DateTimePickerTo.Value.ToString("yyyy/MM/dd") + "'";

            cmd = new SqlCommand(sSQL, conn);
            TextBoxOutcoming.Text = Convert.ToInt64(cmd.ExecuteScalar()).ToString();

            sSQL = "SELECT SUM(Quantity) AS IncomingStock\r\nFROM WarehouseReceiptDetails\r\nJOIN WarehouseReceipts ON WarehouseReceiptDetails.WarehouseReceiptID = WarehouseReceipts.WarehouseReceiptID\r\nWHERE ReceiptDate BETWEEN '" + DateTimePickerFrom.Value.ToString("yyyy/MM/dd") + "' AND '" + DateTimePickerTo.Value.ToString("yyyy/MM/dd") + "'";

            cmd = new SqlCommand(sSQL, conn);
            TextBoxIncoming.Text = Convert.ToInt64(cmd.ExecuteScalar()).ToString();
             }
            catch
            {
                //nothing
            }
        }
    }
}
