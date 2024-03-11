using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EvtifeevaShop.Models.Database
{
    public class PickupPoints
    {
        public int PickupId { get; set; }
        public string Address { get; set; }
        public string Operating_Mode { get; set; }
        public string Phone { get; set; }
        public double Rating { get; set; }
    }
}
