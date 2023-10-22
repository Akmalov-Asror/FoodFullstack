using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Food.Migrations
{
    /// <inheritdoc />
    public partial class Init2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Foods_Category_CategoryId",
                table: "Foods");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "3b19ae8a-f51f-4908-a184-d5849aa390d8");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "a6d2a7f0-8dec-4e6d-97c1-c48bb7c119af");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "d9b4946a-ce05-47a4-8147-00edd371507b");

            migrationBuilder.AlterColumn<int>(
                name: "CategoryId",
                table: "Foods",
                type: "integer",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "integer",
                oldNullable: true);

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "2495653b-6633-4ac4-a790-bcbbb52e219f", null, "CUSTOMER", "CUSTOMER" },
                    { "b77dc44a-aa93-41ed-964e-6b9e2e3533f4", null, "OWNER", "OWNER" },
                    { "fa074b99-ee72-4d1e-8c0b-71a9a787bc96", null, "ADMIN", "ADMIN" }
                });

            migrationBuilder.AddForeignKey(
                name: "FK_Foods_Category_CategoryId",
                table: "Foods",
                column: "CategoryId",
                principalTable: "Category",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Foods_Category_CategoryId",
                table: "Foods");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "2495653b-6633-4ac4-a790-bcbbb52e219f");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "b77dc44a-aa93-41ed-964e-6b9e2e3533f4");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "fa074b99-ee72-4d1e-8c0b-71a9a787bc96");

            migrationBuilder.AlterColumn<int>(
                name: "CategoryId",
                table: "Foods",
                type: "integer",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "integer");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "3b19ae8a-f51f-4908-a184-d5849aa390d8", null, "OWNER", "OWNER" },
                    { "a6d2a7f0-8dec-4e6d-97c1-c48bb7c119af", null, "ADMIN", "ADMIN" },
                    { "d9b4946a-ce05-47a4-8147-00edd371507b", null, "CUSTOMER", "CUSTOMER" }
                });

            migrationBuilder.AddForeignKey(
                name: "FK_Foods_Category_CategoryId",
                table: "Foods",
                column: "CategoryId",
                principalTable: "Category",
                principalColumn: "Id");
        }
    }
}
