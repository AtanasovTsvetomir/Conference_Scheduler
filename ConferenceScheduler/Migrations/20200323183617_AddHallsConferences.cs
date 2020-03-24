using Microsoft.EntityFrameworkCore.Migrations;

namespace ConferenceScheduler.Migrations
{
    public partial class AddHallsConferences : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Halls_Conferences_ConferenceId",
                table: "Halls");

            migrationBuilder.DropIndex(
                name: "IX_Halls_ConferenceId",
                table: "Halls");

            migrationBuilder.DropColumn(
                name: "ConferenceId",
                table: "Halls");

            migrationBuilder.CreateTable(
                name: "HallsConferences",
                columns: table => new
                {
                    ConferenceId = table.Column<int>(nullable: false),
                    HallId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_HallsConferences", x => new { x.HallId, x.ConferenceId });
                    table.ForeignKey(
                        name: "FK_HallsConferences_Conferences_ConferenceId",
                        column: x => x.ConferenceId,
                        principalTable: "Conferences",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_HallsConferences_Halls_HallId",
                        column: x => x.HallId,
                        principalTable: "Halls",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_HallsConferences_ConferenceId",
                table: "HallsConferences",
                column: "ConferenceId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "HallsConferences");

            migrationBuilder.AddColumn<int>(
                name: "ConferenceId",
                table: "Halls",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Halls_ConferenceId",
                table: "Halls",
                column: "ConferenceId");

            migrationBuilder.AddForeignKey(
                name: "FK_Halls_Conferences_ConferenceId",
                table: "Halls",
                column: "ConferenceId",
                principalTable: "Conferences",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
