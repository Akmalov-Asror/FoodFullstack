using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Food.Migrations
{
    /// <inheritdoc />
    public partial class Initialnewchanges : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "09e506f4-4fdc-461e-8f7e-238939df2219");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "88adca16-ecee-4a32-837e-81c231e23e30");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "f818f45f-1ff6-4b01-b56f-60374131c7ff");

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

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
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
                    { "09e506f4-4fdc-461e-8f7e-238939df2219", null, "CUSTOMER", "CUSTOMER" },
                    { "88adca16-ecee-4a32-837e-81c231e23e30", null, "ADMIN", "ADMIN" },
                    { "f818f45f-1ff6-4b01-b56f-60374131c7ff", null, "OWNER", "OWNER" }
                });
        }
    }
}
