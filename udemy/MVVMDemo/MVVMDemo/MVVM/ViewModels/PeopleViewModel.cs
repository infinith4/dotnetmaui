using System;
namespace MVVMDemo.MVVM.ViewModels
{
	public class PeopleViewModel
    {
        public List<string> People { get; set; }
        public PeopleViewModel()
		{
			People = new List<string> {
				"Hector",
                "Bale",
                "Rust",
                "Messi",
                "Rute"
            };

		}
	}
}

