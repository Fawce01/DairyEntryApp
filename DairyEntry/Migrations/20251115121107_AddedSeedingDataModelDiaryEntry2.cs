using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DairyEntry.Migrations
{
    /// <inheritdoc />
    public partial class AddedSeedingDataModelDiaryEntry2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
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
            migrationBuilder.UpdateData(
                table: "DiaryEntrys",
                keyColumn: "Id",
                keyValue: 1,
                column: "Created",
                value: new DateTime(2025, 11, 15, 12, 3, 43, 371, DateTimeKind.Local).AddTicks(823));

            migrationBuilder.UpdateData(
                table: "DiaryEntrys",
                keyColumn: "Id",
                keyValue: 2,
                column: "Created",
                value: new DateTime(2025, 11, 15, 12, 3, 43, 371, DateTimeKind.Local).AddTicks(1126));

            migrationBuilder.UpdateData(
                table: "DiaryEntrys",
                keyColumn: "Id",
                keyValue: 3,
                column: "Created",
                value: new DateTime(2025, 11, 15, 12, 3, 43, 371, DateTimeKind.Local).AddTicks(1129));
        }
    }
}
