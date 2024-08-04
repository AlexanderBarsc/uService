using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace uService.Migrations
{
    public partial class RenameCenaToCenaZaKus : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Cena",
                table: "PolozkyObjednavky",
                newName: "CenaZaKus");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "CenaZaKus",
                table: "PolozkyObjednavky",
                newName: "Cena");
        }
    }
}
