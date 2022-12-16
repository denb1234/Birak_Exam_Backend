using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Birak_Exam_Backend.Migrations
{
    public partial class init : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "ClothesItems",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Price = table.Column<double>(type: "float", nullable: false),
                    Brand = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Date = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Size = table.Column<double>(type: "float", nullable: false),
                    Model = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Quantity = table.Column<int>(type: "int", nullable: false),
                    Discount = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ClothesItems", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "ClothesItems",
                columns: new[] { "Id", "Brand", "Date", "Discount", "Model", "Name", "Price", "Quantity", "Size" },
                values: new object[] { 1, "gergerm", new DateTime(2022, 9, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), 15, "fewfwe", "wegwegweg", 450.5, 5, 37.5 });

            migrationBuilder.InsertData(
                table: "ClothesItems",
                columns: new[] { "Id", "Brand", "Date", "Discount", "Model", "Name", "Price", "Quantity", "Size" },
                values: new object[] { 2, "rthrt", new DateTime(2022, 8, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), 20, "h65h65", "gerg", 750.5, 7, 40.5 });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ClothesItems");
        }
    }
}
