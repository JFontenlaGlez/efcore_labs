
using EFCore.Shared;
using Microsoft.EntityFrameworkCore;
using System.Reflection.Emit;

namespace EfCore.Shared;

public class AppDbContext : DbContext
{
    public DbSet<Order> Orders => Set<Order>();
    public DbSet<OrderItem> OrderItems => Set<OrderItem>();
    public DbSet<Customer> Customers => Set<Customer>();
    public DbSet<Product> Products => Set<Product>();

    public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }

    protected override void OnModelCreating(ModelBuilder b)
    {
        b.Entity<Customer>().HasIndex(x => x.Email).IsUnique();
        b.Entity<OrderItem>().Property(x => x.UnitPrice).HasPrecision(18, 2);
        b.Entity<OrderItem>().HasIndex(oi => oi.ProductId);
        b.Entity<Order>().HasIndex(o => o.CreatedAt);

    }
}

public static class Db
{
    public static DbContextOptions<AppDbContext> Sqlite(string path = "eflab.db")
        => new DbContextOptionsBuilder<AppDbContext>()
           .UseSqlite($"Data Source={path}")
           .Options;
}
