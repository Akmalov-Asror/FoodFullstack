using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Food.Migrations
{
    /// <inheritdoc />
    public partial class Init3 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "4ea56097-c20c-4f99-bf80-bae772738ef0");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "6702f9ba-c919-4c70-9a2d-4fb5839539c8");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "f65c9a63-220f-43c4-8a71-7461747edef7");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "51529f6d-6783-4bce-9854-f626fca5a1ab", null, "CUSTOMER", "CUSTOMER" },
                    { "5f5d71e1-d63a-4287-b535-472b03586350", null, "OWNER", "OWNER" },
                    { "c3230a0c-fab0-4f19-b753-a37436b3b5c2", null, "ADMIN", "ADMIN" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "51529f6d-6783-4bce-9854-f626fca5a1ab");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "5f5d71e1-d63a-4287-b535-472b03586350");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "c3230a0c-fab0-4f19-b753-a37436b3b5c2");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "4ea56097-c20c-4f99-bf80-bae772738ef0", null, "ADMIN", "ADMIN" },
                    { "6702f9ba-c919-4c70-9a2d-4fb5839539c8", null, "CUSTOMER", "CUSTOMER" },
                    { "f65c9a63-220f-43c4-8a71-7461747edef7", null, "OWNER", "OWNER" }
                });
        }
    }
}
