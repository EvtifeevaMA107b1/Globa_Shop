using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EvtifeevaShop.Models.Database
{
    public class Order
    {
        public int OrderId { get; set; }

		#region Client
		public int ClientId { get; set; }
        public Client Client { get; set; }
        #endregion

		public DateTime Order_Date { get; set; }
        public decimal Price { get; set; }

		#region PickupPoints
		public int PickupId { get; set; }
        public PickupPoints PickupPoints { get; set; }
		#endregion

		#region OrderStatus
		public int StatusId { get; set; }
        public OrderStatus OrderStatus { get; set; }
		#endregion
	}
}
