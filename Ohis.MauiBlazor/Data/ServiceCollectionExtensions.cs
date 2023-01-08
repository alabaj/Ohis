using Ohis.MauiBlazor.Data.Services;
using Ohis.Application.Interfaces;

namespace Ohis.MauiBlazor.Data
{
    public static class ServiceCollectionExtensions
    {
        public static void AddServices(this IServiceCollection services)
        {
            services.AddSingleton<IClientsService, ClientsService>();
        }
    }
}
