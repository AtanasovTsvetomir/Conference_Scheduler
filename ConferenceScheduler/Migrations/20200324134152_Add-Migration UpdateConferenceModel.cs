using Microsoft.EntityFrameworkCore.Migrations;

namespace ConferenceScheduler.Migrations
{
    public partial class AddMigrationUpdateConferenceModel : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "HallId",
                table: "Conferences",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Conferences_HallId",
                table: "Conferences",
                column: "HallId");

            migrationBuilder.AddForeignKey(
                name: "FK_Conferences_Halls_HallId",
                table: "Conferences",
                column: "HallId",
                principalTable: "Halls",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Conferences_Halls_HallId",
                table: "Conferences");

            migrationBuilder.DropIndex(
                name: "IX_Conferences_HallId",
                table: "Conferences");

            migrationBuilder.DropColumn(
                name: "HallId",
                table: "Conferences");
        }
    }
}
