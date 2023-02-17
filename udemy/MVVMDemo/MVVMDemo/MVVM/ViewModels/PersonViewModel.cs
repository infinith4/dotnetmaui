using System;
namespace MVVMDemo.MVVM.ViewModels
{
	public class PersonViewModel
	{
        public Models.Person Person { get; set; }
		public PersonViewModel()
		{

            Person = new Models.Person
            {
                Name = "Hiroshi",
                Age = 100
            };
        }
	}
}

