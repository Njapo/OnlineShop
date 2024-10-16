using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace OnlineShop_api.Migrations
{
    /// <inheritdoc />
    public partial class addUserLocalTable : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
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

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "LocalUsers");

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
    }
}
