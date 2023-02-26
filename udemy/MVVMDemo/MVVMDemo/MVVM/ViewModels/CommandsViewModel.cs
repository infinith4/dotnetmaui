using System;
using System.Windows.Input;

namespace MVVMDemo.MVVM.ViewModels
{
	public class CommandsViewModel
	{
		public ICommand ClickCommand { get; }

		public CommandsViewModel() {
			ClickCommand = new Command(() =>
			{
				App.Current.MainPage.DisplayAlert("Title", "message", "OK");
            });
		}

        private void Alert() {
			
        }
    }
}

