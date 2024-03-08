using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EvtifeevaShop.Models.Database
{
    class Product
    {
        public int ProductId { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }

		#region Seller
		public int SellerId { get; set; }
        public Seller Seller { get; set; }
		#endregion

		public decimal Price { get; set; }
        public double Rating { get; set; }
    }
}
