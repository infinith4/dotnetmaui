using System;
using System.Windows.Input;

namespace MVVMDemo.MVVM.ViewModels
{
	public class CommandsViewModel
	{
		public ICommand ClickCommand => new Command(Alert);

		private void Alert() {
			App.Current.MainPage.DisplayAlert("Title", "message", "OK");
        }
    }
}

