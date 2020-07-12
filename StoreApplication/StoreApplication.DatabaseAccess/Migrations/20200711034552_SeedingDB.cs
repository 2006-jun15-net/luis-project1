using Microsoft.EntityFrameworkCore.Migrations;

namespace StoreApplication.DatabaseAccess.Migrations
{
    public partial class SeedingDB : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "CategoryId", "CategoryDescription", "CategoryName" },
                values: new object[,]
                {
                    { 1, null, "Groceries" },
                    { 2, null, "Sporting Goods" },
                    { 3, null, "School Supplies" },
                    { 4, null, "Electronics" },
                    { 5, null, "Toys" }
                });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "ProductId", "CategoryId", "Description", "ImageThumbnailUrl", "ImageUrl", "IsInStock", "IsOnSale", "Name", "Price" },
                values: new object[,]
                {
                    { 1, 1, "Head of cabbage", "\\Images\\Cabbage.jpg", "\\Images\\Cabbage.jpg", true, true, "Cabbage", 1.99m },
                    { 4, 4, "Apple IPhone SE", "\\Images\\IphoneSE.png", "\\Images\\IphoneSE.png", true, false, "IPhone", 399.99m },
                    { 2, 2, "High-Quality aluminum baseball bat", "\\Images\\BaseballBat.jpg", "\\Images\\BaseballBat.jpg", true, false, "Baseball Bat", 36.99m },
                    { 3, 3, "Multi-purpose college ruled notebook", "\\Images\\Notebook.jpg", "\\Images\\Notebook.jpg", true, true, "College Ruled Notebook", 2.99m },
                    { 5, 5, "Lego Star Wars Kylo Ren's Shuttle", "\\Images\\LegoKyloRen.jpg", "\\Images\\LegoKyloRen.jpg", true, false, "Lego Set: Kylo Ren Shuttle", 129.95m }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: 5);
        }
    }
}
