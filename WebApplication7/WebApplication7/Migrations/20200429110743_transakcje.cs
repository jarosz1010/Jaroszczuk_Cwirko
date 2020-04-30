using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace WebApplication7.Migrations
{
    public partial class transakcje : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Transakcja",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    PolaczenieId = table.Column<int>(nullable: true),
                    KlientId = table.Column<int>(nullable: true),
                    PracownikId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Transakcja", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Transakcja_Klientcs_KlientId",
                        column: x => x.KlientId,
                        principalTable: "Klientcs",
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
                name: "IX_Transakcja_KlientId",
                table: "Transakcja",
                column: "KlientId");

            migrationBuilder.CreateIndex(
                name: "IX_Transakcja_PolaczenieId",
                table: "Transakcja",
                column: "PolaczenieId");

            migrationBuilder.CreateIndex(
                name: "IX_Transakcja_PracownikId",
                table: "Transakcja",
                column: "PracownikId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Transakcja");
        }
    }
}
