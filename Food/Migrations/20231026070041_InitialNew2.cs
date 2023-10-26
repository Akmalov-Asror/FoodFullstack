using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Food.Migrations
{
    /// <inheritdoc />
    public partial class InitialNew2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "0f37b4ec-56d5-40ff-858c-b428b5b5c643");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "ea59b99c-9bbe-474e-8820-ceeb2c739737");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "f7d8dfb9-57f8-4dcc-b482-6f9a353c9ee6");

            migrationBuilder.AddColumn<int>(
                name: "EOrderType",
                table: "Orders",
                type: "integer",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "EStatus",
                table: "Orders",
                type: "integer",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "8a11b870-0341-4bde-96e1-81664d09ffc8", null, "OWNER", "OWNER" },
                    { "d9f92a2d-2bf3-4042-bb5e-b648ce14c962", null, "CUSTOMER", "CUSTOMER" },
                    { "f1081811-eafd-48cd-9c96-eb21c2e483b9", null, "ADMIN", "ADMIN" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "8a11b870-0341-4bde-96e1-81664d09ffc8");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "d9f92a2d-2bf3-4042-bb5e-b648ce14c962");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "f1081811-eafd-48cd-9c96-eb21c2e483b9");

            migrationBuilder.DropColumn(
                name: "EOrderType",
                table: "Orders");

            migrationBuilder.DropColumn(
                name: "EStatus",
                table: "Orders");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "0f37b4ec-56d5-40ff-858c-b428b5b5c643", null, "ADMIN", "ADMIN" },
                    { "ea59b99c-9bbe-474e-8820-ceeb2c739737", null, "CUSTOMER", "CUSTOMER" },
                    { "f7d8dfb9-57f8-4dcc-b482-6f9a353c9ee6", null, "OWNER", "OWNER" }
                });
        }
    }
}
