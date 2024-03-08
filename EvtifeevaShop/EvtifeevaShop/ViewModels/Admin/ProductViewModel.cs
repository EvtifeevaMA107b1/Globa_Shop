using EvtifeevaShop.Models.Database;
using EvtifeevaShop.Models.View;
using EvtifeevaShop.Models.View.Admin;
using EvtifeevaShop.ViewModels.Command;
using System;
using System.Collections.Generic;
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




	

		public ICommand LoginCommand { get; set; }
		public LoginViewModel()
		{
			LoginCommand = new DefaultCommand();
		}
	}
}
