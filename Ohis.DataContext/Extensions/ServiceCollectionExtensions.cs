using Microsoft.Extensions.DependencyInjection;
using Ohis.DataContext.Databases.Interfaces;
using Ohis.DataContext.Databases.ReadRepositories;
using Ohis.DataContext.Databases.WriteRepositories;

namespace Ohis.DataContext.Extensions;

public static class ServiceCollectionExtensions
{
    public static void AddDatabases(this IServiceCollection services)
    {
        services.AddDbContext<AppDbContext>();

        services.AddSingleton<IReadClientRepository, ReadClientRepository>();
        services.AddSingleton<IReadTicketRepository, ReadTicketRepository>();

        services.AddSingleton<IWriteClientRepository, WriteClientRepository>();
        services.AddSingleton<IWriteTicketRepository, WriteTicketRepository>();
    }
}
