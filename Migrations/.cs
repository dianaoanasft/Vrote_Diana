using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Vrote_Diana.Migrations
{
    public partial class Sale : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "LocationName",
                table: "Sale",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "PossibleBuyerFullName",
                table: "Sale",
                type: "int",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "LocationName",
                table: "Sale");

            migrationBuilder.DropColumn(
                name: "PossibleBuyerFullName",
                table: "Sale");
        }
    }
}
