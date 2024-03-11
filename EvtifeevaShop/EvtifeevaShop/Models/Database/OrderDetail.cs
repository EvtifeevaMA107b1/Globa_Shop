using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace EvtifeevaShop.Models.Database
{
    public class OrderDetail
    {
        public int DetailId { get; set; }

		#region Order
		public int OrderId { get; set;}
        public Order Order { get; set; }
		#endregion

		#region Product
		public int ProductId { get; set; }
        public Product Product { get; set; }
		#endregion

		public int Count { get; set; }

        public decimal Price { get; set; }

    }
}
