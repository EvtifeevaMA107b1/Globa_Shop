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

namespace EvtifeevaShop.ViewModels.Admin
{
	public class ProductViewModel :ViewModelBase
	{
		private ProductModel _ProductModel = new();

		public List<Seller> SellerList
		{
			get { return _ProductModel.SellerList; }
			set
			{
				_ProductModel.SellerList = value;
				OnPropertyChanged(nameof(SellerList));
			}
		}
		public string Selected
		{
			get { return _ProductModel.Selected; }
			set
			{
				_ProductModel.Selected = value;
				OnPropertyChanged(nameof(Selected));
			}
		}
		public string Search
		{
			get { return _ProductModel.Search; }
			set
			{
				_ProductModel.Search = value;
				OnPropertyChanged(nameof(Search));
			}
		}

		public bool SortAsc
		{
			get { return _ProductModel.SortAsc; }
			set
			{
				_ProductModel.SortAsc = value;
				OnPropertyChanged(nameof(SortAsc));
			}
		}

		public DataTable ProductTable
		{
			get { return _ProductModel.ProductTable; }
			set
			{
				_ProductModel.ProductTable = value;
				OnPropertyChanged(nameof(ProductTable));
			}
		}

		public ICommand AddProductCommand { get; set; }
		public ICommand ChangeCommand { get; set; }
		public ICommand DeleteCommand { get; set; }
		public ProductViewModel()
		{
			AddProductCommand = new DefaultCommand();
			ChangeCommand = new DefaultCommand();
			DeleteCommand = new DefaultCommand();
		}
	}
}
