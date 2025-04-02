using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SacramentMeetingPlanner.Migrations
{
    /// <inheritdoc />
    public partial class AddSpeakerToSacramentMeeting : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "SacramentMeetings",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    MeetingDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ConductingLeader = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    OpeningSong = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    SacramentHymn = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ClosingSong = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    OpeningPrayer = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ClosingPrayer = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Speaker = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SacramentMeetings", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Speakers",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Topic = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SacramentMeetingId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Speakers", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Speakers_SacramentMeetings_SacramentMeetingId",
                        column: x => x.SacramentMeetingId,
                        principalTable: "SacramentMeetings",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Speakers_SacramentMeetingId",
                table: "Speakers",
                column: "SacramentMeetingId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Speakers");

            migrationBuilder.DropTable(
                name: "SacramentMeetings");
        }
    }
}
