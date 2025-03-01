using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MegaDeskRazorPages.Migrations
{
    /// <inheritdoc />
    public partial class UpdateSeedData : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 1,
                column: "QuoteDate",
                value: new DateTime(2025, 3, 1, 14, 57, 28, 51, DateTimeKind.Local).AddTicks(4534));

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 2,
                column: "QuoteDate",
                value: new DateTime(2025, 3, 1, 14, 57, 28, 51, DateTimeKind.Local).AddTicks(4539));

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 3,
                column: "QuoteDate",
                value: new DateTime(2025, 2, 28, 14, 57, 28, 51, DateTimeKind.Local).AddTicks(4542));

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 4,
                column: "QuoteDate",
                value: new DateTime(2025, 2, 27, 14, 57, 28, 51, DateTimeKind.Local).AddTicks(4547));
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 1,
                column: "QuoteDate",
                value: new DateTime(2025, 2, 28, 14, 56, 16, 984, DateTimeKind.Local).AddTicks(2050));

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 2,
                column: "QuoteDate",
                value: new DateTime(2025, 2, 28, 14, 56, 16, 984, DateTimeKind.Local).AddTicks(2055));

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 3,
                column: "QuoteDate",
                value: new DateTime(2025, 2, 27, 14, 56, 16, 984, DateTimeKind.Local).AddTicks(2058));

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 4,
                column: "QuoteDate",
                value: new DateTime(2025, 2, 26, 14, 56, 16, 984, DateTimeKind.Local).AddTicks(2063));
        }
    }
}
