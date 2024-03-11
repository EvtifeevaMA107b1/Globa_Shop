using EvtifeevaShop.Models.Database;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EvtifeevaShop.Models.View.Admin
{
	public class PickupPointsModel
	{
		public List<PickupPoints> PickupPointsList { get; set; }
		public string SelectedAddress { get; set; }

		public bool SortUp { get; set; }
		public DataTable PickupPointsTable {get; set;}
	}
}
