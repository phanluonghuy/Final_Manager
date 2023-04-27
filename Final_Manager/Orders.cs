using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Final_Manager
{
    internal class Orders
    {
        public string OrderID { get; set; }
        public string AgentID { get; set; }
        public string AgentName { get; set; }
        public DateTime OrderDate { get; set; }
        public decimal TotalAmount { get; set; }
        public string PaymentMethod { get; set; }
        public string Status { get; set;}
    }
}
