using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace TenderTask.DataAccess.Data.Migrations
{
    /// <inheritdoc />
    public partial class SeedTenders : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<int>(
                name: "Status",
                table: "Tenders",
                type: "int",
                nullable: false,
                oldClrType: typeof(bool),
                oldType: "bit");

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "CategoryId", "CategoryName" },
                values: new object[,]
                {
                    { 1, "Construction" },
                    { 2, "IT Services" }
                });

            migrationBuilder.InsertData(
                table: "Companies",
                columns: new[] { "CompanyId", "CompanyName", "Location" },
                values: new object[,]
                {
                    { 1, "Alpha Co.", null },
                    { 2, "Beta Ltd.", null }
                });

            migrationBuilder.InsertData(
                table: "Tenders",
                columns: new[] { "TenderId", "CategoryId", "CompanyId", "Date", "Description", "DetailsLink", "Status" },
                values: new object[,]
                {
                    { 1, 1, 1, new DateTime(2025, 6, 17, 16, 51, 33, 178, DateTimeKind.Utc).AddTicks(7940), "Build a new bridge", "https://example.com/tenders/1", 1 },
                    { 2, 2, 2, new DateTime(2025, 6, 17, 16, 51, 33, 178, DateTimeKind.Utc).AddTicks(7949), "Develop CRM system", "https://example.com/tenders/2", 0 }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Tenders",
                keyColumn: "TenderId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Tenders",
                keyColumn: "TenderId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Companies",
                keyColumn: "CompanyId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Companies",
                keyColumn: "CompanyId",
                keyValue: 2);

            migrationBuilder.AlterColumn<bool>(
                name: "Status",
                table: "Tenders",
                type: "bit",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int");
        }
    }
}
