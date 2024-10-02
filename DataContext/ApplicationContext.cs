using Ef_Core.Entities;
using Microsoft.EntityFrameworkCore;

namespace Ef_Core.DataContext;

public sealed class ApplicationContext : DbContext
{

    public DbSet<User> Users { get; set; }

    public ApplicationContext()
    {
        Database.EnsureCreated();
    }

    protected override void OnConfiguring(DbContextOptionsBuilder builder)
    {
        builder.UseNpgsql("Server=localhost;Port=5432;Database=ef_db;Username=postgres;Password=Galchaew05;");
    }
}