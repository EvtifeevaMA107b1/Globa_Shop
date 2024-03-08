using EvtifeevaShop.Models.View;
using EvtifeevaShop.ViewModels.Command;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace EvtifeevaShop.ViewModels
{
	class LoginViewModel: ViewModelBase
	{
		private LoginModel _LoginModel = new ();

		public string Login
		{
			get { return _LoginModel.Login; }
	        set { _LoginModel.Login = value;
				OnPropertyChanged(nameof(Login));}
		}

		public string Password
		{
			get
			{ return _LoginModel.Password; }
			set
			{
				_LoginModel.Password = value;
				OnPropertyChanged(nameof(Password));
			}
		}

		public ICommand LoginCommand { get; set; }
		public LoginViewModel() {
			LoginCommand = new DefaultCommand();
		}
	}
}
