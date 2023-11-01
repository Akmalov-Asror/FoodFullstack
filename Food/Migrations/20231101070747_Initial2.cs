using System;
using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Food.Migrations
{
    /// <inheritdoc />
    public partial class Initial2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "962b3cee-5fe9-4b82-9e2d-37d570dbb6dd");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "bee4f93a-9447-449d-b6d7-505a5134e003");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "e0a43b56-d4a7-4913-8fdc-faeb2e187814");

            migrationBuilder.CreateTable(
                name: "MessageModels",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    SenderUserId = table.Column<string>(type: "text", nullable: false),
                    ReceiverUserId = table.Column<string>(type: "text", nullable: false),
                    Content = table.Column<string>(type: "text", nullable: false),
                    Timestamp = table.Column<DateTime>(type: "timestamp with time zone", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MessageModels", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "UserChatModels",
                columns: table => new
                {
                    Id = table.Column<string>(type: "text", nullable: false),
                    UserName = table.Column<string>(type: "text", nullable: false),
                    ProfilePictureUrl = table.Column<string>(type: "text", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserChatModels", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "0f1f1c87-d511-490d-a03e-b851ed3c762f", null, "OWNER", "OWNER" },
                    { "81c35f1e-5e0b-4e44-9b46-3573c5b6803b", null, "CUSTOMER", "CUSTOMER" },
                    { "a8cd2c73-e134-4ad4-8eb7-bcd90163136c", null, "ADMIN", "ADMIN" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "MessageModels");

            migrationBuilder.DropTable(
                name: "UserChatModels");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "0f1f1c87-d511-490d-a03e-b851ed3c762f");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "81c35f1e-5e0b-4e44-9b46-3573c5b6803b");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "a8cd2c73-e134-4ad4-8eb7-bcd90163136c");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "962b3cee-5fe9-4b82-9e2d-37d570dbb6dd", null, "ADMIN", "ADMIN" },
                    { "bee4f93a-9447-449d-b6d7-505a5134e003", null, "OWNER", "OWNER" },
                    { "e0a43b56-d4a7-4913-8fdc-faeb2e187814", null, "CUSTOMER", "CUSTOMER" }
                });
        }
    }
}
