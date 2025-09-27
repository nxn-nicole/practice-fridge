using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace fridge_backend.Migrations
{
    /// <inheritdoc />
    public partial class SeedRoles2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "45569fef-b670-42d5-b55a-e49cc803f79c");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "7080b514-e5e7-49e1-9239-a826d5db706b");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "0c9fde52-0409-41bf-abfb-d847052d7926", null, "Admin", "ADMIN" },
                    { "b7f09c1d-40c4-458c-bf3e-5bee0808dfab", null, "User", "USER" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "0c9fde52-0409-41bf-abfb-d847052d7926");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "b7f09c1d-40c4-458c-bf3e-5bee0808dfab");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "45569fef-b670-42d5-b55a-e49cc803f79c", null, "User", "USER" },
                    { "7080b514-e5e7-49e1-9239-a826d5db706b", null, "Admin", "ADMIN" }
                });
        }
    }
}
