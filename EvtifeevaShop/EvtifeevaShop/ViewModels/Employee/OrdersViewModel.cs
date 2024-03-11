using EvtifeevaShop.Models.View;
using EvtifeevaShop.Models.View.Employee;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EvtifeevaShop.ViewModels.Employee
{
    public class OrdersViewModel: ViewModelBase
    {
		private OrdersModel _OrdersModel= new();
		public DataTable OrderTable
		{
			get { return _OrdersModel.OrderTable; }
			set
			{
				_OrdersModel.OrderTable = value;
				OnPropertyChanged(nameof(OrderTable));
			}
		}

		public string PickupPointAddress
		{
			get { return _OrdersModel.PickupPointAddress; }
			set
			{
				_OrdersModel.PickupPointAddress = value;
				OnPropertyChanged(nameof(PickupPointAddress));
			}
		}
		public string CountOrders
		{
			get { return _OrdersModel.CountOrders; }
			set
			{
				_OrdersModel.CountOrders = value;
				OnPropertyChanged(nameof(CountOrders));
			}
		}
	}
}
