using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace LunchBox.Shared.Migrations
{
    /// <inheritdoc />
    public partial class migrationOn161123 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<decimal>(
                name: "TotalPrice",
                table: "OrderExtraItems",
                type: "decimal(5,2)",
                nullable: false,
                oldClrType: typeof(decimal),
                oldType: "decimal(18,2)");

            migrationBuilder.AlterColumn<decimal>(
                name: "ProductExtraitemPrice",
                table: "OrderExtraItems",
                type: "decimal(5,2)",
                nullable: false,
                oldClrType: typeof(decimal),
                oldType: "decimal(18,2)");

            migrationBuilder.AlterColumn<decimal>(
                name: "Price",
                table: "OrderExtraItems",
                type: "decimal(5,2)",
                nullable: false,
                oldClrType: typeof(decimal),
                oldType: "decimal(18,2)");

            migrationBuilder.AlterColumn<decimal>(
                name: "Discount",
                table: "OrderExtraItems",
                type: "decimal(5,2)",
                nullable: false,
                oldClrType: typeof(decimal),
                oldType: "decimal(18,2)");

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedTime", "LastModifiedTime", "Role" },
                values: new object[] { new DateTime(2023, 11, 16, 14, 41, 15, 894, DateTimeKind.Local).AddTicks(7459), new DateTime(2023, 11, 16, 14, 41, 15, 894, DateTimeKind.Local).AddTicks(7463), "Super admin" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<decimal>(
                name: "TotalPrice",
                table: "OrderExtraItems",
                type: "decimal(18,2)",
                nullable: false,
                oldClrType: typeof(decimal),
                oldType: "decimal(5,2)");

            migrationBuilder.AlterColumn<decimal>(
                name: "ProductExtraitemPrice",
                table: "OrderExtraItems",
                type: "decimal(18,2)",
                nullable: false,
                oldClrType: typeof(decimal),
                oldType: "decimal(5,2)");

            migrationBuilder.AlterColumn<decimal>(
                name: "Price",
                table: "OrderExtraItems",
                type: "decimal(18,2)",
                nullable: false,
                oldClrType: typeof(decimal),
                oldType: "decimal(5,2)");

            migrationBuilder.AlterColumn<decimal>(
                name: "Discount",
                table: "OrderExtraItems",
                type: "decimal(18,2)",
                nullable: false,
                oldClrType: typeof(decimal),
                oldType: "decimal(5,2)");

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedTime", "LastModifiedTime", "Role" },
                values: new object[] { new DateTime(2022, 1, 5, 13, 27, 46, 235, DateTimeKind.Local).AddTicks(7882), new DateTime(2022, 1, 5, 13, 27, 46, 235, DateTimeKind.Local).AddTicks(8899), "Has authority of users and roles and permissions." });
        }
    }
}
