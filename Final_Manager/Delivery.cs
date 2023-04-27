using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Final_Manager
{
    internal class Delivery
    {
        public string AgentID { get; set; }
        public string AgentName { get; set; }
        public string Phone { get; set; }
        public string Email { get; set; }
        public string OrderID { get; set; }
        public DateTime OrderDate { get; set; }
        public string TotalAmount { get; set; }

    }
}
