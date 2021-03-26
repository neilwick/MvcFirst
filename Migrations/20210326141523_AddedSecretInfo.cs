using Microsoft.EntityFrameworkCore.Migrations;

namespace MvcFirst.Migrations
{
    public partial class AddedSecretInfo : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "SecretInformation",
                table: "Game",
                type: "TEXT",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "SecretInformation",
                table: "Game");
        }
    }
}
