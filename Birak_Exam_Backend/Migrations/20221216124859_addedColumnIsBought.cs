using Microsoft.EntityFrameworkCore.Migrations;

namespace Birak_Exam_Backend.Migrations
{
    public partial class addedColumnIsBought : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<bool>(
                name: "IsBought",
                table: "ClothesItems",
                type: "bit",
                nullable: false,
                defaultValue: false);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "IsBought",
                table: "ClothesItems");
        }
    }
}
