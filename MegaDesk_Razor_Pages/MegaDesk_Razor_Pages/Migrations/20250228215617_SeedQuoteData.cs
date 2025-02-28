using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace MegaDeskRazorPages.Migrations
{
    /// <inheritdoc />
    public partial class SeedQuoteData : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Quotes",
                columns: new[] { "Id", "CustomerName", "DeskDepth", "DeskMaterial", "DeskWidth", "NumDrawers", "QuoteDate", "QuoteTotal", "RushOrderDays" },
                values: new object[,]
                {
                    { 1, "John Doe", 30, "Oak", 60, 2, new DateTime(2025, 2, 28, 14, 56, 16, 984, DateTimeKind.Local).AddTicks(2050), 1200m, 3 },
                    { 2, "Jane Smith", 36, "Laminate", 72, 4, new DateTime(2025, 2, 28, 14, 56, 16, 984, DateTimeKind.Local).AddTicks(2055), 1500m, 5 },
                    { 3, "Alice Johnson", 24, "Pine", 48, 3, new DateTime(2025, 2, 27, 14, 56, 16, 984, DateTimeKind.Local).AddTicks(2058), 1100m, 7 },
                    { 4, "Bob Brown", 30, "Veneer", 60, 2, new DateTime(2025, 2, 26, 14, 56, 16, 984, DateTimeKind.Local).AddTicks(2063), 1000m, 0 }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 4);
        }
    }
}
