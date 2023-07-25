using Xunit.Runners.Maui;

namespace xunitrunnersmaui01;

public static class MauiProgram
{
    public static MauiApp CreateMauiApp() => MauiApp
        .CreateBuilder()
        .ConfigureTests(new TestOptions
        {
            Assemblies =
            {
                    typeof(MauiProgram).Assembly,
                    typeof(xunitrunnersmauitests01.UnitTest1).Assembly
            }
        })
        .UseVisualRunner()
        .Build();
}

