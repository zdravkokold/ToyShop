using ToyShop.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;

namespace ToyShop
{
    public class ToyShopDbContext : IdentityDbContext<User>
    {
        public ToyShopDbContext(DbContextOptions<ToyShopDbContext> options) : base(options)
        {
        }

        public DbSet<Product> Products { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<OrderDetail> OrderDetails { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Product>().HasData(
                new Product { Id = 1, Name = "Teddy Bear", Price = 20.99M },
                new Product { Id = 2, Name = "Lego Set", Price = 49.99M },
                new Product { Id = 3, Name = "Toy Car", Price = 15.50M }
            );
        }
    }
}