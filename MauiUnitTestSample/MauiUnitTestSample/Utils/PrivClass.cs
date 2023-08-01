using System;
namespace MauiUnitTestSample.Utils
{
	class PrivClass
	{
		private static string _privStr { get; set; }

        public static string AddStr()
        {
            return $"{_privStr}AddStr";
        }

        protected static string ConstStr()
        {
            return $"ConstStr";
        }
    }
}

