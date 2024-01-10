using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Vrote_Diana.Migrations
{
    public partial class Buyer : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "BuyerID",
                table: "Vanzare",
                type: "int",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "Buyer",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FirstName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    LastName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Adress = table.Column<string>(type: "nvarchar(70)", maxLength: 70, nullable: true),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Phone = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Buyer", x => x.ID);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Vanzare_BuyerID",
                table: "Vanzare",
                column: "BuyerID");

            migrationBuilder.AddForeignKey(
                name: "FK_Vanzare_Buyer_BuyerID",
                table: "Vanzare",
                column: "BuyerID",
                principalTable: "Buyer",
                principalColumn: "ID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Vanzare_Buyer_BuyerID",
                table: "Vanzare");

            migrationBuilder.DropTable(
                name: "Buyer");

            migrationBuilder.DropIndex(
                name: "IX_Vanzare_BuyerID",
                table: "Vanzare");

            migrationBuilder.DropColumn(
                name: "BuyerID",
                table: "Vanzare");
        }
    }
}
