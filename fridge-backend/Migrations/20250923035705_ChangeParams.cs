using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace fridge_backend.Migrations
{
    /// <inheritdoc />
    public partial class ChangeParams : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Ingredients_Receipt_ReceiptId",
                table: "Ingredients");

            migrationBuilder.DropForeignKey(
                name: "FK_Receipt_Category_CategoriesId",
                table: "Receipt");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Receipt",
                table: "Receipt");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Category",
                table: "Category");

            migrationBuilder.RenameTable(
                name: "Receipt",
                newName: "Receipts");

            migrationBuilder.RenameTable(
                name: "Category",
                newName: "Categories");

            migrationBuilder.RenameColumn(
                name: "CategoriesId",
                table: "Receipts",
                newName: "CategoryId");

            migrationBuilder.RenameIndex(
                name: "IX_Receipt_CategoriesId",
                table: "Receipts",
                newName: "IX_Receipts_CategoryId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Receipts",
                table: "Receipts",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Categories",
                table: "Categories",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Ingredients_Receipts_ReceiptId",
                table: "Ingredients",
                column: "ReceiptId",
                principalTable: "Receipts",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Receipts_Categories_CategoryId",
                table: "Receipts",
                column: "CategoryId",
                principalTable: "Categories",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Ingredients_Receipts_ReceiptId",
                table: "Ingredients");

            migrationBuilder.DropForeignKey(
                name: "FK_Receipts_Categories_CategoryId",
                table: "Receipts");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Receipts",
                table: "Receipts");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Categories",
                table: "Categories");

            migrationBuilder.RenameTable(
                name: "Receipts",
                newName: "Receipt");

            migrationBuilder.RenameTable(
                name: "Categories",
                newName: "Category");

            migrationBuilder.RenameColumn(
                name: "CategoryId",
                table: "Receipt",
                newName: "CategoriesId");

            migrationBuilder.RenameIndex(
                name: "IX_Receipts_CategoryId",
                table: "Receipt",
                newName: "IX_Receipt_CategoriesId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Receipt",
                table: "Receipt",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Category",
                table: "Category",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Ingredients_Receipt_ReceiptId",
                table: "Ingredients",
                column: "ReceiptId",
                principalTable: "Receipt",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Receipt_Category_CategoriesId",
                table: "Receipt",
                column: "CategoriesId",
                principalTable: "Category",
                principalColumn: "Id");
        }
    }
}
