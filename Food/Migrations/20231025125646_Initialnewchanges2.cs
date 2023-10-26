using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Food.Migrations
{
    /// <inheritdoc />
    public partial class Initialnewchanges2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "3a1beb2c-ae25-4f43-9961-8bcf0356f0a5");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "7c2f170c-c4af-49ed-8136-dd7e34394b48");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "b1c847a7-5273-4f14-a5a4-d0c0df78ee64");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "60cc9191-423d-4b92-9e9f-d7d386875ddc", null, "ADMIN", "ADMIN" },
                    { "91aaed4c-9371-49bd-8c9f-4efcca0c6f52", null, "CUSTOMER", "CUSTOMER" },
                    { "c44642f7-537c-444b-a1a9-2f69f4be46a6", null, "OWNER", "OWNER" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "60cc9191-423d-4b92-9e9f-d7d386875ddc");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "91aaed4c-9371-49bd-8c9f-4efcca0c6f52");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "c44642f7-537c-444b-a1a9-2f69f4be46a6");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "3a1beb2c-ae25-4f43-9961-8bcf0356f0a5", null, "OWNER", "OWNER" },
                    { "7c2f170c-c4af-49ed-8136-dd7e34394b48", null, "ADMIN", "ADMIN" },
                    { "b1c847a7-5273-4f14-a5a4-d0c0df78ee64", null, "CUSTOMER", "CUSTOMER" }
                });
        }
    }
}
