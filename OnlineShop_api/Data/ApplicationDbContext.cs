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
        
        public DbSet<LocalUser> LocalUsers{ get; set; }
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
                PhotoUrl = "/Images/Items/camera.jpeg",
                CreatedDate = DateTime.Now,
                UpdatedDate = DateTime.Now
            },
            new Item
            {
                Id = 12,
                Name = "Tablet",
                Description = "Lightweight tablet with 64GB storage and stylus support",
                Price = 399.99m,
                Quantity = 40,
                PhotoUrl = "/Images/Items/tablet.jpg",
                CreatedDate = DateTime.Now,
                UpdatedDate = DateTime.Now
            },
        new Item
        {
            Id = 13,
            Name = "Bluetooth Speaker",
            Description = "Portable Bluetooth speaker with deep bass",
            Price = 79.99m,
            Quantity = 80,
            PhotoUrl = "/Images/Items/bluetooth_speaker.jpg",
            CreatedDate = DateTime.Now,
            UpdatedDate = DateTime.Now
        },
        new Item
        {
            Id = 14,
            Name = "Gaming Mouse",
            Description = "Ergonomic gaming mouse with customizable buttons",
            Price = 59.99m,
            Quantity = 60,
            PhotoUrl = "/Images/Items/gaming_mouse.jpg",
            CreatedDate = DateTime.Now,
            UpdatedDate = DateTime.Now
        },
        new Item
        {
            Id = 15,
            Name = "External Hard Drive",
            Description = "1TB external hard drive for data backup",
            Price = 89.99m,
            Quantity = 25,
            PhotoUrl = "/Images/Items/external_hard_drive.jpg",
            CreatedDate = DateTime.Now,
            UpdatedDate = DateTime.Now
        },
        new Item
        {
            Id = 16,
            Name = "Fitness Tracker",
            Description = "Wearable fitness tracker with sleep monitoring",
            Price = 49.99m,
            Quantity = 90,
            PhotoUrl = "/Images/Items/fitness_tracker.jpg",
            CreatedDate = DateTime.Now,
            UpdatedDate = DateTime.Now
        },
        new Item
        {
            Id = 17,
            Name = "Wireless Keyboard",
            Description = "Slim wireless keyboard with quiet keys and long battery life",
            Price = 39.99m,
            Quantity = 100,
            PhotoUrl = "/Images/Items/wireless_keyboard.jpg",
            CreatedDate = DateTime.Now,
            UpdatedDate = DateTime.Now
        },
        new Item
        {
            Id = 18,
            Name = "4K TV",
            Description = "55-inch 4K Ultra HD Smart TV with HDR",
            Price = 799.99m,
            Quantity = 15,
            PhotoUrl = "/Images/Items/4k_tv.jpg",
            CreatedDate = DateTime.Now,
            UpdatedDate = DateTime.Now
        },
        new Item
        {
            Id = 19,
            Name = "Drone",
            Description = "Quadcopter drone with 4K camera and GPS",
            Price = 499.99m,
            Quantity = 10,
            PhotoUrl = "/Images/Items/drone.jpg",
            CreatedDate = DateTime.Now,
            UpdatedDate = DateTime.Now
        },
        new Item
        {
            Id = 20,
            Name = "Electric Scooter",
            Description = "Foldable electric scooter with a top speed of 25 km/h",
            Price = 349.99m,
            Quantity = 20,
            PhotoUrl = "/Images/Items/electric_scooter.jpg",
            CreatedDate = DateTime.Now,
            UpdatedDate = DateTime.Now
        },
        new Item
        {
            Id = 21,
            Name = "Home Security Camera",
            Description = "Indoor/outdoor security camera with motion detection and night vision",
            Price = 99.99m,
            Quantity = 50,
            PhotoUrl = "/Images/Items/home_security_camera.jpg",
            CreatedDate = DateTime.Now,
            UpdatedDate = DateTime.Now
        });

        }
    }  
}
