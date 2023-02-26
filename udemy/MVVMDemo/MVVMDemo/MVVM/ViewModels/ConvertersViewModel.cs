using System;
namespace MVVMDemo.MVVM.ViewModels
{
    public class ConvertersViewModel
    {
        public Models.Data Data { get; set; }
        public ConvertersViewModel()
        {
            Data = new Models.Data
            {
                Married = "YES"
            };
        }
    }
}

