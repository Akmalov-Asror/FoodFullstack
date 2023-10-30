using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

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
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "15245294-7040-40b8-a558-2ab51a4cf5d9");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "5b226f1c-1b9b-41f9-9c34-fb291f7218c6");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "5cc474d3-da93-47ae-88bc-32ed7e396dea");

            migrationBuilder.CreateTable(
                name: "Hides",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Name = table.Column<string>(type: "text", nullable: false),
                    Description = table.Column<string>(type: "text", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Hides", x => x.Id);
                });

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

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Hides");

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
                    { "15245294-7040-40b8-a558-2ab51a4cf5d9", null, "ADMIN", "ADMIN" },
                    { "5b226f1c-1b9b-41f9-9c34-fb291f7218c6", null, "CUSTOMER", "CUSTOMER" },
                    { "5cc474d3-da93-47ae-88bc-32ed7e396dea", null, "OWNER", "OWNER" }
                });
        }
    }
}
