using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Attraction_Tycoon_ASPNET.Migrations
{
    public partial class MyMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "User");

            migrationBuilder.AddColumn<int>(
                name: "Searchid",
                table: "Staff",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "Searchid",
                table: "Shop",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "Searchid",
                table: "Carousel",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "Search",
                columns: table => new
                {
                    id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Search", x => x.id);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Staff_Searchid",
                table: "Staff",
                column: "Searchid");

            migrationBuilder.CreateIndex(
                name: "IX_Shop_Searchid",
                table: "Shop",
                column: "Searchid");

            migrationBuilder.CreateIndex(
                name: "IX_Carousel_Searchid",
                table: "Carousel",
                column: "Searchid");

            migrationBuilder.AddForeignKey(
                name: "FK_Carousel_Search_Searchid",
                table: "Carousel",
                column: "Searchid",
                principalTable: "Search",
                principalColumn: "id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Shop_Search_Searchid",
                table: "Shop",
                column: "Searchid",
                principalTable: "Search",
                principalColumn: "id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Staff_Search_Searchid",
                table: "Staff",
                column: "Searchid",
                principalTable: "Search",
                principalColumn: "id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Carousel_Search_Searchid",
                table: "Carousel");

            migrationBuilder.DropForeignKey(
                name: "FK_Shop_Search_Searchid",
                table: "Shop");

            migrationBuilder.DropForeignKey(
                name: "FK_Staff_Search_Searchid",
                table: "Staff");

            migrationBuilder.DropTable(
                name: "Search");

            migrationBuilder.DropIndex(
                name: "IX_Staff_Searchid",
                table: "Staff");

            migrationBuilder.DropIndex(
                name: "IX_Shop_Searchid",
                table: "Shop");

            migrationBuilder.DropIndex(
                name: "IX_Carousel_Searchid",
                table: "Carousel");

            migrationBuilder.DropColumn(
                name: "Searchid",
                table: "Staff");

            migrationBuilder.DropColumn(
                name: "Searchid",
                table: "Shop");

            migrationBuilder.DropColumn(
                name: "Searchid",
                table: "Carousel");

            migrationBuilder.CreateTable(
                name: "User",
                columns: table => new
                {
                    id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    email = table.Column<string>(nullable: true),
                    login = table.Column<string>(nullable: false),
                    password = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_User", x => x.id);
                });
        }
    }
}
