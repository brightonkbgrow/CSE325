using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MegaDeskRazorPages.Migrations
{
    /// <inheritdoc />
    public partial class InitialCreate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Quotes",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CustomerName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DeskWidth = table.Column<int>(type: "int", nullable: false),
                    DeskDepth = table.Column<int>(type: "int", nullable: false),
                    DeskMaterial = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    NumDrawers = table.Column<int>(type: "int", nullable: false),
                    RushOrderDays = table.Column<int>(type: "int", nullable: false),
                    QuoteTotal = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    QuoteDate = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Quotes", x => x.Id);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Quotes");
        }
    }
}
