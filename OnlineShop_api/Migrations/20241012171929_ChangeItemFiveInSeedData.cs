using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace OnlineShop_api.Migrations
{
    /// <inheritdoc />
    public partial class ChangeItemFiveInSeedData : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 10, 12, 21, 19, 29, 473, DateTimeKind.Local).AddTicks(498), new DateTime(2024, 10, 12, 21, 19, 29, 473, DateTimeKind.Local).AddTicks(508) });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 10, 12, 21, 19, 29, 473, DateTimeKind.Local).AddTicks(510), new DateTime(2024, 10, 12, 21, 19, 29, 473, DateTimeKind.Local).AddTicks(510) });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 10, 12, 21, 19, 29, 473, DateTimeKind.Local).AddTicks(512), new DateTime(2024, 10, 12, 21, 19, 29, 473, DateTimeKind.Local).AddTicks(513) });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 10, 12, 21, 19, 29, 473, DateTimeKind.Local).AddTicks(514), new DateTime(2024, 10, 12, 21, 19, 29, 473, DateTimeKind.Local).AddTicks(515) });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedDate", "PhotoUrl", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 10, 12, 21, 19, 29, 473, DateTimeKind.Local).AddTicks(516), "/Images/Items/camera.jpeg", new DateTime(2024, 10, 12, 21, 19, 29, 473, DateTimeKind.Local).AddTicks(517) });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 10, 9, 1, 50, 45, 861, DateTimeKind.Local).AddTicks(9572), new DateTime(2024, 10, 9, 1, 50, 45, 861, DateTimeKind.Local).AddTicks(9583) });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 10, 9, 1, 50, 45, 861, DateTimeKind.Local).AddTicks(9585), new DateTime(2024, 10, 9, 1, 50, 45, 861, DateTimeKind.Local).AddTicks(9586) });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 10, 9, 1, 50, 45, 861, DateTimeKind.Local).AddTicks(9587), new DateTime(2024, 10, 9, 1, 50, 45, 861, DateTimeKind.Local).AddTicks(9588) });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 10, 9, 1, 50, 45, 861, DateTimeKind.Local).AddTicks(9589), new DateTime(2024, 10, 9, 1, 50, 45, 861, DateTimeKind.Local).AddTicks(9590) });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedDate", "PhotoUrl", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 10, 9, 1, 50, 45, 861, DateTimeKind.Local).AddTicks(9592), "/Images/Items/camera.jpg", new DateTime(2024, 10, 9, 1, 50, 45, 861, DateTimeKind.Local).AddTicks(9592) });
        }
    }
}
