using Microsoft.EntityFrameworkCore.Migrations;

namespace WebApplication7.Migrations
{
    public partial class pracownicy : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Haslo",
                table: "Pracownik",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Login",
                table: "Pracownik",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Stanowisko",
                table: "Pracownik",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Haslo",
                table: "Pracownik");

            migrationBuilder.DropColumn(
                name: "Login",
                table: "Pracownik");

            migrationBuilder.DropColumn(
                name: "Stanowisko",
                table: "Pracownik");
        }
    }
}
