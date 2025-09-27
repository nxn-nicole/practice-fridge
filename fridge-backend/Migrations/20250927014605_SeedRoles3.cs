using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace fridge_backend.Migrations
{
    /// <inheritdoc />
    public partial class SeedRoles3 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
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
                    { "2F6A3D7B-9C0D-4E5A-9B0B-111111111111", null, "Admin", "ADMIN" },
                    { "2F6A3D7B-9C0D-4E5A-9B0B-222222222222", null, "User", "USER" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "2F6A3D7B-9C0D-4E5A-9B0B-111111111111");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "2F6A3D7B-9C0D-4E5A-9B0B-222222222222");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "0c9fde52-0409-41bf-abfb-d847052d7926", null, "Admin", "ADMIN" },
                    { "b7f09c1d-40c4-458c-bf3e-5bee0808dfab", null, "User", "USER" }
                });
        }
    }
}
