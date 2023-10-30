using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Food.Migrations
{
    /// <inheritdoc />
    public partial class Unut : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
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

            migrationBuilder.CreateTable(
                name: "SellerFoods",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Name = table.Column<string>(type: "text", nullable: false),
                    Count = table.Column<int>(type: "integer", nullable: false),
                    Price = table.Column<decimal>(type: "numeric", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SellerFoods", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "10e319ae-b9a7-48ef-a156-20758841e177", null, "CUSTOMER", "CUSTOMER" },
                    { "74b6b207-09b5-4316-ba7b-19027b3e210a", null, "ADMIN", "ADMIN" },
                    { "d8a69e3b-9826-47f8-86f0-1b07f50ee283", null, "OWNER", "OWNER" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "SellerFoods");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "10e319ae-b9a7-48ef-a156-20758841e177");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "74b6b207-09b5-4316-ba7b-19027b3e210a");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "d8a69e3b-9826-47f8-86f0-1b07f50ee283");

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
    }
}
