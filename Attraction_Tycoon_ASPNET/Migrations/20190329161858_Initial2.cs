using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Attraction_Tycoon_ASPNET.Migrations
{
    public partial class Initial2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Zone",
                columns: table => new
                {
                    id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    name = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Zone", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "Shop",
                columns: table => new
                {
                    id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    name = table.Column<string>(nullable: false),
                    type = table.Column<string>(nullable: false),
                    zoneid = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Shop", x => x.id);
                    table.ForeignKey(
                        name: "FK_Shop_Zone_zoneid",
                        column: x => x.zoneid,
                        principalTable: "Zone",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Staff",
                columns: table => new
                {
                    id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    id_user = table.Column<int>(nullable: false),
                    name = table.Column<string>(nullable: false),
                    type = table.Column<string>(nullable: false),
                    salary = table.Column<double>(nullable: false),
                    hours = table.Column<int>(nullable: false),
                    status = table.Column<string>(nullable: true),
                    shopid = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Staff", x => x.id);
                    table.ForeignKey(
                        name: "FK_Staff_Shop_shopid",
                        column: x => x.shopid,
                        principalTable: "Shop",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Shop_zoneid",
                table: "Shop",
                column: "zoneid");

            migrationBuilder.CreateIndex(
                name: "IX_Staff_shopid",
                table: "Staff",
                column: "shopid");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Staff");

            migrationBuilder.DropTable(
                name: "Shop");

            migrationBuilder.DropTable(
                name: "Zone");
        }
    }
}
