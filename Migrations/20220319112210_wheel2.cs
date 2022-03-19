using Microsoft.EntityFrameworkCore.Migrations;

namespace Derivco_Roulette.Migrations
{
    public partial class wheel2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "Id",
                table: "WinningNumbers",
                type: "int",
                nullable: false,
                defaultValue: 0)
                .Annotation("SqlServer:Identity", "1, 1");

            migrationBuilder.AddPrimaryKey(
                name: "PK_WinningNumbers",
                table: "WinningNumbers",
                column: "Id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_WinningNumbers",
                table: "WinningNumbers");

            migrationBuilder.DropColumn(
                name: "Id",
                table: "WinningNumbers");
        }
    }
}
