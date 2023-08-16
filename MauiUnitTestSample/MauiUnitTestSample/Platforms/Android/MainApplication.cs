using Android.App;
using Android.Runtime;

namespace MauiUnitTestSample;

[Application]
public class MainApplication : MauiApplication
{
	public MainApplication(IntPtr handle, JniHandleOwnership ownership)
		: base(handle, ownership)
	{
        Routing.RegisterRoute("newPage1", typeof(MauiUnitTestSample.Platforms.Android.Views.NewPage1));
    }

	protected override MauiApp CreateMauiApp() => MauiProgram.CreateMauiApp();
}
