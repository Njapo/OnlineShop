using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace OnlineShop_api.Migrations
{
    /// <inheritdoc />
    public partial class SeedMoreItemData : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 10, 18, 22, 21, 22, 151, DateTimeKind.Local).AddTicks(6342), new DateTime(2024, 10, 18, 22, 21, 22, 151, DateTimeKind.Local).AddTicks(6352) });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 10, 18, 22, 21, 22, 151, DateTimeKind.Local).AddTicks(6355), new DateTime(2024, 10, 18, 22, 21, 22, 151, DateTimeKind.Local).AddTicks(6355) });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 10, 18, 22, 21, 22, 151, DateTimeKind.Local).AddTicks(6357), new DateTime(2024, 10, 18, 22, 21, 22, 151, DateTimeKind.Local).AddTicks(6358) });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 10, 18, 22, 21, 22, 151, DateTimeKind.Local).AddTicks(6359), new DateTime(2024, 10, 18, 22, 21, 22, 151, DateTimeKind.Local).AddTicks(6360) });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 10, 18, 22, 21, 22, 151, DateTimeKind.Local).AddTicks(6361), new DateTime(2024, 10, 18, 22, 21, 22, 151, DateTimeKind.Local).AddTicks(6362) });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 10, 18, 22, 21, 22, 151, DateTimeKind.Local).AddTicks(6363), new DateTime(2024, 10, 18, 22, 21, 22, 151, DateTimeKind.Local).AddTicks(6364) });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 10, 18, 22, 21, 22, 151, DateTimeKind.Local).AddTicks(6365), new DateTime(2024, 10, 18, 22, 21, 22, 151, DateTimeKind.Local).AddTicks(6365) });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 10, 18, 22, 21, 22, 151, DateTimeKind.Local).AddTicks(6367), new DateTime(2024, 10, 18, 22, 21, 22, 151, DateTimeKind.Local).AddTicks(6367) });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 10, 18, 22, 21, 22, 151, DateTimeKind.Local).AddTicks(6369), new DateTime(2024, 10, 18, 22, 21, 22, 151, DateTimeKind.Local).AddTicks(6369) });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 10, 18, 22, 21, 22, 151, DateTimeKind.Local).AddTicks(6371), new DateTime(2024, 10, 18, 22, 21, 22, 151, DateTimeKind.Local).AddTicks(6371) });

            migrationBuilder.InsertData(
                table: "Items",
                columns: new[] { "Id", "CreatedDate", "Description", "Name", "PhotoUrl", "Price", "Quantity", "UpdatedDate" },
                values: new object[,]
                {
                    { 17, new DateTime(2024, 10, 18, 22, 21, 22, 151, DateTimeKind.Local).AddTicks(6372), "Slim wireless keyboard with quiet keys and long battery life", "Wireless Keyboard", "/Images/Items/wireless_keyboard.jpg", 39.99m, 100, new DateTime(2024, 10, 18, 22, 21, 22, 151, DateTimeKind.Local).AddTicks(6373) },
                    { 18, new DateTime(2024, 10, 18, 22, 21, 22, 151, DateTimeKind.Local).AddTicks(6374), "55-inch 4K Ultra HD Smart TV with HDR", "4K TV", "/Images/Items/4k_tv.jpg", 799.99m, 15, new DateTime(2024, 10, 18, 22, 21, 22, 151, DateTimeKind.Local).AddTicks(6375) },
                    { 19, new DateTime(2024, 10, 18, 22, 21, 22, 151, DateTimeKind.Local).AddTicks(6376), "Quadcopter drone with 4K camera and GPS", "Drone", "/Images/Items/drone.jpg", 499.99m, 10, new DateTime(2024, 10, 18, 22, 21, 22, 151, DateTimeKind.Local).AddTicks(6377) },
                    { 20, new DateTime(2024, 10, 18, 22, 21, 22, 151, DateTimeKind.Local).AddTicks(6378), "Foldable electric scooter with a top speed of 25 km/h", "Electric Scooter", "/Images/Items/electric_scooter.jpg", 349.99m, 20, new DateTime(2024, 10, 18, 22, 21, 22, 151, DateTimeKind.Local).AddTicks(6379) },
                    { 21, new DateTime(2024, 10, 18, 22, 21, 22, 151, DateTimeKind.Local).AddTicks(6380), "Indoor/outdoor security camera with motion detection and night vision", "Home Security Camera", "/Images/Items/home_security_camera.jpg", 99.99m, 50, new DateTime(2024, 10, 18, 22, 21, 22, 151, DateTimeKind.Local).AddTicks(6380) }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 17);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 18);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 19);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 20);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 21);

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 10, 17, 2, 59, 52, 333, DateTimeKind.Local).AddTicks(303), new DateTime(2024, 10, 17, 2, 59, 52, 333, DateTimeKind.Local).AddTicks(317) });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 10, 17, 2, 59, 52, 333, DateTimeKind.Local).AddTicks(319), new DateTime(2024, 10, 17, 2, 59, 52, 333, DateTimeKind.Local).AddTicks(320) });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 10, 17, 2, 59, 52, 333, DateTimeKind.Local).AddTicks(321), new DateTime(2024, 10, 17, 2, 59, 52, 333, DateTimeKind.Local).AddTicks(321) });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 10, 17, 2, 59, 52, 333, DateTimeKind.Local).AddTicks(323), new DateTime(2024, 10, 17, 2, 59, 52, 333, DateTimeKind.Local).AddTicks(323) });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 10, 17, 2, 59, 52, 333, DateTimeKind.Local).AddTicks(324), new DateTime(2024, 10, 17, 2, 59, 52, 333, DateTimeKind.Local).AddTicks(325) });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 10, 17, 2, 59, 52, 333, DateTimeKind.Local).AddTicks(326), new DateTime(2024, 10, 17, 2, 59, 52, 333, DateTimeKind.Local).AddTicks(327) });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 10, 17, 2, 59, 52, 333, DateTimeKind.Local).AddTicks(328), new DateTime(2024, 10, 17, 2, 59, 52, 333, DateTimeKind.Local).AddTicks(328) });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 10, 17, 2, 59, 52, 333, DateTimeKind.Local).AddTicks(330), new DateTime(2024, 10, 17, 2, 59, 52, 333, DateTimeKind.Local).AddTicks(330) });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 10, 17, 2, 59, 52, 333, DateTimeKind.Local).AddTicks(332), new DateTime(2024, 10, 17, 2, 59, 52, 333, DateTimeKind.Local).AddTicks(332) });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 10, 17, 2, 59, 52, 333, DateTimeKind.Local).AddTicks(333), new DateTime(2024, 10, 17, 2, 59, 52, 333, DateTimeKind.Local).AddTicks(334) });
        }
    }
}
