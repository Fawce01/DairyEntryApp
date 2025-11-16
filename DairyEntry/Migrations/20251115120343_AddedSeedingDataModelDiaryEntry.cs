using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace DairyEntry.Migrations
{
    /// <inheritdoc />
    public partial class AddedSeedingDataModelDiaryEntry : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "DiaryEntrys",
                columns: new[] { "Id", "Content", "Created", "Title" },
                values: new object[,]
                {
                    { 1, "Went hiking with Joe", new DateTime(2025, 11, 15, 12, 3, 43, 371, DateTimeKind.Local).AddTicks(823), "Went Hiking" },
                    { 2, "Went shopping with Joe", new DateTime(2025, 11, 15, 12, 3, 43, 371, DateTimeKind.Local).AddTicks(1126), "Went Shopping" },
                    { 3, "Went diving with Joe", new DateTime(2025, 11, 15, 12, 3, 43, 371, DateTimeKind.Local).AddTicks(1129), "Went Diving" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "DiaryEntrys",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "DiaryEntrys",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "DiaryEntrys",
                keyColumn: "Id",
                keyValue: 3);
        }
    }
}
