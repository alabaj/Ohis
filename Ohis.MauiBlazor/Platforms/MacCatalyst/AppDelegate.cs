using Foundation;

namespace Ohis.MauiBlazor
{
    [Register("AppDelegate")]
    public class AppDelegate : MauiUIApplicationDelegate
    {
        protected override MauiApp CreateMauiApp() => MauiBlazorProgram.CreateMauiApp();
    }
}