using System;
using Xunit;

namespace xunitrunnersmaui01
{
	public class UtilTest
    {
        [Fact]
        public void aaaa()
        {
            var mainPage = new MainPage();
            Assert.Equal(1, mainPage.aaa());
        }
        [Fact]
        public void aaaa1()
        {
            var mainPage = new mainmauiapp01.MainPage();
            Assert.Equal(1, mainPage.Count());
        }
    }
}

