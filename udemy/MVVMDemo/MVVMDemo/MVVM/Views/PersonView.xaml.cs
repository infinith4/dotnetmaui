using MVVMDemo.MVVM.ViewModels;

namespace MVVMDemo.MVVM.Views;

public partial class PersonView : ContentPage
{
	public PersonView()
	{
		InitializeComponent();
		//var person = new Models.Person
		//{
		//	Name = "Hiroshi",
		//	Age = 32
		//};
		BindingContext = new PersonViewModel();
	}
}
