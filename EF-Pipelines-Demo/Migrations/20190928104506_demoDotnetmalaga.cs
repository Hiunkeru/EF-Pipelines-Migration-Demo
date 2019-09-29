using Microsoft.EntityFrameworkCore.Migrations;

namespace EF_Pipelines_Demo.Migrations
{
    public partial class demoDotnetmalaga : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "Dotnetmalaga",
                table: "Game",
                nullable: false,
                defaultValue: 0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Dotnetmalaga",
                table: "Game");
        }
    }
}
