using Microsoft.EntityFrameworkCore.Migrations;

namespace ConferenceScheduler.Migrations
{
    public partial class AddingVenue : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Venues",
                columns: new[] { "Id", "Address", "Name" },
                values: new object[] { 1, "Sofia", "Inter Expo Center" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Venues",
                keyColumn: "Id",
                keyValue: 1);
        }
    }
}
