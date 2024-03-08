using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EvtifeevaShop.Models.Database
{
    class OrdersReceipt
    {
        public int ReceiptId { get; set; }

		#region Employee
		public int EmployeeId { get; set; }
        public Employee Employee { get; set; }
		#endregion

		#region Order
		public int OrderId { get; set; }
        public Order Order { get; set; }
		#endregion

		public DateTime Receipt_Date { get; set; }
    }
}
