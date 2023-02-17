using System;
using MVVMDemo.MVVM.Models;
namespace MVVMDemo.MVVM.ViewModels
{
	public class PersonViewModel
	{
        public Person Person { get; set; }
		public PersonViewModel()
		{

            Person = new Models.Person
            {
                Name = "infinith4",
                Age = 10,
                Married = true,
                BirthDate = new DateTime(1989, 12, 7),
                Weight = 60,
                Lunchtime = new TimeSpan(10,0,0)
            };
        }
	}
}

