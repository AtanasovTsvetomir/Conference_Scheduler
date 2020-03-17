using Microsoft.EntityFrameworkCore.Migrations;

namespace ConferenceScheduler.Migrations
{
    public partial class AddingVenues10 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Venues",
                columns: new[] { "Id", "Address", "Name" },
                values: new object[] { 2, "Sofia", "Sofia Center" });

            migrationBuilder.InsertData(
                table: "Venues",
                columns: new[] { "Id", "Address", "Name" },
                values: new object[] { 3, "Rousse", "Caneff Center" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Venues",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Venues",
                keyColumn: "Id",
                keyValue: 3);
        }
    }
}
