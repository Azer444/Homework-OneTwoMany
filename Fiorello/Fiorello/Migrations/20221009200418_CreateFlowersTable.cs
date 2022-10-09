using Microsoft.EntityFrameworkCore.Migrations;

namespace Fiorello.Migrations
{
    public partial class CreateFlowersTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Image",
                table: "FlowerExperts",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "ImageDesc",
                table: "FlowerExperts",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "ImageHeader",
                table: "FlowerExperts",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Image",
                table: "FlowerExperts");

            migrationBuilder.DropColumn(
                name: "ImageDesc",
                table: "FlowerExperts");

            migrationBuilder.DropColumn(
                name: "ImageHeader",
                table: "FlowerExperts");
        }
    }
}
