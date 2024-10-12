﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using OnlineShop_api.Data;

#nullable disable

namespace OnlineShop_api.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    partial class ApplicationDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
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
                            CreatedDate = new DateTime(2024, 10, 12, 22, 10, 44, 143, DateTimeKind.Local).AddTicks(5890),
                            Description = "Latest smartphone with 128GB storage",
                            Name = "Smartphone",
                            PhotoUrl = "/Images/Items/smartphone.jpg",
                            Price = 599.99m,
                            Quantity = 50,
                            UpdatedDate = new DateTime(2024, 10, 12, 22, 10, 44, 143, DateTimeKind.Local).AddTicks(5900)
                        },
                        new
                        {
                            Id = 2,
                            CreatedDate = new DateTime(2024, 10, 12, 22, 10, 44, 143, DateTimeKind.Local).AddTicks(5902),
                            Description = "High-performance laptop for gaming and work",
                            Name = "Laptop",
                            PhotoUrl = "/Images/Items/laptop.jpg",
                            Price = 1299.99m,
                            Quantity = 30,
                            UpdatedDate = new DateTime(2024, 10, 12, 22, 10, 44, 143, DateTimeKind.Local).AddTicks(5902)
                        },
                        new
                        {
                            Id = 3,
                            CreatedDate = new DateTime(2024, 10, 12, 22, 10, 44, 143, DateTimeKind.Local).AddTicks(5904),
                            Description = "Noise-cancelling over-ear headphones",
                            Name = "Headphones",
                            PhotoUrl = "/Images/Items/headphones.jpeg",
                            Price = 199.99m,
                            Quantity = 100,
                            UpdatedDate = new DateTime(2024, 10, 12, 22, 10, 44, 143, DateTimeKind.Local).AddTicks(5904)
                        },
                        new
                        {
                            Id = 4,
                            CreatedDate = new DateTime(2024, 10, 12, 22, 10, 44, 143, DateTimeKind.Local).AddTicks(5906),
                            Description = "Waterproof smartwatch with heart rate monitor",
                            Name = "Smartwatch",
                            PhotoUrl = "/Images/Items/smartwatch.jpg",
                            Price = 149.99m,
                            Quantity = 75,
                            UpdatedDate = new DateTime(2024, 10, 12, 22, 10, 44, 143, DateTimeKind.Local).AddTicks(5906)
                        },
                        new
                        {
                            Id = 5,
                            CreatedDate = new DateTime(2024, 10, 12, 22, 10, 44, 143, DateTimeKind.Local).AddTicks(5907),
                            Description = "Digital SLR camera with 24.2 MP sensor",
                            Name = "Camera",
                            PhotoUrl = "/Images/Items/camera.jpeg",
                            Price = 899.99m,
                            Quantity = 20,
                            UpdatedDate = new DateTime(2024, 10, 12, 22, 10, 44, 143, DateTimeKind.Local).AddTicks(5908)
                        });
                });
#pragma warning restore 612, 618
        }
    }
}
