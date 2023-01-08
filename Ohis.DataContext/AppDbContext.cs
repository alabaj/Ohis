using Microsoft.EntityFrameworkCore;
using Ohis.DataContext.Entities;
using System.Reflection;

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

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder) =>
        optionsBuilder.UseSqlite($"Data Source={DbPath}");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);

        modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());
    }
}
