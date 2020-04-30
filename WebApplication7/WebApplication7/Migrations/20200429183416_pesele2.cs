using Microsoft.EntityFrameworkCore.Migrations;

namespace WebApplication7.Migrations
{
    public partial class pesele2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "PESEL",
                table: "Pracownik",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "PESEL",
                table: "Kupujacys",
                nullable: false,
                defaultValue: 0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "PESEL",
                table: "Pracownik");

            migrationBuilder.DropColumn(
                name: "PESEL",
                table: "Kupujacys");
        }
    }
}
