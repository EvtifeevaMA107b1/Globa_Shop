using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EvtifeevaShop.Models.Database
{
    class PointsRatings
    {
        public int RatingId { get; set; }

		#region PickupPoints
		public int PickupId { get; set; }
        public PickupPoints PickupPoints { get; set; }
		#endregion

		#region Client
		public int ClientId { get; set; }
        public Client Client { get; set; }
		#endregion

		public int Rating { get; set; }
    }
}
