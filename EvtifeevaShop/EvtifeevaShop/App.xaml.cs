using EvtifeevaShop.ViewModels;
using EvtifeevaShop.ViewModels.Employee;
using System.Configuration;
using System.Data;
using System.Windows;

namespace EvtifeevaShop
{
	/// <summary>
	/// Interaction logic for App.xaml
	/// </summary>
	public partial class App : Application
	{
		protected override void OnStartup(StartupEventArgs e)
		{
			MainWindow mw = new()
			{ DataContext = new CatalogViewModel() };

			mw.Show();			
			base.OnStartup(e);
		}


	}

}
