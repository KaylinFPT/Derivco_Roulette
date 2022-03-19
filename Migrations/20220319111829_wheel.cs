using Microsoft.EntityFrameworkCore.Migrations;

namespace Derivco_Roulette.Migrations
{
    public partial class wheel : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "WinningNumbers",
                columns: table => new
                {
                    Number = table.Column<int>(type: "int", nullable: false),
                    Color = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "WinningNumbers");
        }
    }
}
