using FakeItEasy;
using FakeItEasy.Sdk;
namespace MauiTestProject
{
    public class UnitTest1
    {
        [Fact]
        public void Test1()
        {
            var page = new MauiUnitTestSample.MainPage();
            var count = page.Counter();
            Assert.Equal(1, count);

            var eventArgs = new EventArgs();
            page.OnCounterClicked("", eventArgs);
            //page.OnCounterClicked += (object sender, EventArgs Microsoft.Maui.Controls.Button) => 
            //page.OnCounterClicked += (sender, e) =>
            //{

            //};

        }

        [Fact]
        public void PreferenceTest1()
        {
            //object fake = Create.Fake(typeof(IPreferences));
            //Create.Fake(fake);
            var mainPageFake = A.Fake<MauiUnitTestSample.MainPage>();
            A.CallTo(() => mainPageFake.Counter1()).Returns(2);
            var page = new MauiUnitTestSample.MainPage();
            var count = page.Counter();
            Assert.Equal(1, count);

            var eventArgs = new EventArgs();
            page.OnCounterClicked("", eventArgs);

        }

        [Fact]
        public void PreferenceTest2()
        {
            var preferencesMoq = new Moq.Mock<IPreferences>();
            preferencesMoq.Setup(p => p.Set("testKey", "testval1", ""));
            //object fake = Create.Fake(typeof(IPreferences));
            //Create.Fake(fake);
            //var mainPageFake = A.Fake<MauiUnitTestSample.MainPage>();
            //A.CallTo(() => mainPageFake.Counter1()).Returns(2);
            var page = new MauiUnitTestSample.MainPage();
            var count = page.Counter();
            Assert.Equal(1, count);

            var eventArgs = new EventArgs();
            page.OnCounterClicked("", eventArgs);

        }
    }
}