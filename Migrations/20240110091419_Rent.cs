using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Vrote_Diana.Migrations
{
    public partial class Rent : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Id",
                table: "Home",
                newName: "ID");

            migrationBuilder.AddColumn<int>(
                name: "RentID",
                table: "Home",
                type: "int",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "Rent",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    PossibleBuyerID = table.Column<int>(type: "int", nullable: true),
                    HomeID = table.Column<int>(type: "int", nullable: true),
                    ReturnDate = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Rent", x => x.ID);
                    table.ForeignKey(
                        name: "FK_Rent_Home_HomeID",
                        column: x => x.HomeID,
                        principalTable: "Home",
                        principalColumn: "ID");
                    table.ForeignKey(
                        name: "FK_Rent_PossibleBuyer_PossibleBuyerID",
                        column: x => x.PossibleBuyerID,
                        principalTable: "PossibleBuyer",
                        principalColumn: "ID");
                });

            migrationBuilder.CreateIndex(
                name: "IX_Rent_HomeID",
                table: "Rent",
                column: "HomeID",
                unique: true,
                filter: "[HomeID] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_Rent_PossibleBuyerID",
                table: "Rent",
                column: "PossibleBuyerID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Rent");

            migrationBuilder.DropColumn(
                name: "RentID",
                table: "Home");

            migrationBuilder.RenameColumn(
                name: "ID",
                table: "Home",
                newName: "Id");
        }
    }
}
