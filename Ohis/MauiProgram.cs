using Microsoft.Extensions.Logging;
using Ohis.DataContext.Extensions;
using Ohis.Extensions;

namespace Ohis;

public static class MauiProgram
{
    public static MauiApp CreateMauiApp()
    {
        var builder = MauiApp.CreateBuilder();
        builder
            .UseMauiApp<App>()
            .ConfigureFonts(fonts =>
            {
                fonts.AddFont("OpenSans-Regular.ttf", "OpenSansRegular");
                fonts.AddFont("OpenSans-Semibold.ttf", "OpenSansSemibold");
            });

        builder.Services.AddPages();
        builder.Services.AddViewModels();
        builder.Services.AddDatabases();

#if DEBUG
        builder.Logging.AddDebug();
#endif

        return builder.Build();
    }
}
