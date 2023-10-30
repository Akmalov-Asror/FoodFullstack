using System;
using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Food.Migrations
{
    /// <inheritdoc />
    public partial class Unut1 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
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

            migrationBuilder.AddColumn<string>(
                name: "ImgUrl",
                table: "SellerFoods",
                type: "text",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<DateTime>(
                name: "CreatedTime",
                table: "Orders",
                type: "timestamp with time zone",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.CreateTable(
                name: "PaymentForOrders",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    UserEmail = table.Column<string>(type: "text", nullable: false),
                    UserName = table.Column<string>(type: "text", nullable: false),
                    Name = table.Column<string>(type: "text", nullable: false),
                    CardNumber = table.Column<string>(type: "text", nullable: false),
                    CardPassword = table.Column<string>(type: "text", nullable: false),
                    TableNumber = table.Column<string>(type: "text", nullable: false),
                    DateTime = table.Column<DateTime>(type: "timestamp with time zone", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PaymentForOrders", x => x.Id);
                });

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

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "PaymentForOrders");

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

            migrationBuilder.DropColumn(
                name: "ImgUrl",
                table: "SellerFoods");

            migrationBuilder.DropColumn(
                name: "CreatedTime",
                table: "Orders");

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
    }
}
