using EvtifeevaShop.Models.Database;
using EvtifeevaShop.Models.View.Admin;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EvtifeevaShop.ViewModels.Admin
{
    public class StatisticsEmployeeViewModel: ViewModelBase
    {
		private StatisticsEmployeeModel _StatisticsEmployeeModel = new();

		public List<Position> PositionList
		{
			get { return _StatisticsEmployeeModel.PositionList; }
			set
			{
				_StatisticsEmployeeModel.PositionList = value;
				OnPropertyChanged(nameof(PositionList));
			}
		}

		public string Selected
		{
			get { return _StatisticsEmployeeModel.Selected; }
			set
			{
				_StatisticsEmployeeModel.Selected = value;
				OnPropertyChanged(nameof(Selected));
			}
		}

		public string Search
		{
			get { return _StatisticsEmployeeModel.Search; }
			set
			{
				_StatisticsEmployeeModel.Search = value;
				OnPropertyChanged(nameof(Search));
			}
		}

		public bool SortAsc
		{
			get { return _StatisticsEmployeeModel.SortAsc; }
			set
			{
				_StatisticsEmployeeModel.SortAsc = value;
				OnPropertyChanged(nameof(SortAsc));
			}
		}
		public DataTable EmployeeTable
		{
			get { return _StatisticsEmployeeModel.EmployeeTable; }
			set
			{
				_StatisticsEmployeeModel.EmployeeTable = value;
				OnPropertyChanged(nameof(EmployeeTable));
			}
		}
	}
}
