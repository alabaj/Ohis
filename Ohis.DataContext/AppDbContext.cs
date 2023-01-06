using Microsoft.EntityFrameworkCore;
using Ohis.Library.Domain;

namespace Ohis.DataContext;

public class AppDbContext : DbContext
{
    public string DbPath { get; }

    public DbSet<ClientEntity> Clients { get; set; }
    public DbSet<TicketEntity> Tickets { get; set; }

    public AppDbContext()
    {
        var folder = Environment.SpecialFolder.LocalApplicationData;
        var path = Environment.GetFolderPath(folder);
        DbPath = Path.Join(path, "ohis.db");
    }

    protected override void OnConfiguring(DbContextOptionsBuilder options) => options.UseSqlite($"Data Source={DbPath}");
}
