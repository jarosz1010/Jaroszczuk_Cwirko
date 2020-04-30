using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace WebApplication7.Migrations
{
    public partial class kupujacy : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Transakcja_Klientcs_KlientId",
                table: "Transakcja");

            migrationBuilder.DropTable(
                name: "Klientcs");

            migrationBuilder.RenameColumn(
                name: "KlientId",
                table: "Transakcja",
                newName: "KupujacyId");

            migrationBuilder.RenameIndex(
                name: "IX_Transakcja_KlientId",
                table: "Transakcja",
                newName: "IX_Transakcja_KupujacyId");

            migrationBuilder.CreateTable(
                name: "Kupujacys",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Imie = table.Column<string>(nullable: true),
                    Nazwisko = table.Column<string>(nullable: true),
                    Znizka = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Kupujacys", x => x.Id);
                });

            migrationBuilder.AddForeignKey(
                name: "FK_Transakcja_Kupujacys_KupujacyId",
                table: "Transakcja",
                column: "KupujacyId",
                principalTable: "Kupujacys",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Transakcja_Kupujacys_KupujacyId",
                table: "Transakcja");

            migrationBuilder.DropTable(
                name: "Kupujacys");

            migrationBuilder.RenameColumn(
                name: "KupujacyId",
                table: "Transakcja",
                newName: "KlientId");

            migrationBuilder.RenameIndex(
                name: "IX_Transakcja_KupujacyId",
                table: "Transakcja",
                newName: "IX_Transakcja_KlientId");

            migrationBuilder.CreateTable(
                name: "Klientcs",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Imie = table.Column<string>(nullable: true),
                    Nazwisko = table.Column<string>(nullable: true),
                    Znizka = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Klientcs", x => x.Id);
                });

            migrationBuilder.AddForeignKey(
                name: "FK_Transakcja_Klientcs_KlientId",
                table: "Transakcja",
                column: "KlientId",
                principalTable: "Klientcs",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
