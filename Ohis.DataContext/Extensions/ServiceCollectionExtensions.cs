using Microsoft.Extensions.DependencyInjection;
using Ohis.DataContext.Databases.ReadRepositories;
using Ohis.DataContext.Databases.WriteRepositories;

namespace Ohis.DataContext.Extensions
{
    public static class ServiceCollectionExtensions
    {
        public static void AddDatabases(this IServiceCollection services)
        {
            services.AddSingleton<ReadClientRepository>();
            services.AddSingleton<WriteClientRepository>();
        }
    }
}
