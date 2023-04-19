using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Final_Manager
{
    internal class WarehouseReceipts
    {
        public string ProductID { get; set; }
        public string ProductName { get; set; }
        public string Brand { get; set; }
        public string Description { get; set; }
        public double UnitPrice { get; set; }
        public DateTime ReceiptDate { get; set; }
        public int Quantity { get; set; }

        public string Total { get { return string.Format("{0}đ", UnitPrice * Quantity); } }
    }
}
