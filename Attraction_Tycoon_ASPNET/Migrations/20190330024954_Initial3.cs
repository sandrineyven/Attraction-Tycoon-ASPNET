using Microsoft.EntityFrameworkCore.Migrations;

namespace Attraction_Tycoon_ASPNET.Migrations
{
    public partial class Initial3 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Shop_Zone_zoneid",
                table: "Shop");

            migrationBuilder.DropIndex(
                name: "IX_Shop_zoneid",
                table: "Shop");

            migrationBuilder.RenameColumn(
                name: "zoneid",
                table: "Shop",
                newName: "zone");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "zone",
                table: "Shop",
                newName: "zoneid");

            migrationBuilder.CreateIndex(
                name: "IX_Shop_zoneid",
                table: "Shop",
                column: "zoneid");

            migrationBuilder.AddForeignKey(
                name: "FK_Shop_Zone_zoneid",
                table: "Shop",
                column: "zoneid",
                principalTable: "Zone",
                principalColumn: "id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
