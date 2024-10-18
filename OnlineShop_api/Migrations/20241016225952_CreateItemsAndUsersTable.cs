using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace OnlineShop_api.Migrations
{
    /// <inheritdoc />
    public partial class CreateItemsAndUsersTable : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Items",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Price = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    Quantity = table.Column<int>(type: "int", nullable: false),
                    PhotoUrl = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedDate = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Items", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "LocalUsers",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Password = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Role = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_LocalUsers", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "Items",
                columns: new[] { "Id", "CreatedDate", "Description", "Name", "PhotoUrl", "Price", "Quantity", "UpdatedDate" },
                values: new object[,]
                {
                    { 1, new DateTime(2024, 10, 17, 2, 59, 52, 333, DateTimeKind.Local).AddTicks(303), "Latest smartphone with 128GB storage", "Smartphone", "/Images/Items/smartphone.jpg", 599.99m, 50, new DateTime(2024, 10, 17, 2, 59, 52, 333, DateTimeKind.Local).AddTicks(317) },
                    { 2, new DateTime(2024, 10, 17, 2, 59, 52, 333, DateTimeKind.Local).AddTicks(319), "High-performance laptop for gaming and work", "Laptop", "/Images/Items/laptop.jpg", 1299.99m, 30, new DateTime(2024, 10, 17, 2, 59, 52, 333, DateTimeKind.Local).AddTicks(320) },
                    { 3, new DateTime(2024, 10, 17, 2, 59, 52, 333, DateTimeKind.Local).AddTicks(321), "Noise-cancelling over-ear headphones", "Headphones", "/Images/Items/headphones.jpeg", 199.99m, 100, new DateTime(2024, 10, 17, 2, 59, 52, 333, DateTimeKind.Local).AddTicks(321) },
                    { 4, new DateTime(2024, 10, 17, 2, 59, 52, 333, DateTimeKind.Local).AddTicks(323), "Waterproof smartwatch with heart rate monitor", "Smartwatch", "/Images/Items/smartwatch.jpg", 149.99m, 75, new DateTime(2024, 10, 17, 2, 59, 52, 333, DateTimeKind.Local).AddTicks(323) },
                    { 5, new DateTime(2024, 10, 17, 2, 59, 52, 333, DateTimeKind.Local).AddTicks(324), "Digital SLR camera with 24.2 MP sensor", "Camera", "/Images/Items/camera.jpeg", 899.99m, 20, new DateTime(2024, 10, 17, 2, 59, 52, 333, DateTimeKind.Local).AddTicks(325) },
                    { 12, new DateTime(2024, 10, 17, 2, 59, 52, 333, DateTimeKind.Local).AddTicks(326), "Lightweight tablet with 64GB storage and stylus support", "Tablet", "/Images/Items/tablet.jpg", 399.99m, 40, new DateTime(2024, 10, 17, 2, 59, 52, 333, DateTimeKind.Local).AddTicks(327) },
                    { 13, new DateTime(2024, 10, 17, 2, 59, 52, 333, DateTimeKind.Local).AddTicks(328), "Portable Bluetooth speaker with deep bass", "Bluetooth Speaker", "/Images/Items/bluetooth_speaker.jpg", 79.99m, 80, new DateTime(2024, 10, 17, 2, 59, 52, 333, DateTimeKind.Local).AddTicks(328) },
                    { 14, new DateTime(2024, 10, 17, 2, 59, 52, 333, DateTimeKind.Local).AddTicks(330), "Ergonomic gaming mouse with customizable buttons", "Gaming Mouse", "/Images/Items/gaming_mouse.jpg", 59.99m, 60, new DateTime(2024, 10, 17, 2, 59, 52, 333, DateTimeKind.Local).AddTicks(330) },
                    { 15, new DateTime(2024, 10, 17, 2, 59, 52, 333, DateTimeKind.Local).AddTicks(332), "1TB external hard drive for data backup", "External Hard Drive", "/Images/Items/external_hard_drive.jpg", 89.99m, 25, new DateTime(2024, 10, 17, 2, 59, 52, 333, DateTimeKind.Local).AddTicks(332) },
                    { 16, new DateTime(2024, 10, 17, 2, 59, 52, 333, DateTimeKind.Local).AddTicks(333), "Wearable fitness tracker with sleep monitoring", "Fitness Tracker", "/Images/Items/fitness_tracker.jpg", 49.99m, 90, new DateTime(2024, 10, 17, 2, 59, 52, 333, DateTimeKind.Local).AddTicks(334) }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Items");

            migrationBuilder.DropTable(
                name: "LocalUsers");
        }
    }
}
