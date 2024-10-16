﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using OnlineShop_api.Data;

#nullable disable

namespace OnlineShop_api.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    [Migration("20241018182122_SeedMoreItemData")]
    partial class SeedMoreItemData
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.3")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("OnlineShop_api.Models.Item", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PhotoUrl")
                        .HasColumnType("nvarchar(max)");

                    b.Property<decimal>("Price")
                        .HasColumnType("decimal(18,2)");

                    b.Property<int>("Quantity")
                        .HasColumnType("int");

                    b.Property<DateTime>("UpdatedDate")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.ToTable("Items");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            CreatedDate = new DateTime(2024, 10, 18, 22, 21, 22, 151, DateTimeKind.Local).AddTicks(6342),
                            Description = "Latest smartphone with 128GB storage",
                            Name = "Smartphone",
                            PhotoUrl = "/Images/Items/smartphone.jpg",
                            Price = 599.99m,
                            Quantity = 50,
                            UpdatedDate = new DateTime(2024, 10, 18, 22, 21, 22, 151, DateTimeKind.Local).AddTicks(6352)
                        },
                        new
                        {
                            Id = 2,
                            CreatedDate = new DateTime(2024, 10, 18, 22, 21, 22, 151, DateTimeKind.Local).AddTicks(6355),
                            Description = "High-performance laptop for gaming and work",
                            Name = "Laptop",
                            PhotoUrl = "/Images/Items/laptop.jpg",
                            Price = 1299.99m,
                            Quantity = 30,
                            UpdatedDate = new DateTime(2024, 10, 18, 22, 21, 22, 151, DateTimeKind.Local).AddTicks(6355)
                        },
                        new
                        {
                            Id = 3,
                            CreatedDate = new DateTime(2024, 10, 18, 22, 21, 22, 151, DateTimeKind.Local).AddTicks(6357),
                            Description = "Noise-cancelling over-ear headphones",
                            Name = "Headphones",
                            PhotoUrl = "/Images/Items/headphones.jpeg",
                            Price = 199.99m,
                            Quantity = 100,
                            UpdatedDate = new DateTime(2024, 10, 18, 22, 21, 22, 151, DateTimeKind.Local).AddTicks(6358)
                        },
                        new
                        {
                            Id = 4,
                            CreatedDate = new DateTime(2024, 10, 18, 22, 21, 22, 151, DateTimeKind.Local).AddTicks(6359),
                            Description = "Waterproof smartwatch with heart rate monitor",
                            Name = "Smartwatch",
                            PhotoUrl = "/Images/Items/smartwatch.jpg",
                            Price = 149.99m,
                            Quantity = 75,
                            UpdatedDate = new DateTime(2024, 10, 18, 22, 21, 22, 151, DateTimeKind.Local).AddTicks(6360)
                        },
                        new
                        {
                            Id = 5,
                            CreatedDate = new DateTime(2024, 10, 18, 22, 21, 22, 151, DateTimeKind.Local).AddTicks(6361),
                            Description = "Digital SLR camera with 24.2 MP sensor",
                            Name = "Camera",
                            PhotoUrl = "/Images/Items/camera.jpeg",
                            Price = 899.99m,
                            Quantity = 20,
                            UpdatedDate = new DateTime(2024, 10, 18, 22, 21, 22, 151, DateTimeKind.Local).AddTicks(6362)
                        },
                        new
                        {
                            Id = 12,
                            CreatedDate = new DateTime(2024, 10, 18, 22, 21, 22, 151, DateTimeKind.Local).AddTicks(6363),
                            Description = "Lightweight tablet with 64GB storage and stylus support",
                            Name = "Tablet",
                            PhotoUrl = "/Images/Items/tablet.jpg",
                            Price = 399.99m,
                            Quantity = 40,
                            UpdatedDate = new DateTime(2024, 10, 18, 22, 21, 22, 151, DateTimeKind.Local).AddTicks(6364)
                        },
                        new
                        {
                            Id = 13,
                            CreatedDate = new DateTime(2024, 10, 18, 22, 21, 22, 151, DateTimeKind.Local).AddTicks(6365),
                            Description = "Portable Bluetooth speaker with deep bass",
                            Name = "Bluetooth Speaker",
                            PhotoUrl = "/Images/Items/bluetooth_speaker.jpg",
                            Price = 79.99m,
                            Quantity = 80,
                            UpdatedDate = new DateTime(2024, 10, 18, 22, 21, 22, 151, DateTimeKind.Local).AddTicks(6365)
                        },
                        new
                        {
                            Id = 14,
                            CreatedDate = new DateTime(2024, 10, 18, 22, 21, 22, 151, DateTimeKind.Local).AddTicks(6367),
                            Description = "Ergonomic gaming mouse with customizable buttons",
                            Name = "Gaming Mouse",
                            PhotoUrl = "/Images/Items/gaming_mouse.jpg",
                            Price = 59.99m,
                            Quantity = 60,
                            UpdatedDate = new DateTime(2024, 10, 18, 22, 21, 22, 151, DateTimeKind.Local).AddTicks(6367)
                        },
                        new
                        {
                            Id = 15,
                            CreatedDate = new DateTime(2024, 10, 18, 22, 21, 22, 151, DateTimeKind.Local).AddTicks(6369),
                            Description = "1TB external hard drive for data backup",
                            Name = "External Hard Drive",
                            PhotoUrl = "/Images/Items/external_hard_drive.jpg",
                            Price = 89.99m,
                            Quantity = 25,
                            UpdatedDate = new DateTime(2024, 10, 18, 22, 21, 22, 151, DateTimeKind.Local).AddTicks(6369)
                        },
                        new
                        {
                            Id = 16,
                            CreatedDate = new DateTime(2024, 10, 18, 22, 21, 22, 151, DateTimeKind.Local).AddTicks(6371),
                            Description = "Wearable fitness tracker with sleep monitoring",
                            Name = "Fitness Tracker",
                            PhotoUrl = "/Images/Items/fitness_tracker.jpg",
                            Price = 49.99m,
                            Quantity = 90,
                            UpdatedDate = new DateTime(2024, 10, 18, 22, 21, 22, 151, DateTimeKind.Local).AddTicks(6371)
                        },
                        new
                        {
                            Id = 17,
                            CreatedDate = new DateTime(2024, 10, 18, 22, 21, 22, 151, DateTimeKind.Local).AddTicks(6372),
                            Description = "Slim wireless keyboard with quiet keys and long battery life",
                            Name = "Wireless Keyboard",
                            PhotoUrl = "/Images/Items/wireless_keyboard.jpg",
                            Price = 39.99m,
                            Quantity = 100,
                            UpdatedDate = new DateTime(2024, 10, 18, 22, 21, 22, 151, DateTimeKind.Local).AddTicks(6373)
                        },
                        new
                        {
                            Id = 18,
                            CreatedDate = new DateTime(2024, 10, 18, 22, 21, 22, 151, DateTimeKind.Local).AddTicks(6374),
                            Description = "55-inch 4K Ultra HD Smart TV with HDR",
                            Name = "4K TV",
                            PhotoUrl = "/Images/Items/4k_tv.jpg",
                            Price = 799.99m,
                            Quantity = 15,
                            UpdatedDate = new DateTime(2024, 10, 18, 22, 21, 22, 151, DateTimeKind.Local).AddTicks(6375)
                        },
                        new
                        {
                            Id = 19,
                            CreatedDate = new DateTime(2024, 10, 18, 22, 21, 22, 151, DateTimeKind.Local).AddTicks(6376),
                            Description = "Quadcopter drone with 4K camera and GPS",
                            Name = "Drone",
                            PhotoUrl = "/Images/Items/drone.jpg",
                            Price = 499.99m,
                            Quantity = 10,
                            UpdatedDate = new DateTime(2024, 10, 18, 22, 21, 22, 151, DateTimeKind.Local).AddTicks(6377)
                        },
                        new
                        {
                            Id = 20,
                            CreatedDate = new DateTime(2024, 10, 18, 22, 21, 22, 151, DateTimeKind.Local).AddTicks(6378),
                            Description = "Foldable electric scooter with a top speed of 25 km/h",
                            Name = "Electric Scooter",
                            PhotoUrl = "/Images/Items/electric_scooter.jpg",
                            Price = 349.99m,
                            Quantity = 20,
                            UpdatedDate = new DateTime(2024, 10, 18, 22, 21, 22, 151, DateTimeKind.Local).AddTicks(6379)
                        },
                        new
                        {
                            Id = 21,
                            CreatedDate = new DateTime(2024, 10, 18, 22, 21, 22, 151, DateTimeKind.Local).AddTicks(6380),
                            Description = "Indoor/outdoor security camera with motion detection and night vision",
                            Name = "Home Security Camera",
                            PhotoUrl = "/Images/Items/home_security_camera.jpg",
                            Price = 99.99m,
                            Quantity = 50,
                            UpdatedDate = new DateTime(2024, 10, 18, 22, 21, 22, 151, DateTimeKind.Local).AddTicks(6380)
                        });
                });

            modelBuilder.Entity("OnlineShop_api.Models.LocalUser", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Password")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Role")
                        .HasColumnType("int");

                    b.Property<string>("UserName")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("LocalUsers");
                });
#pragma warning restore 612, 618
        }
    }
}
