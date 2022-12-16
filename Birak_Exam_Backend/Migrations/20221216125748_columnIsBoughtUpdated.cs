using Microsoft.EntityFrameworkCore.Migrations;

namespace Birak_Exam_Backend.Migrations
{
    public partial class columnIsBoughtUpdated : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "ClothesItems",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Discount", "IsBought" },
                values: new object[] { 0, true });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "ClothesItems",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Discount", "IsBought" },
                values: new object[] { 15, false });
        }
    }
}
