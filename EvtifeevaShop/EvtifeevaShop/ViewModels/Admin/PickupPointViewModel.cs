using EvtifeevaShop.Models.Database;
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
	public  class PickupPointsViewModel: ViewModelBase
	{
		private PickupPointsModel _PickupPointsModel = new();

		public List<PickupPoints> PickupPointsList
		{
			get { return _PickupPointsModel.PickupPointsList; }
			set
			{
				_PickupPointsModel.PickupPointsList = value;
				OnPropertyChanged(nameof(PickupPointsList));
			}
		}
		public string SelectedAddress
		{
			get { return _PickupPointsModel.SelectedAddress; }
			set
			{
				_PickupPointsModel.SelectedAddress = value;
				OnPropertyChanged(nameof(SelectedAddress));
			}
		}
		public bool SortUp
		{
			get { return _PickupPointsModel.SortUp; }
			set
			{
				_PickupPointsModel.SortUp = value;
				OnPropertyChanged(nameof(SortUp));
			}
		}
		public DataTable PickupPointsTable
		{
			get { return _PickupPointsModel.PickupPointsTable; }
			set
			{
				_PickupPointsModel.PickupPointsTable = value;
				OnPropertyChanged(nameof(PickupPointsTable));
			}
		}
		public ICommand PickupPointsCommand { get; set; }
		public PickupPointsViewModel()
		{
			PickupPointsCommand = new DefaultCommand();
			
		}

	}
}
