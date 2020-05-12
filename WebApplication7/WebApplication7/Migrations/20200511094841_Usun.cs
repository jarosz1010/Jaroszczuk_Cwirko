using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace WebApplication7.Migrations
{
    public partial class Usun : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Transakcja");

            migrationBuilder.AlterColumn<string>(
                name: "Godzina",
                table: "Trasa",
                nullable: true,
                oldClrType: typeof(DateTime));

            migrationBuilder.AlterColumn<int>(
               name: "Kolejnosc",
               table: "Trasa",
               nullable: true,
               oldClrType: typeof(int));

        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Kolejnosc",
                table: "Trasa");

            migrationBuilder.AlterColumn<DateTime>(
                name: "Godzina",
                table: "Trasa",
                nullable: false,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.CreateTable(
                name: "Transakcja",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    KupujacyId = table.Column<int>(nullable: true),
                    PolaczenieId = table.Column<int>(nullable: true),
                    PracownikId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Transakcja", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Transakcja_Kupujacys_KupujacyId",
                        column: x => x.KupujacyId,
                        principalTable: "Kupujacys",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Transakcja_Trasa_PolaczenieId",
                        column: x => x.PolaczenieId,
                        principalTable: "Trasa",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Transakcja_Pracownik_PracownikId",
                        column: x => x.PracownikId,
                        principalTable: "Pracownik",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Transakcja_KupujacyId",
                table: "Transakcja",
                column: "KupujacyId");

            migrationBuilder.CreateIndex(
                name: "IX_Transakcja_PolaczenieId",
                table: "Transakcja",
                column: "PolaczenieId");

            migrationBuilder.CreateIndex(
                name: "IX_Transakcja_PracownikId",
                table: "Transakcja",
                column: "PracownikId");
        }
    }
}
