using System;
namespace MVVMDemo.MVVM.ViewModels
{
	public class PeopleViewModel
    {
        public List<Models.Person> People { get; set; } = new List<Models.Person>();
        public PeopleViewModel()
        {
            People.Add(new Models.Person() { Name = "test1", Age = 10, BirthDate = new DateTime(1298, 12, 1), Married = true, Weight = 10, Lunchtime = new TimeSpan(12, 30, 0) });
            People.Add(new Models.Person() { Name = "test2", Age = 11, BirthDate = new DateTime(1981, 12, 3), Married = true, Weight = 10, Lunchtime = new TimeSpan(12, 30, 0) });
            People.Add(new Models.Person() { Name = "test3", Age = 13, BirthDate = new DateTime(1984, 12, 5), Married = true, Weight = 10, Lunchtime = new TimeSpan(12, 30, 0) });
            People.Add(new Models.Person() { Name = "test4", Age = 14, BirthDate = new DateTime(2008, 12, 7), Married = true, Weight = 10, Lunchtime = new TimeSpan(12, 30, 0) });
            People.Add(new Models.Person() { Name = "test5", Age = 15, BirthDate = new DateTime(2001, 12, 10), Married = true, Weight = 10, Lunchtime = new TimeSpan(12, 30, 0) });
            People.Add(new Models.Person() { Name = "test6", Age = 16, BirthDate = new DateTime(1989, 12, 11), Married = true, Weight = 10, Lunchtime = new TimeSpan(12, 30, 0) });

        }
	}
}

