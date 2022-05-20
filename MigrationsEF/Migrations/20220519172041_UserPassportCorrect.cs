using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MigrationsEF.Migrations
{
    public partial class UserPassportCorrect : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Passport",
                table: "Users",
                type: "char[]",
                nullable: false);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {

        }
    }
}
