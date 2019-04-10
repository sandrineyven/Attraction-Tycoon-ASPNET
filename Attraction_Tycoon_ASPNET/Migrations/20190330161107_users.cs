using Microsoft.EntityFrameworkCore.Migrations;

namespace Attraction_Tycoon_ASPNET.Migrations
{
    public partial class users : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "email",
                table: "User",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "password",
                table: "User",
                nullable: false,
                defaultValue: "");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "email",
                table: "User");

            migrationBuilder.DropColumn(
                name: "password",
                table: "User");
        }
    }
}
