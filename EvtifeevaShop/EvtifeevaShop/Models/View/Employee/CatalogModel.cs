using EvtifeevaShop.Models.Database;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;

namespace EvtifeevaShop.Models.View
{
    class CatalogModel
    {
		//public DataTable<ProductTable> { get; set; }
	    public string Search {  get; set; }
		public List<Seller> SellerList { get; set; }
		public string Selected { get; set; }
		public bool filterUp { get; set; }

        
    }
}
