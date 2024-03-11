using EvtifeevaShop.Models.Database;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EvtifeevaShop.Models.View.Admin
{
   public class StatisticsEmployeeModel
    {
		//public DataTable<EmployeeTable> {get;set;}
		public List<Position> PositionList { get; set; }
		public string Selected { get; set; }
		public string Search { get; set; }
		public bool SortAsc { get; set; }
	}
}
