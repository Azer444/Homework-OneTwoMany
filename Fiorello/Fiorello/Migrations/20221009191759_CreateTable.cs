using Microsoft.EntityFrameworkCore.Migrations;

namespace Fiorello.Migrations
{
    public partial class CreateTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
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

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Image",
                table: "FlowerExperts",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "ImageDesc",
                table: "FlowerExperts",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "ImageHeader",
                table: "FlowerExperts",
                type: "nvarchar(max)",
                nullable: true);
        }
    }
}
