using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EvtifeevaShop.Models.Database
{
    class ProductRatings
    {
        public int RatingId { get; set; }

		#region Product
		public int ProductId { get; set; } 
        public Product Product { get; set; }
		#endregion

		#region Client
		public int ClientId { get; set; }
        public Client Client { get; set; }
		#endregion

		public int Rating { get; set; }
    }
}
