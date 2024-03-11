using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EvtifeevaShop.Models.Database
{
    public class Employee
    {
        public int EmployeeId { get; set; }
        public string Name { get; set; }
        public string Phone { get; set; }

		#region Position
		public int PositionId { get; set; }
        public Position Position { get; set; }
		#endregion

		public decimal Salary { get; set; }

		#region PickupPoint
		public int PickupId { get; set; }
        public PickupPoints PickupPoints {get; set; }
		#endregion

	}
}
