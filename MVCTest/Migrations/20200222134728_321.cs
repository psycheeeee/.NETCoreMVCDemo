using Microsoft.EntityFrameworkCore.Migrations;

namespace MVCTest.Migrations
{
    public partial class _321 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "StudentModels",
                columns: new[] { "id", "ClassName", "Email", "Name" },
                values: new object[] { 3, 0, "psyche123@syinpo.com", "psycheeeee123" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "StudentModels",
                keyColumn: "id",
                keyValue: 3);
        }
    }
}
