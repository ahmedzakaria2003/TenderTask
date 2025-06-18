using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace TenderTask.DataAccess.Data.Migrations
{
    /// <inheritdoc />
    public partial class SeedingData : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: 1,
                column: "CategoryName",
                value: "Oil & Gas");

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: 2,
                column: "CategoryName",
                value: "Medical Services");

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "CategoryId", "CategoryName" },
                values: new object[,]
                {
                    { 3, "Construction" },
                    { 4, "IT Services" },
                    { 5, "Consulting" },
                    { 6, "Manufacturing" },
                    { 7, "Education" },
                    { 8, "Translation Services" },
                    { 9, "Maintenance" },
                    { 10, "Logistics" },
                    { 11, "Financial Services" },
                    { 12, "Security" },
                    { 13, "Environmental Services" },
                    { 14, "Design" },
                    { 15, "Agriculture" },
                    { 16, "Telecommunications" },
                    { 17, "Food & Beverage" },
                    { 18, "Transport" },
                    { 19, "Real Estate" },
                    { 20, "Legal Services" }
                });

            migrationBuilder.UpdateData(
                table: "Companies",
                keyColumn: "CompanyId",
                keyValue: 1,
                column: "CompanyName",
                value: "Oil Co. 1");

            migrationBuilder.UpdateData(
                table: "Companies",
                keyColumn: "CompanyId",
                keyValue: 2,
                column: "CompanyName",
                value: "Oil Co. 2");

            migrationBuilder.InsertData(
                table: "Companies",
                columns: new[] { "CompanyId", "CompanyName", "Location" },
                values: new object[,]
                {
                    { 3, "Oil Co. 3", null },
                    { 4, "Oil Co. 4", null },
                    { 5, "Medical Co. 1", null },
                    { 6, "Medical Co. 2", null },
                    { 7, "Medical Co. 3", null },
                    { 8, "Construction Co. 1", null },
                    { 9, "Construction Co. 2", null },
                    { 10, "Construction Co. 3", null },
                    { 11, "IT Co. 1", null },
                    { 12, "IT Co. 2", null },
                    { 13, "Consulting Co. 1", null },
                    { 14, "Consulting Co. 2", null },
                    { 15, "Consulting Co. 3", null },
                    { 16, "Manufacturing Co. 1", null },
                    { 17, "Manufacturing Co. 2", null },
                    { 18, "Manufacturing Co. 3", null },
                    { 19, "Education Co. 1", null },
                    { 20, "Education Co. 2", null },
                    { 21, "Translation Co. 1", null },
                    { 22, "Translation Co. 2", null },
                    { 23, "Translation Co. 3", null },
                    { 24, "Maintenance Co. 1", null },
                    { 25, "Maintenance Co. 2", null },
                    { 26, "Logistics Co. 1", null },
                    { 27, "Logistics Co. 2", null },
                    { 28, "Logistics Co. 3", null },
                    { 29, "Logistics Co. 4", null },
                    { 30, "Financial Co. 1", null },
                    { 31, "Financial Co. 2", null },
                    { 32, "Financial Co. 3", null },
                    { 33, "Financial Co. 4", null },
                    { 34, "Security Co. 1", null },
                    { 35, "Security Co. 2", null },
                    { 36, "Security Co. 3", null },
                    { 37, "Security Co. 4", null },
                    { 38, "Environmental Co. 1", null },
                    { 39, "Environmental Co. 2", null },
                    { 40, "Design Co. 1", null },
                    { 41, "Design Co. 2", null },
                    { 42, "Agriculture Co. 1", null },
                    { 43, "Agriculture Co. 2", null },
                    { 44, "Agriculture Co. 3", null },
                    { 45, "Telecommunications Co. 1", null },
                    { 46, "Telecommunications Co. 2", null },
                    { 47, "Telecommunications Co. 3", null },
                    { 48, "Food Co. 1", null },
                    { 49, "Food Co. 2", null },
                    { 50, "Transport Co. 1", null },
                    { 51, "Transport Co. 2", null },
                    { 52, "Real Co. 1", null },
                    { 53, "Real Co. 2", null },
                    { 54, "Real Co. 3", null },
                    { 55, "Real Co. 4", null },
                    { 56, "Legal Co. 1", null },
                    { 57, "Legal Co. 2", null }
                });

            migrationBuilder.UpdateData(
                table: "Tenders",
                keyColumn: "TenderId",
                keyValue: 1,
                columns: new[] { "Date", "Description", "Status" },
                values: new object[] { new DateTime(2025, 5, 3, 18, 59, 24, 453, DateTimeKind.Utc).AddTicks(810), "Oil & Gas Tender 1 for Oil Co. 1", 0 });

            migrationBuilder.UpdateData(
                table: "Tenders",
                keyColumn: "TenderId",
                keyValue: 2,
                columns: new[] { "CategoryId", "Date", "Description" },
                values: new object[] { 1, new DateTime(2025, 5, 13, 18, 59, 24, 453, DateTimeKind.Utc).AddTicks(819), "Oil & Gas Tender 1 for Oil Co. 2" });

            migrationBuilder.InsertData(
                table: "Tenders",
                columns: new[] { "TenderId", "CategoryId", "CompanyId", "Date", "Description", "DetailsLink", "Status" },
                values: new object[,]
                {
                    { 3, 1, 2, new DateTime(2025, 5, 18, 18, 59, 24, 453, DateTimeKind.Utc).AddTicks(821), "Oil & Gas Tender 2 for Oil Co. 2", "https://example.com/tenders/3", 0 },
                    { 4, 1, 3, new DateTime(2025, 5, 20, 18, 59, 24, 453, DateTimeKind.Utc).AddTicks(823), "Oil & Gas Tender 1 for Oil Co. 3", "https://example.com/tenders/4", 1 },
                    { 5, 1, 3, new DateTime(2025, 5, 23, 18, 59, 24, 453, DateTimeKind.Utc).AddTicks(824), "Oil & Gas Tender 2 for Oil Co. 3", "https://example.com/tenders/5", 1 },
                    { 6, 1, 3, new DateTime(2025, 5, 26, 18, 59, 24, 453, DateTimeKind.Utc).AddTicks(825), "Oil & Gas Tender 3 for Oil Co. 3", "https://example.com/tenders/6", 1 },
                    { 7, 2, 4, new DateTime(2025, 5, 27, 18, 59, 24, 453, DateTimeKind.Utc).AddTicks(827), "Construction Tender 1 for Build Co. 1", "https://example.com/tenders/7", 1 },
                    { 8, 2, 4, new DateTime(2025, 5, 28, 18, 59, 24, 453, DateTimeKind.Utc).AddTicks(828), "Construction Tender 2 for Build Co. 1", "https://example.com/tenders/8", 1 },
                    { 9, 2, 5, new DateTime(2025, 5, 29, 18, 59, 24, 453, DateTimeKind.Utc).AddTicks(829), "Construction Tender 1 for Build Co. 2", "https://example.com/tenders/9", 0 },
                    { 10, 2, 5, new DateTime(2025, 5, 30, 18, 59, 24, 453, DateTimeKind.Utc).AddTicks(830), "Construction Tender 2 for Build Co. 2", "https://example.com/tenders/10", 0 },
                    { 11, 3, 6, new DateTime(2025, 5, 31, 18, 59, 24, 453, DateTimeKind.Utc).AddTicks(832), "IT Tender 1 for Tech Co. 1", "https://example.com/tenders/11", 1 },
                    { 12, 3, 6, new DateTime(2025, 6, 1, 18, 59, 24, 453, DateTimeKind.Utc).AddTicks(833), "IT Tender 2 for Tech Co. 1", "https://example.com/tenders/12", 0 },
                    { 13, 3, 7, new DateTime(2025, 6, 2, 18, 59, 24, 453, DateTimeKind.Utc).AddTicks(834), "IT Tender 1 for Tech Co. 2", "https://example.com/tenders/13", 0 },
                    { 14, 3, 7, new DateTime(2025, 6, 3, 18, 59, 24, 453, DateTimeKind.Utc).AddTicks(835), "IT Tender 2 for Tech Co. 2", "https://example.com/tenders/14", 1 },
                    { 15, 4, 8, new DateTime(2025, 6, 4, 18, 59, 24, 453, DateTimeKind.Utc).AddTicks(837), "Medical Tender 1 for Health Co. 1", "https://example.com/tenders/15", 1 },
                    { 16, 4, 8, new DateTime(2025, 6, 5, 18, 59, 24, 453, DateTimeKind.Utc).AddTicks(838), "Medical Tender 2 for Health Co. 1", "https://example.com/tenders/16", 0 },
                    { 17, 4, 9, new DateTime(2025, 6, 6, 18, 59, 24, 453, DateTimeKind.Utc).AddTicks(839), "Medical Tender 1 for Health Co. 2", "https://example.com/tenders/17", 0 },
                    { 18, 4, 9, new DateTime(2025, 6, 7, 18, 59, 24, 453, DateTimeKind.Utc).AddTicks(841), "Medical Tender 2 for Health Co. 2", "https://example.com/tenders/18", 1 },
                    { 19, 5, 10, new DateTime(2025, 6, 8, 18, 59, 24, 453, DateTimeKind.Utc).AddTicks(842), "Education Tender 1 for Edu Co. 1", "https://example.com/tenders/19", 0 },
                    { 20, 5, 10, new DateTime(2025, 6, 9, 18, 59, 24, 453, DateTimeKind.Utc).AddTicks(843), "Education Tender 2 for Edu Co. 1", "https://example.com/tenders/20", 1 },
                    { 21, 5, 10, new DateTime(2025, 6, 10, 18, 59, 24, 453, DateTimeKind.Utc).AddTicks(844), "Education Tender 3 for Edu Co. 1", "https://example.com/tenders/21", 1 },
                    { 22, 5, 11, new DateTime(2025, 6, 11, 18, 59, 24, 453, DateTimeKind.Utc).AddTicks(846), "Education Tender 1 for Edu Co. 2", "https://example.com/tenders/22", 0 },
                    { 23, 5, 11, new DateTime(2025, 6, 12, 18, 59, 24, 453, DateTimeKind.Utc).AddTicks(847), "Education Tender 2 for Edu Co. 2", "https://example.com/tenders/23", 1 },
                    { 24, 6, 12, new DateTime(2025, 6, 13, 18, 59, 24, 453, DateTimeKind.Utc).AddTicks(848), "Agriculture Tender 1 for Agro Co. 1", "https://example.com/tenders/24", 1 },
                    { 25, 6, 12, new DateTime(2025, 6, 14, 18, 59, 24, 453, DateTimeKind.Utc).AddTicks(849), "Agriculture Tender 2 for Agro Co. 1", "https://example.com/tenders/25", 0 },
                    { 26, 6, 13, new DateTime(2025, 6, 15, 18, 59, 24, 453, DateTimeKind.Utc).AddTicks(851), "Agriculture Tender 1 for Agro Co. 2", "https://example.com/tenders/26", 0 },
                    { 27, 6, 13, new DateTime(2025, 6, 16, 18, 59, 24, 453, DateTimeKind.Utc).AddTicks(852), "Agriculture Tender 2 for Agro Co. 2", "https://example.com/tenders/27", 1 },
                    { 28, 7, 14, new DateTime(2025, 6, 17, 18, 59, 24, 453, DateTimeKind.Utc).AddTicks(853), "Transport Tender 1 for Trans Co. 1", "https://example.com/tenders/28", 1 },
                    { 29, 7, 14, new DateTime(2025, 6, 18, 18, 59, 24, 453, DateTimeKind.Utc).AddTicks(855), "Transport Tender 2 for Trans Co. 1", "https://example.com/tenders/29", 0 },
                    { 30, 7, 15, new DateTime(2025, 6, 19, 18, 59, 24, 453, DateTimeKind.Utc).AddTicks(856), "Transport Tender 1 for Trans Co. 2", "https://example.com/tenders/30", 0 },
                    { 31, 7, 15, new DateTime(2025, 6, 20, 18, 59, 24, 453, DateTimeKind.Utc).AddTicks(857), "Transport Tender 2 for Trans Co. 2", "https://example.com/tenders/31", 1 },
                    { 32, 8, 16, new DateTime(2025, 6, 21, 18, 59, 24, 453, DateTimeKind.Utc).AddTicks(858), "Energy Tender 1 for Energy Co. 1", "https://example.com/tenders/32", 1 },
                    { 33, 8, 16, new DateTime(2025, 6, 22, 18, 59, 24, 453, DateTimeKind.Utc).AddTicks(860), "Energy Tender 2 for Energy Co. 1", "https://example.com/tenders/33", 0 },
                    { 34, 8, 17, new DateTime(2025, 6, 23, 18, 59, 24, 453, DateTimeKind.Utc).AddTicks(861), "Energy Tender 1 for Energy Co. 2", "https://example.com/tenders/34", 1 },
                    { 35, 8, 17, new DateTime(2025, 6, 24, 18, 59, 24, 453, DateTimeKind.Utc).AddTicks(862), "Energy Tender 2 for Energy Co. 2", "https://example.com/tenders/35", 0 },
                    { 36, 9, 18, new DateTime(2025, 6, 25, 18, 59, 24, 453, DateTimeKind.Utc).AddTicks(863), "Finance Tender 1 for Finance Co. 1", "https://example.com/tenders/36", 1 },
                    { 37, 9, 18, new DateTime(2025, 6, 26, 18, 59, 24, 453, DateTimeKind.Utc).AddTicks(865), "Finance Tender 2 for Finance Co. 1", "https://example.com/tenders/37", 0 },
                    { 38, 9, 19, new DateTime(2025, 6, 27, 18, 59, 24, 453, DateTimeKind.Utc).AddTicks(866), "Finance Tender 1 for Finance Co. 2", "https://example.com/tenders/38", 1 },
                    { 39, 9, 19, new DateTime(2025, 6, 28, 18, 59, 24, 453, DateTimeKind.Utc).AddTicks(867), "Finance Tender 2 for Finance Co. 2", "https://example.com/tenders/39", 0 },
                    { 40, 10, 20, new DateTime(2025, 6, 29, 18, 59, 24, 453, DateTimeKind.Utc).AddTicks(868), "Legal Tender 1 for Legal Co. 1", "https://example.com/tenders/40", 1 },
                    { 41, 10, 20, new DateTime(2025, 6, 30, 18, 59, 24, 453, DateTimeKind.Utc).AddTicks(870), "Legal Tender 2 for Legal Co. 1", "https://example.com/tenders/41", 0 },
                    { 42, 10, 21, new DateTime(2025, 7, 1, 18, 59, 24, 453, DateTimeKind.Utc).AddTicks(871), "Legal Tender 1 for Legal Co. 2", "https://example.com/tenders/42", 1 },
                    { 43, 10, 21, new DateTime(2025, 7, 2, 18, 59, 24, 453, DateTimeKind.Utc).AddTicks(872), "Legal Tender 2 for Legal Co. 2", "https://example.com/tenders/43", 0 },
                    { 44, 11, 22, new DateTime(2025, 7, 3, 18, 59, 24, 453, DateTimeKind.Utc).AddTicks(874), "Telecom Tender 1 for Telecom Co. 1", "https://example.com/tenders/44", 1 },
                    { 45, 11, 22, new DateTime(2025, 7, 4, 18, 59, 24, 453, DateTimeKind.Utc).AddTicks(875), "Telecom Tender 2 for Telecom Co. 1", "https://example.com/tenders/45", 0 }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: 17);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: 18);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: 19);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: 20);

            migrationBuilder.DeleteData(
                table: "Companies",
                keyColumn: "CompanyId",
                keyValue: 23);

            migrationBuilder.DeleteData(
                table: "Companies",
                keyColumn: "CompanyId",
                keyValue: 24);

            migrationBuilder.DeleteData(
                table: "Companies",
                keyColumn: "CompanyId",
                keyValue: 25);

            migrationBuilder.DeleteData(
                table: "Companies",
                keyColumn: "CompanyId",
                keyValue: 26);

            migrationBuilder.DeleteData(
                table: "Companies",
                keyColumn: "CompanyId",
                keyValue: 27);

            migrationBuilder.DeleteData(
                table: "Companies",
                keyColumn: "CompanyId",
                keyValue: 28);

            migrationBuilder.DeleteData(
                table: "Companies",
                keyColumn: "CompanyId",
                keyValue: 29);

            migrationBuilder.DeleteData(
                table: "Companies",
                keyColumn: "CompanyId",
                keyValue: 30);

            migrationBuilder.DeleteData(
                table: "Companies",
                keyColumn: "CompanyId",
                keyValue: 31);

            migrationBuilder.DeleteData(
                table: "Companies",
                keyColumn: "CompanyId",
                keyValue: 32);

            migrationBuilder.DeleteData(
                table: "Companies",
                keyColumn: "CompanyId",
                keyValue: 33);

            migrationBuilder.DeleteData(
                table: "Companies",
                keyColumn: "CompanyId",
                keyValue: 34);

            migrationBuilder.DeleteData(
                table: "Companies",
                keyColumn: "CompanyId",
                keyValue: 35);

            migrationBuilder.DeleteData(
                table: "Companies",
                keyColumn: "CompanyId",
                keyValue: 36);

            migrationBuilder.DeleteData(
                table: "Companies",
                keyColumn: "CompanyId",
                keyValue: 37);

            migrationBuilder.DeleteData(
                table: "Companies",
                keyColumn: "CompanyId",
                keyValue: 38);

            migrationBuilder.DeleteData(
                table: "Companies",
                keyColumn: "CompanyId",
                keyValue: 39);

            migrationBuilder.DeleteData(
                table: "Companies",
                keyColumn: "CompanyId",
                keyValue: 40);

            migrationBuilder.DeleteData(
                table: "Companies",
                keyColumn: "CompanyId",
                keyValue: 41);

            migrationBuilder.DeleteData(
                table: "Companies",
                keyColumn: "CompanyId",
                keyValue: 42);

            migrationBuilder.DeleteData(
                table: "Companies",
                keyColumn: "CompanyId",
                keyValue: 43);

            migrationBuilder.DeleteData(
                table: "Companies",
                keyColumn: "CompanyId",
                keyValue: 44);

            migrationBuilder.DeleteData(
                table: "Companies",
                keyColumn: "CompanyId",
                keyValue: 45);

            migrationBuilder.DeleteData(
                table: "Companies",
                keyColumn: "CompanyId",
                keyValue: 46);

            migrationBuilder.DeleteData(
                table: "Companies",
                keyColumn: "CompanyId",
                keyValue: 47);

            migrationBuilder.DeleteData(
                table: "Companies",
                keyColumn: "CompanyId",
                keyValue: 48);

            migrationBuilder.DeleteData(
                table: "Companies",
                keyColumn: "CompanyId",
                keyValue: 49);

            migrationBuilder.DeleteData(
                table: "Companies",
                keyColumn: "CompanyId",
                keyValue: 50);

            migrationBuilder.DeleteData(
                table: "Companies",
                keyColumn: "CompanyId",
                keyValue: 51);

            migrationBuilder.DeleteData(
                table: "Companies",
                keyColumn: "CompanyId",
                keyValue: 52);

            migrationBuilder.DeleteData(
                table: "Companies",
                keyColumn: "CompanyId",
                keyValue: 53);

            migrationBuilder.DeleteData(
                table: "Companies",
                keyColumn: "CompanyId",
                keyValue: 54);

            migrationBuilder.DeleteData(
                table: "Companies",
                keyColumn: "CompanyId",
                keyValue: 55);

            migrationBuilder.DeleteData(
                table: "Companies",
                keyColumn: "CompanyId",
                keyValue: 56);

            migrationBuilder.DeleteData(
                table: "Companies",
                keyColumn: "CompanyId",
                keyValue: 57);

            migrationBuilder.DeleteData(
                table: "Tenders",
                keyColumn: "TenderId",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Tenders",
                keyColumn: "TenderId",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Tenders",
                keyColumn: "TenderId",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Tenders",
                keyColumn: "TenderId",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Tenders",
                keyColumn: "TenderId",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Tenders",
                keyColumn: "TenderId",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Tenders",
                keyColumn: "TenderId",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Tenders",
                keyColumn: "TenderId",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Tenders",
                keyColumn: "TenderId",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "Tenders",
                keyColumn: "TenderId",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "Tenders",
                keyColumn: "TenderId",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "Tenders",
                keyColumn: "TenderId",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "Tenders",
                keyColumn: "TenderId",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "Tenders",
                keyColumn: "TenderId",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "Tenders",
                keyColumn: "TenderId",
                keyValue: 17);

            migrationBuilder.DeleteData(
                table: "Tenders",
                keyColumn: "TenderId",
                keyValue: 18);

            migrationBuilder.DeleteData(
                table: "Tenders",
                keyColumn: "TenderId",
                keyValue: 19);

            migrationBuilder.DeleteData(
                table: "Tenders",
                keyColumn: "TenderId",
                keyValue: 20);

            migrationBuilder.DeleteData(
                table: "Tenders",
                keyColumn: "TenderId",
                keyValue: 21);

            migrationBuilder.DeleteData(
                table: "Tenders",
                keyColumn: "TenderId",
                keyValue: 22);

            migrationBuilder.DeleteData(
                table: "Tenders",
                keyColumn: "TenderId",
                keyValue: 23);

            migrationBuilder.DeleteData(
                table: "Tenders",
                keyColumn: "TenderId",
                keyValue: 24);

            migrationBuilder.DeleteData(
                table: "Tenders",
                keyColumn: "TenderId",
                keyValue: 25);

            migrationBuilder.DeleteData(
                table: "Tenders",
                keyColumn: "TenderId",
                keyValue: 26);

            migrationBuilder.DeleteData(
                table: "Tenders",
                keyColumn: "TenderId",
                keyValue: 27);

            migrationBuilder.DeleteData(
                table: "Tenders",
                keyColumn: "TenderId",
                keyValue: 28);

            migrationBuilder.DeleteData(
                table: "Tenders",
                keyColumn: "TenderId",
                keyValue: 29);

            migrationBuilder.DeleteData(
                table: "Tenders",
                keyColumn: "TenderId",
                keyValue: 30);

            migrationBuilder.DeleteData(
                table: "Tenders",
                keyColumn: "TenderId",
                keyValue: 31);

            migrationBuilder.DeleteData(
                table: "Tenders",
                keyColumn: "TenderId",
                keyValue: 32);

            migrationBuilder.DeleteData(
                table: "Tenders",
                keyColumn: "TenderId",
                keyValue: 33);

            migrationBuilder.DeleteData(
                table: "Tenders",
                keyColumn: "TenderId",
                keyValue: 34);

            migrationBuilder.DeleteData(
                table: "Tenders",
                keyColumn: "TenderId",
                keyValue: 35);

            migrationBuilder.DeleteData(
                table: "Tenders",
                keyColumn: "TenderId",
                keyValue: 36);

            migrationBuilder.DeleteData(
                table: "Tenders",
                keyColumn: "TenderId",
                keyValue: 37);

            migrationBuilder.DeleteData(
                table: "Tenders",
                keyColumn: "TenderId",
                keyValue: 38);

            migrationBuilder.DeleteData(
                table: "Tenders",
                keyColumn: "TenderId",
                keyValue: 39);

            migrationBuilder.DeleteData(
                table: "Tenders",
                keyColumn: "TenderId",
                keyValue: 40);

            migrationBuilder.DeleteData(
                table: "Tenders",
                keyColumn: "TenderId",
                keyValue: 41);

            migrationBuilder.DeleteData(
                table: "Tenders",
                keyColumn: "TenderId",
                keyValue: 42);

            migrationBuilder.DeleteData(
                table: "Tenders",
                keyColumn: "TenderId",
                keyValue: 43);

            migrationBuilder.DeleteData(
                table: "Tenders",
                keyColumn: "TenderId",
                keyValue: 44);

            migrationBuilder.DeleteData(
                table: "Tenders",
                keyColumn: "TenderId",
                keyValue: 45);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "Companies",
                keyColumn: "CompanyId",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Companies",
                keyColumn: "CompanyId",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Companies",
                keyColumn: "CompanyId",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Companies",
                keyColumn: "CompanyId",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Companies",
                keyColumn: "CompanyId",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Companies",
                keyColumn: "CompanyId",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Companies",
                keyColumn: "CompanyId",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Companies",
                keyColumn: "CompanyId",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Companies",
                keyColumn: "CompanyId",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "Companies",
                keyColumn: "CompanyId",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "Companies",
                keyColumn: "CompanyId",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "Companies",
                keyColumn: "CompanyId",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "Companies",
                keyColumn: "CompanyId",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "Companies",
                keyColumn: "CompanyId",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "Companies",
                keyColumn: "CompanyId",
                keyValue: 17);

            migrationBuilder.DeleteData(
                table: "Companies",
                keyColumn: "CompanyId",
                keyValue: 18);

            migrationBuilder.DeleteData(
                table: "Companies",
                keyColumn: "CompanyId",
                keyValue: 19);

            migrationBuilder.DeleteData(
                table: "Companies",
                keyColumn: "CompanyId",
                keyValue: 20);

            migrationBuilder.DeleteData(
                table: "Companies",
                keyColumn: "CompanyId",
                keyValue: 21);

            migrationBuilder.DeleteData(
                table: "Companies",
                keyColumn: "CompanyId",
                keyValue: 22);

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: 1,
                column: "CategoryName",
                value: "Construction");

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: 2,
                column: "CategoryName",
                value: "IT Services");

            migrationBuilder.UpdateData(
                table: "Companies",
                keyColumn: "CompanyId",
                keyValue: 1,
                column: "CompanyName",
                value: "Alpha Co.");

            migrationBuilder.UpdateData(
                table: "Companies",
                keyColumn: "CompanyId",
                keyValue: 2,
                column: "CompanyName",
                value: "Beta Ltd.");

            migrationBuilder.UpdateData(
                table: "Tenders",
                keyColumn: "TenderId",
                keyValue: 1,
                columns: new[] { "Date", "Description", "Status" },
                values: new object[] { new DateTime(2025, 6, 17, 16, 51, 33, 178, DateTimeKind.Utc).AddTicks(7940), "Build a new bridge", 1 });

            migrationBuilder.UpdateData(
                table: "Tenders",
                keyColumn: "TenderId",
                keyValue: 2,
                columns: new[] { "CategoryId", "Date", "Description" },
                values: new object[] { 2, new DateTime(2025, 6, 17, 16, 51, 33, 178, DateTimeKind.Utc).AddTicks(7949), "Develop CRM system" });
        }
    }
}
