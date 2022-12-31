using Ohis.DataContext.Databases;
using Ohis.ViewModels;

namespace Ohis.Extensions
{
    public static class ServicesExtensions
    {
        public static void AddPages(this IServiceCollection services)
        {
            services.AddSingleton<MainPage>();
        }

        public static void AddViewModels(this IServiceCollection services)
        {
            services.AddSingleton<MainViewModel>();
        }
    }
}
