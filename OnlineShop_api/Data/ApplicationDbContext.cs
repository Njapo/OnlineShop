using Microsoft.EntityFrameworkCore;
using OnlineShop_api.Models;

namespace OnlineShop_api.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) 
            : base(options)
        {  
        }
        public DbSet<Item> Items{ get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Item>().HasData(
            new Item
            {
                Id = 1,
                Name = "Smartphone",
                Description = "Latest smartphone with 128GB storage",
                Price = 599.99m,
                Quantity = 50,
                PhotoUrl = "/Images/Items/smartphone.jpg",
                CreatedDate = DateTime.Now,
                UpdatedDate = DateTime.Now
            },
            new Item
            {
                Id = 2,
                Name = "Laptop",
                Description = "High-performance laptop for gaming and work",
                Price = 1299.99m,
                Quantity = 30,
                PhotoUrl = "/Images/Items/laptop.jpg",
                CreatedDate = DateTime.Now,
                UpdatedDate = DateTime.Now
            },
            new Item
            {
                Id = 3,
                Name = "Headphones",
                Description = "Noise-cancelling over-ear headphones",
                Price = 199.99m,
                Quantity = 100,
                PhotoUrl = "/Images/Items/headphones.jpeg",
                CreatedDate = DateTime.Now,
                UpdatedDate = DateTime.Now
            },
            new Item
            {
                Id = 4,
                Name = "Smartwatch",
                Description = "Waterproof smartwatch with heart rate monitor",
                Price = 149.99m,
                Quantity = 75,
                PhotoUrl = "/Images/Items/smartwatch.jpg",
                CreatedDate = DateTime.Now,
                UpdatedDate = DateTime.Now
            },
            new Item
            {
                Id = 5,
                Name = "Camera",
                Description = "Digital SLR camera with 24.2 MP sensor",
                Price = 899.99m,
                Quantity = 20,
                PhotoUrl = "/Images/Items/camera.jpg",
                CreatedDate = DateTime.Now,
                UpdatedDate = DateTime.Now
            });

        }
    }  
}
