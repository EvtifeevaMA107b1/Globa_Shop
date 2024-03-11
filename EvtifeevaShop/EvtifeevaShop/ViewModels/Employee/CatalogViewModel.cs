using EvtifeevaShop.Models.Database;
using EvtifeevaShop.Models.View;
using EvtifeevaShop.Models.View.Admin;
using EvtifeevaShop.ViewModels.Command;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace EvtifeevaShop.ViewModels.Employee
{
    public class CatalogViewModel: ViewModelBase
    {
		private CatalogModel _CatalogModel = new();
		public DataTable ProductTable
		{
			get { return _CatalogModel.ProductTable; }
			set
			{
				_CatalogModel.ProductTable = value;
				OnPropertyChanged(nameof(ProductTable));
			}
		}

		public string Search
		{
			get { return _CatalogModel.Search; }
			set
			{
				_CatalogModel.Search = value;
				OnPropertyChanged(nameof(Search));
			}
		}
		public List<Seller> SellerList
		{
			get { return _CatalogModel.SellerList; }
			set
			{
				_CatalogModel.SellerList = value;
				OnPropertyChanged(nameof(SellerList));
			}
		}
		public string Selected
		{
			get { return _CatalogModel.Selected; }
			set
			{
				_CatalogModel.Selected = value;
				OnPropertyChanged(nameof(Selected));
			}
		}

		public bool FilterUp
		{
			get { return _CatalogModel.FilterUp; }
			set
			{
				_CatalogModel.FilterUp = value;
				OnPropertyChanged(nameof(FilterUp));
			}
		}
		public ICommand CatalogCommand { get; set; }
		public CatalogViewModel()
		{
			CatalogCommand = new DefaultCommand();
		}

	}
}
