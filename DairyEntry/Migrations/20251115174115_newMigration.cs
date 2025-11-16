using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DairyEntry.Migrations
{
    /// <inheritdoc />
    public partial class newMigration : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "Title",
                table: "DiaryEntrys",
                type: "nvarchar(100)",
                maxLength: 100,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.UpdateData(
                table: "DiaryEntrys",
                keyColumn: "Id",
                keyValue: 1,
                column: "Created",
                value: new DateTime(2025, 11, 15, 12, 9, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "DiaryEntrys",
                keyColumn: "Id",
                keyValue: 2,
                column: "Created",
                value: new DateTime(2025, 11, 15, 12, 9, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "DiaryEntrys",
                keyColumn: "Id",
                keyValue: 3,
                column: "Created",
                value: new DateTime(2025, 11, 15, 12, 9, 0, 0, DateTimeKind.Unspecified));
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "Title",
                table: "DiaryEntrys",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(100)",
                oldMaxLength: 100);

            migrationBuilder.UpdateData(
                table: "DiaryEntrys",
                keyColumn: "Id",
                keyValue: 1,
                column: "Created",
                value: new DateTime(2025, 11, 15, 12, 32, 0, 751, DateTimeKind.Local).AddTicks(1133));

            migrationBuilder.UpdateData(
                table: "DiaryEntrys",
                keyColumn: "Id",
                keyValue: 2,
                column: "Created",
                value: new DateTime(2025, 11, 15, 12, 32, 0, 751, DateTimeKind.Local).AddTicks(1133));

            migrationBuilder.UpdateData(
                table: "DiaryEntrys",
                keyColumn: "Id",
                keyValue: 3,
                column: "Created",
                value: new DateTime(2025, 11, 15, 12, 32, 0, 751, DateTimeKind.Local).AddTicks(1133));
        }
    }
}
