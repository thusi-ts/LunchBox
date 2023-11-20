using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace LunchBox.Shared.Migrations
{
    /// <inheritdoc />
    public partial class migrationOn1611231 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedTime", "LastModifiedTime" },
                values: new object[] { new DateTime(2023, 11, 16, 22, 43, 56, 118, DateTimeKind.Local).AddTicks(2431), new DateTime(2023, 11, 16, 22, 43, 56, 118, DateTimeKind.Local).AddTicks(2436) });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedTime", "LastModifiedTime" },
                values: new object[] { new DateTime(2023, 11, 16, 14, 41, 15, 894, DateTimeKind.Local).AddTicks(7459), new DateTime(2023, 11, 16, 14, 41, 15, 894, DateTimeKind.Local).AddTicks(7463) });
        }
    }
}
