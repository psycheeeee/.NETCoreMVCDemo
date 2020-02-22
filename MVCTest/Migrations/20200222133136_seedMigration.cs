using Microsoft.EntityFrameworkCore.Migrations;

namespace MVCTest.Migrations
{
    public partial class seedMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "StudentModels",
                columns: new[] { "id", "ClassName", "Email", "Name" },
                values: new object[] { 1, 0, "admin@syinpo.com", "admin" });

            migrationBuilder.InsertData(
                table: "StudentModels",
                columns: new[] { "id", "ClassName", "Email", "Name" },
                values: new object[] { 2, 0, "psyche@syinpo.com", "psycheeeee" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "StudentModels",
                keyColumn: "id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "StudentModels",
                keyColumn: "id",
                keyValue: 2);
        }
    }
}
