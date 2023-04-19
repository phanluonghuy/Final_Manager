using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Final_Manager.Staff
{
    public partial class FormImport : Form
    {
        String strConn = ConfigurationManager.ConnectionStrings["MyConn"].ConnectionString;
 
        public FormImport()
        {
            InitializeComponent();
        }

        private void FormImport_Load(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection(Program.strConn);
            conn.Open();
            String sSQL = "SELECT * FROM Products";
            SqlCommand cmd = new SqlCommand(sSQL, conn);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);

            ComboBoxQuickAdd.ValueMember = "ProductID";
            ComboBoxQuickAdd.DisplayMember = "ProductName";
            ComboBoxQuickAdd.DataSource = dt;
        }
        private string Generate_id(string brand)
        {
            string date = DateTime.Now.ToString("yyddHHss");
            return brand.ToUpper().Substring(0,3) + date;
        }
        private void ButtonAdd_Click(object sender, EventArgs e)
        {
            try
            {
                WarehouseReceipts receipts = new WarehouseReceipts()
                {
                    ProductID = Generate_id(TextBoxBrand.Text),
                    ProductName = TextBoxName.Text,
                    Brand = TextBoxBrand.Text,
                    Description = TextBoxDescription.Text,
                    UnitPrice = Convert.ToDouble(TextBoxUnitPrice.Text),
                    ReceiptDate = DateTime.Now,
                    Quantity = Convert.ToInt16(TextBoxQuanity.Text),
                };
                warehouseReceiptsBindingSource.Add(receipts);
                TextBoxBrand.Text = string.Empty;
                TextBoxName.Text = string.Empty;
                TextBoxDescription.Text = string.Empty;
                TextBoxQuanity.Text = string.Empty;
                TextBoxUnitPrice.Text = string.Empty;
            }
            catch(Exception) {
                MessageBox.Show("Please input correct format");
            }
        }

        private void ButtonRemove_Click(object sender, EventArgs e)
        {
            if (this.DataGridViewImport.SelectedRows.Count > 0)
            {
                DataGridViewImport.Rows.RemoveAt(this.DataGridViewImport.SelectedRows[0].Index);
            }
        }

        private void ButtonImport_Click(object sender, EventArgs e)
        {
            string query;
            SqlConnection conn = new SqlConnection(Program.strConn);
            conn.Open();
            SqlCommand sqlCommand = new SqlCommand();
            string WarehouseReceiptID = DateTime.Now.ToString("yyddHHss");
            query = "INSERT INTO WarehouseReceipts (WarehouseReceiptID,ReceiptDate) VALUES (@WarehouseReceiptID,@ReceiptDate);";
            sqlCommand = new SqlCommand(query, conn);
            sqlCommand.Parameters.Add(new SqlParameter("@WarehouseReceiptID", WarehouseReceiptID));
            sqlCommand.Parameters.Add(new SqlParameter("@ReceiptDate", DateTimePickerImport.Value.ToString("MM/dd/yyyy")));
            sqlCommand.ExecuteNonQuery();
            sqlCommand.Parameters.Clear();

            string ProductID;
            for (int i = 0;i < DataGridViewImport.RowCount-1;i++)
            {
                query = "SELECT * FROM Products WHERE ProductName=@Name;";
                sqlCommand = new SqlCommand(query, conn);
                sqlCommand.Parameters.Add(new SqlParameter("@Name", DataGridViewImport.Rows[i].Cells[1].Value.ToString()));
                SqlDataAdapter da = new SqlDataAdapter(sqlCommand);
                DataTable dt = new DataTable();
                da.Fill(dt);
                if (dt.Rows.Count <= 0)
                {
                    sqlCommand.Parameters.Clear();
                    query = "INSERT INTO Products (ProductID, ProductName, Description, Brand, UnitPrice) VALUES (@ProductID, @ProductName, @Description, @Brand, @UnitPrice);";
                    ProductID = DataGridViewImport.Rows[i].Cells[0].Value.ToString();
                    sqlCommand = new SqlCommand(query, conn);
                    sqlCommand.Parameters.Add(new SqlParameter("@ProductID", DataGridViewImport.Rows[i].Cells[0].Value.ToString()));
                    sqlCommand.Parameters.Add(new SqlParameter("@ProductName", DataGridViewImport.Rows[i].Cells[1].Value.ToString()));
                    sqlCommand.Parameters.Add(new SqlParameter("@Description", DataGridViewImport.Rows[i].Cells[3].Value.ToString()));
                    sqlCommand.Parameters.Add(new SqlParameter("@Brand", DataGridViewImport.Rows[i].Cells[2].Value.ToString()));
                    sqlCommand.Parameters.Add(new SqlParameter("@UnitPrice", DataGridViewImport.Rows[i].Cells[4].Value.ToString()));
                    sqlCommand.ExecuteNonQuery();
                }
                else
                {
                    DataRowView vrow = (DataRowView)ComboBoxQuickAdd.SelectedItem;
                    DataRow row = vrow.Row;
                    ProductID = row["ProductID"].ToString();
                }
                query = "INSERT INTO WarehouseReceiptDetails (WarehouseReceiptID,ProductID,Quantity) VALUES (@WarehouseReceiptID,@ProductID,@Quantity);";
                sqlCommand = new SqlCommand(query, conn);
                sqlCommand.Parameters.Clear();
                sqlCommand.Parameters.Add(new SqlParameter("@WarehouseReceiptID", WarehouseReceiptID));
                sqlCommand.Parameters.Add(new SqlParameter("ProductID", ProductID));
                sqlCommand.Parameters.Add(new SqlParameter("@Quantity", DataGridViewImport.Rows[i].Cells[6].Value.ToString()));
                sqlCommand.ExecuteNonQuery();
            }
            MessageBox.Show("Import successfull !!");
            DataGridViewImport.Rows.Clear();
       
        }
        private void ComboBoxQuickAdd_SelectionChangeCommitted(object sender, EventArgs e)
        {
            DataRowView vrow = (DataRowView)ComboBoxQuickAdd.SelectedItem;
            DataRow row = vrow.Row;
            TextBoxName.Text = row["ProductName"].ToString();
            TextBoxDescription.Text = row["Description"].ToString();
            TextBoxBrand.Text = row["Brand"].ToString();
            TextBoxUnitPrice.Text = row["UnitPrice"].ToString();
        }
    }
}
