using Microsoft.EntityFrameworkCore.Migrations;

namespace MarketLibrary.Migrations
{
    public partial class sibi : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Dropdowns",
                columns: table => new
                {
                    Departmentid = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Department = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    MarketID = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Dropdowns", x => x.Departmentid);
                    table.ForeignKey(
                        name: "FK_Dropdowns_SuperMarket_MarketID",
                        column: x => x.MarketID,
                        principalTable: "SuperMarket",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Dropdowns_MarketID",
                table: "Dropdowns",
                column: "MarketID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Dropdowns");
        }
    }
}
