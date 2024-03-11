using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EvtifeevaShop.Models.View.Employee
{
    class OrdersModel
    {
		public DataTable OrderTable { get; set; }

		public string PickupPointAddress {  get; set; }
		public string CountOrders { get; set;}
	}
}
