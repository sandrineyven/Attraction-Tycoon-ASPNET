using Microsoft.EntityFrameworkCore.Migrations;

namespace Attraction_Tycoon_ASPNET.Migrations
{
    public partial class mylastmigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "zoneName",
                table: "Shop",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "zoneName",
                table: "Carousel",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "zoneName",
                table: "Shop");

            migrationBuilder.DropColumn(
                name: "zoneName",
                table: "Carousel");
        }
    }
}
