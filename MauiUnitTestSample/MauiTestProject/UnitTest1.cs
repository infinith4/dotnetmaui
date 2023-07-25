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
    }
}