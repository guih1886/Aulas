using Microsoft.EntityFrameworkCore;
using RabbitMq.Models;

namespace RabbitMq.Data;

public class AppDbContext : DbContext
{
    public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
    {
    }

    public DbSet<Product> Product { get; set; }
    public DbSet<ProductConsumer> ProductsConsumer { get; set; }
    public DbSet<ProductConsumer2> ProductsConsumer2 { get; set; }
}
