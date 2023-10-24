using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Food.Migrations
{
    /// <inheritdoc />
    public partial class init1 : Migration
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
                    { "261dc373-1db0-4278-88d9-aa6440105c08", null, "ADMIN", "ADMIN" },
                    { "57427abb-05c7-4e37-9233-e67966ed3f24", null, "OWNER", "OWNER" },
                    { "94842cb6-6cdb-4355-ae99-1576b7daf4bf", null, "CUSTOMER", "CUSTOMER" }
                });

            migrationBuilder.AddForeignKey(
                name: "FK_Foods_Category_CategoryId",
                table: "Foods",
                column: "CategoryId",
                principalTable: "Category",
                principalColumn: "Id");
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
                keyValue: "261dc373-1db0-4278-88d9-aa6440105c08");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "57427abb-05c7-4e37-9233-e67966ed3f24");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "94842cb6-6cdb-4355-ae99-1576b7daf4bf");

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
    }
}
