using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace OnlineShop_api.Migrations
{
    /// <inheritdoc />
    public partial class disableNullable : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "PhotoUrl",
                table: "Items",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "Description",
                table: "Items",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 10, 12, 22, 10, 44, 143, DateTimeKind.Local).AddTicks(5890), new DateTime(2024, 10, 12, 22, 10, 44, 143, DateTimeKind.Local).AddTicks(5900) });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 10, 12, 22, 10, 44, 143, DateTimeKind.Local).AddTicks(5902), new DateTime(2024, 10, 12, 22, 10, 44, 143, DateTimeKind.Local).AddTicks(5902) });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 10, 12, 22, 10, 44, 143, DateTimeKind.Local).AddTicks(5904), new DateTime(2024, 10, 12, 22, 10, 44, 143, DateTimeKind.Local).AddTicks(5904) });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 10, 12, 22, 10, 44, 143, DateTimeKind.Local).AddTicks(5906), new DateTime(2024, 10, 12, 22, 10, 44, 143, DateTimeKind.Local).AddTicks(5906) });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 10, 12, 22, 10, 44, 143, DateTimeKind.Local).AddTicks(5907), new DateTime(2024, 10, 12, 22, 10, 44, 143, DateTimeKind.Local).AddTicks(5908) });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "PhotoUrl",
                table: "Items",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Description",
                table: "Items",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

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
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 10, 12, 21, 19, 29, 473, DateTimeKind.Local).AddTicks(516), new DateTime(2024, 10, 12, 21, 19, 29, 473, DateTimeKind.Local).AddTicks(517) });
        }
    }
}
