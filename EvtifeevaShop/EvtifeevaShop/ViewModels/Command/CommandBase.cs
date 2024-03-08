﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace EvtifeevaShop.ViewModels.Command
{
	public abstract class CommandBase : ICommand
	{
		public event EventHandler CanExecuteChanged;
		public virtual bool CanExecute(object parameter) => true;
		public abstract void Execute(object parameter);

		protected void OnCanExecuteChanged()
		{
			CanExecuteChanged?.Invoke(this, new EventArgs());
		}
	}

}
