using EvtifeevaShop.Models.Database;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EvtifeevaShop.Models.View.Admin
{
     class ProductModel
    {
        public DataTable ProductTable  {get;set;}
        
        public  List<Seller> SellerList { get; set; }
        public string Selected { get; set; }
        public string Search {  get; set; } 
        public bool SortAsc {  get; set; }
    }
}
