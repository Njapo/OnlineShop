using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace OnlineShop_api.Migrations
{
    /// <inheritdoc />
    public partial class SeedItemTable : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Items",
                columns: new[] { "Id", "CreatedDate", "Description", "Name", "PhotoUrl", "Price", "Quantity", "UpdatedDate" },
                values: new object[,]
                {
                    { 1, new DateTime(2024, 10, 9, 1, 50, 45, 861, DateTimeKind.Local).AddTicks(9572), "Latest smartphone with 128GB storage", "Smartphone", "/Images/Items/smartphone.jpg", 599.99m, 50, new DateTime(2024, 10, 9, 1, 50, 45, 861, DateTimeKind.Local).AddTicks(9583) },
                    { 2, new DateTime(2024, 10, 9, 1, 50, 45, 861, DateTimeKind.Local).AddTicks(9585), "High-performance laptop for gaming and work", "Laptop", "/Images/Items/laptop.jpg", 1299.99m, 30, new DateTime(2024, 10, 9, 1, 50, 45, 861, DateTimeKind.Local).AddTicks(9586) },
                    { 3, new DateTime(2024, 10, 9, 1, 50, 45, 861, DateTimeKind.Local).AddTicks(9587), "Noise-cancelling over-ear headphones", "Headphones", "/Images/Items/headphones.jpeg", 199.99m, 100, new DateTime(2024, 10, 9, 1, 50, 45, 861, DateTimeKind.Local).AddTicks(9588) },
                    { 4, new DateTime(2024, 10, 9, 1, 50, 45, 861, DateTimeKind.Local).AddTicks(9589), "Waterproof smartwatch with heart rate monitor", "Smartwatch", "/Images/Items/smartwatch.jpg", 149.99m, 75, new DateTime(2024, 10, 9, 1, 50, 45, 861, DateTimeKind.Local).AddTicks(9590) },
                    { 5, new DateTime(2024, 10, 9, 1, 50, 45, 861, DateTimeKind.Local).AddTicks(9592), "Digital SLR camera with 24.2 MP sensor", "Camera", "/Images/Items/camera.jpg", 899.99m, 20, new DateTime(2024, 10, 9, 1, 50, 45, 861, DateTimeKind.Local).AddTicks(9592) }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 5);
        }
    }
}
