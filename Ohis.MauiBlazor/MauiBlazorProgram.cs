using AutoMapper;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Logging;
using Ohis.DataContext;
using Ohis.DataContext.Extensions;
using Ohis.DataContext.Mappings;
using Ohis.MauiBlazor.Data;
using System.Reflection;

namespace Ohis.MauiBlazor
{
    public static class MauiBlazorProgram
    {
        public static MauiApp CreateMauiApp()
        {
            var builder = MauiApp.CreateBuilder();
            
            builder
                .UseMauiApp<App>()
                .ConfigureFonts(fonts =>
                {
                    fonts.AddFont("OpenSans-Regular.ttf", "OpenSansRegular");
                });

            builder.Services.AddMauiBlazorWebView();

#if DEBUG
            builder.Services.AddBlazorWebViewDeveloperTools();
            builder.Logging.AddDebug();
#endif

            builder.Services.AddSingleton<WeatherForecastService>();
            builder.Services.AddDatabases();
            builder.Services.AddServices();
            builder.Services.AddAutoMapper(AppDomain.CurrentDomain.GetAssemblies());

            using AppDbContext context = new AppDbContext();
            context.Database.Migrate();

            return builder.Build();
        }
    }
}