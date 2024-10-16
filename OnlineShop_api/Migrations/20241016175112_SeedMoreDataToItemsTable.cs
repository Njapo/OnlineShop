using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace OnlineShop_api.Migrations
{
    /// <inheritdoc />
    public partial class SeedMoreDataToItemsTable : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 10, 16, 21, 51, 11, 966, DateTimeKind.Local).AddTicks(3103), new DateTime(2024, 10, 16, 21, 51, 11, 966, DateTimeKind.Local).AddTicks(3117) });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 10, 16, 21, 51, 11, 966, DateTimeKind.Local).AddTicks(3119), new DateTime(2024, 10, 16, 21, 51, 11, 966, DateTimeKind.Local).AddTicks(3120) });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 10, 16, 21, 51, 11, 966, DateTimeKind.Local).AddTicks(3122), new DateTime(2024, 10, 16, 21, 51, 11, 966, DateTimeKind.Local).AddTicks(3122) });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 10, 16, 21, 51, 11, 966, DateTimeKind.Local).AddTicks(3123), new DateTime(2024, 10, 16, 21, 51, 11, 966, DateTimeKind.Local).AddTicks(3124) });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 10, 16, 21, 51, 11, 966, DateTimeKind.Local).AddTicks(3125), new DateTime(2024, 10, 16, 21, 51, 11, 966, DateTimeKind.Local).AddTicks(3126) });

            migrationBuilder.InsertData(
                table: "Items",
                columns: new[] { "Id", "CreatedDate", "Description", "Name", "PhotoUrl", "Price", "Quantity", "UpdatedDate" },
                values: new object[,]
                {
                    { 12, new DateTime(2024, 10, 16, 21, 51, 11, 966, DateTimeKind.Local).AddTicks(3127), "Lightweight tablet with 64GB storage and stylus support", "Tablet", "/Images/Items/tablet.jpg", 399.99m, 40, new DateTime(2024, 10, 16, 21, 51, 11, 966, DateTimeKind.Local).AddTicks(3128) },
                    { 13, new DateTime(2024, 10, 16, 21, 51, 11, 966, DateTimeKind.Local).AddTicks(3129), "Portable Bluetooth speaker with deep bass", "Bluetooth Speaker", "/Images/Items/bluetooth_speaker.jpg", 79.99m, 80, new DateTime(2024, 10, 16, 21, 51, 11, 966, DateTimeKind.Local).AddTicks(3130) },
                    { 14, new DateTime(2024, 10, 16, 21, 51, 11, 966, DateTimeKind.Local).AddTicks(3131), "Ergonomic gaming mouse with customizable buttons", "Gaming Mouse", "/Images/Items/gaming_mouse.jpg", 59.99m, 60, new DateTime(2024, 10, 16, 21, 51, 11, 966, DateTimeKind.Local).AddTicks(3132) },
                    { 15, new DateTime(2024, 10, 16, 21, 51, 11, 966, DateTimeKind.Local).AddTicks(3133), "1TB external hard drive for data backup", "External Hard Drive", "/Images/Items/external_hard_drive.jpg", 89.99m, 25, new DateTime(2024, 10, 16, 21, 51, 11, 966, DateTimeKind.Local).AddTicks(3133) },
                    { 16, new DateTime(2024, 10, 16, 21, 51, 11, 966, DateTimeKind.Local).AddTicks(3135), "Wearable fitness tracker with sleep monitoring", "Fitness Tracker", "/Images/Items/fitness_tracker.jpg", 49.99m, 90, new DateTime(2024, 10, 16, 21, 51, 11, 966, DateTimeKind.Local).AddTicks(3135) }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 16);

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 10, 14, 0, 18, 3, 479, DateTimeKind.Local).AddTicks(3440), new DateTime(2024, 10, 14, 0, 18, 3, 479, DateTimeKind.Local).AddTicks(3450) });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 10, 14, 0, 18, 3, 479, DateTimeKind.Local).AddTicks(3452), new DateTime(2024, 10, 14, 0, 18, 3, 479, DateTimeKind.Local).AddTicks(3453) });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 10, 14, 0, 18, 3, 479, DateTimeKind.Local).AddTicks(3455), new DateTime(2024, 10, 14, 0, 18, 3, 479, DateTimeKind.Local).AddTicks(3455) });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 10, 14, 0, 18, 3, 479, DateTimeKind.Local).AddTicks(3457), new DateTime(2024, 10, 14, 0, 18, 3, 479, DateTimeKind.Local).AddTicks(3457) });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 10, 14, 0, 18, 3, 479, DateTimeKind.Local).AddTicks(3459), new DateTime(2024, 10, 14, 0, 18, 3, 479, DateTimeKind.Local).AddTicks(3459) });
        }
    }
}
