using Microsoft.EntityFrameworkCore.Migrations;

namespace ConferenceScheduler.Migrations
{
    public partial class UpdateHalls : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Halls",
                columns: new[] { "Id", "Capacity", "ConferenceId", "Name", "VenueId" },
                values: new object[,]
                {
                    { 1, 50, null, "First hall", 1 },
                    { 2, 50, null, "Second hall", 1 },
                    { 3, 50, null, "First hall", 2 },
                    { 4, 50, null, "Second hall", 2 },
                    { 5, 50, null, "First hall", 3 },
                    { 6, 50, null, "Second hall", 3 }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Halls",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Halls",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Halls",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Halls",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Halls",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Halls",
                keyColumn: "Id",
                keyValue: 6);
        }
    }
}
