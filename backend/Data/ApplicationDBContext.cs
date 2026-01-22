using Microsoft.EntityFrameworkCore;
using MiniGroceryOrderSystem.API.Models;
namespace MiniGroceryOrderSystem.API.Data
{
    public class ApplicationDBContext : DbContext
    {
        public ApplicationDBContext(DbContextOptions<ApplicationDBContext> 
            dbContext) : base(dbContext)
        {

        }

        public DbSet<Product> Products { get; set; }
        public DbSet<Order> Orders { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Order>().HasOne(x => x.Product).WithMany().HasForeignKey(x => x.ProductId);

            modelBuilder.Entity<Product>().HasData(
                new Product { Id = 1, Name = "Laptop", Price = 100000, Stock = 50 },
                new Product { Id = 2, Name = "Mobile", Price = 50000, Stock = 35 },
                new Product { Id = 3, Name = "Camera", Price = 75000, Stock = 60 }
                );
        }
    }
}
