using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Vrote_Diana.Migrations
{
    public partial class Member : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "MemberID",
                table: "Vanzare",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "MemberID",
                table: "Home",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "MemberID",
                table: "Buyer",
                type: "int",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "Member",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FirstName = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: true),
                    LastName = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: true),
                    Adress = table.Column<string>(type: "nvarchar(70)", maxLength: 70, nullable: true),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Phone = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Member", x => x.ID);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Vanzare_MemberID",
                table: "Vanzare",
                column: "MemberID");

            migrationBuilder.CreateIndex(
                name: "IX_Home_MemberID",
                table: "Home",
                column: "MemberID");

            migrationBuilder.CreateIndex(
                name: "IX_Buyer_MemberID",
                table: "Buyer",
                column: "MemberID");

            migrationBuilder.AddForeignKey(
                name: "FK_Buyer_Member_MemberID",
                table: "Buyer",
                column: "MemberID",
                principalTable: "Member",
                principalColumn: "ID");

            migrationBuilder.AddForeignKey(
                name: "FK_Home_Member_MemberID",
                table: "Home",
                column: "MemberID",
                principalTable: "Member",
                principalColumn: "ID");

            migrationBuilder.AddForeignKey(
                name: "FK_Vanzare_Member_MemberID",
                table: "Vanzare",
                column: "MemberID",
                principalTable: "Member",
                principalColumn: "ID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Buyer_Member_MemberID",
                table: "Buyer");

            migrationBuilder.DropForeignKey(
                name: "FK_Home_Member_MemberID",
                table: "Home");

            migrationBuilder.DropForeignKey(
                name: "FK_Vanzare_Member_MemberID",
                table: "Vanzare");

            migrationBuilder.DropTable(
                name: "Member");

            migrationBuilder.DropIndex(
                name: "IX_Vanzare_MemberID",
                table: "Vanzare");

            migrationBuilder.DropIndex(
                name: "IX_Home_MemberID",
                table: "Home");

            migrationBuilder.DropIndex(
                name: "IX_Buyer_MemberID",
                table: "Buyer");

            migrationBuilder.DropColumn(
                name: "MemberID",
                table: "Vanzare");

            migrationBuilder.DropColumn(
                name: "MemberID",
                table: "Home");

            migrationBuilder.DropColumn(
                name: "MemberID",
                table: "Buyer");
        }
    }
}
