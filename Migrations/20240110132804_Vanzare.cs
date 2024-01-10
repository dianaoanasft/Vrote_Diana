using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Vrote_Diana.Migrations
{
    public partial class Vanzare : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Id",
                table: "Home",
                newName: "ID");

            migrationBuilder.AddColumn<int>(
                name: "VanzareID",
                table: "Home",
                type: "int",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "Vanzare",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    PossibleBuyerID = table.Column<int>(type: "int", nullable: true),
                    HomeID = table.Column<int>(type: "int", nullable: true),
                    DataVanzare = table.Column<DateTime>(type: "datetime2", nullable: false),
                    PretVanzare = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Vanzare", x => x.ID);
                    table.ForeignKey(
                        name: "FK_Vanzare_Home_HomeID",
                        column: x => x.HomeID,
                        principalTable: "Home",
                        principalColumn: "ID");
                    table.ForeignKey(
                        name: "FK_Vanzare_PossibleBuyer_PossibleBuyerID",
                        column: x => x.PossibleBuyerID,
                        principalTable: "PossibleBuyer",
                        principalColumn: "ID");
                });

            migrationBuilder.CreateIndex(
                name: "IX_Vanzare_HomeID",
                table: "Vanzare",
                column: "HomeID",
                unique: true,
                filter: "[HomeID] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_Vanzare_PossibleBuyerID",
                table: "Vanzare",
                column: "PossibleBuyerID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Vanzare");

            migrationBuilder.DropColumn(
                name: "VanzareID",
                table: "Home");

            migrationBuilder.RenameColumn(
                name: "ID",
                table: "Home",
                newName: "Id");
        }
    }
}
