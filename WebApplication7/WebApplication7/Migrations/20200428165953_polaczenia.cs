using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace WebApplication7.Migrations
{
    public partial class polaczenia : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
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

            migrationBuilder.CreateTable(
                name: "Trasa",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Stacja = table.Column<string>(nullable: true),
                    Godzina = table.Column<DateTime>(nullable: false),
                    Ilosc_miejsc = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Trasa", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Klientcs");

            migrationBuilder.DropTable(
                name: "Trasa");
        }
    }
}
