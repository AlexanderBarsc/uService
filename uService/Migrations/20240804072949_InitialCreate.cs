using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace uService.Migrations
{
    public partial class InitialCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Objednavky",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Name = table.Column<string>(type: "TEXT", nullable: false),
                    DatumVytvoreni = table.Column<DateTime>(type: "TEXT", nullable: false),
                    StavObjednavky = table.Column<int>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Objednavky", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "PolozkyObjednavky",
                columns: table => new
                {
                    NazevZbozi = table.Column<string>(type: "TEXT", nullable: false),
                    ObjednavkaId = table.Column<int>(type: "INTEGER", nullable: false),
                    PocetKusu = table.Column<int>(type: "INTEGER", nullable: false),
                    Cena = table.Column<decimal>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PolozkyObjednavky", x => new { x.NazevZbozi, x.ObjednavkaId });
                    table.ForeignKey(
                        name: "FK_PolozkyObjednavky_Objednavky_ObjednavkaId",
                        column: x => x.ObjednavkaId,
                        principalTable: "Objednavky",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_PolozkyObjednavky_ObjednavkaId",
                table: "PolozkyObjednavky",
                column: "ObjednavkaId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "PolozkyObjednavky");

            migrationBuilder.DropTable(
                name: "Objednavky");
        }
    }
}
