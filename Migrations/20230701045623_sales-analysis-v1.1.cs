using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace sales_analysis.Migrations
{
    public partial class salesanalysisv11 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "locations",
                columns: new[] { "location_id", "name" },
                values: new object[,]
                {
                    { 1, "Chennai" },
                    { 2, "Delhi" },
                    { 3, "Mumbai" },
                    { 4, "Bengaluru" },
                    { 5, "Hyderabad" }
                });

            migrationBuilder.InsertData(
                table: "sales_records",
                columns: new[] { "sales_id", "location_id", "price", "product_name", "sales_date", "total_sales_amount", "total_units" },
                values: new object[,]
                {
                    { 1, 1, 8000, "VA1", new DateTime(2023, 6, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), 80000, 10 },
                    { 2, 1, 6000, "VA2", new DateTime(2023, 6, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), 60000, 10 },
                    { 3, 1, 9000, "VA3", new DateTime(2023, 6, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), 90000, 10 },
                    { 4, 2, 8000, "VA1", new DateTime(2023, 6, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), 96000, 12 },
                    { 5, 2, 6000, "VA2", new DateTime(2023, 6, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), 180000, 30 },
                    { 6, 2, 9000, "VA3", new DateTime(2023, 6, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), 405000, 45 },
                    { 7, 3, 8000, "VA1", new DateTime(2023, 6, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), 120000, 15 },
                    { 8, 3, 6000, "VA2", new DateTime(2023, 6, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), 108000, 18 },
                    { 9, 3, 9000, "VA3", new DateTime(2023, 6, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), 72000, 8 },
                    { 10, 4, 8000, "VA1", new DateTime(2023, 6, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), 112000, 14 },
                    { 11, 4, 6000, "VA2", new DateTime(2023, 6, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), 120000, 20 },
                    { 12, 4, 9000, "VA3", new DateTime(2023, 6, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), 171000, 19 },
                    { 13, 5, 8000, "VA1", new DateTime(2023, 6, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), 176000, 22 },
                    { 14, 5, 6000, "VA2", new DateTime(2023, 6, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), 96000, 16 },
                    { 15, 5, 9000, "VA3", new DateTime(2023, 6, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), 207000, 23 },
                    { 16, 1, 8000, "VA1", new DateTime(2023, 6, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), 160000, 20 },
                    { 17, 1, 6000, "VA2", new DateTime(2023, 6, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), 180000, 30 },
                    { 18, 1, 9000, "VA3", new DateTime(2023, 6, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), 207000, 23 },
                    { 19, 2, 8000, "VA1", new DateTime(2023, 6, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), 112000, 14 },
                    { 20, 2, 6000, "VA2", new DateTime(2023, 6, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), 204000, 34 },
                    { 21, 2, 9000, "VA3", new DateTime(2023, 6, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), 504000, 56 },
                    { 22, 3, 8000, "VA1", new DateTime(2023, 6, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), 208000, 26 },
                    { 23, 3, 6000, "VA2", new DateTime(2023, 6, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), 198000, 33 },
                    { 24, 3, 9000, "VA3", new DateTime(2023, 6, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), 189000, 21 },
                    { 25, 4, 8000, "VA1", new DateTime(2023, 6, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), 240000, 30 },
                    { 26, 4, 6000, "VA2", new DateTime(2023, 6, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), 90000, 15 },
                    { 27, 4, 9000, "VA3", new DateTime(2023, 6, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), 162000, 18 },
                    { 28, 5, 8000, "VA1", new DateTime(2023, 6, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), 280000, 35 },
                    { 29, 5, 6000, "VA2", new DateTime(2023, 6, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), 108000, 18 },
                    { 30, 5, 9000, "VA3", new DateTime(2023, 6, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), 234000, 26 },
                    { 31, 1, 8000, "VA1", new DateTime(2023, 6, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), 360000, 45 },
                    { 32, 1, 6000, "VA2", new DateTime(2023, 6, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), 216000, 36 },
                    { 33, 1, 9000, "VA3", new DateTime(2023, 6, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), 702000, 78 },
                    { 34, 2, 8000, "VA1", new DateTime(2023, 6, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), 560000, 70 },
                    { 35, 2, 6000, "VA2", new DateTime(2023, 6, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), 402000, 67 },
                    { 36, 2, 9000, "VA3", new DateTime(2023, 6, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), 450000, 50 },
                    { 37, 3, 8000, "VA1", new DateTime(2023, 6, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), 400000, 50 },
                    { 38, 3, 6000, "VA2", new DateTime(2023, 6, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), 180000, 30 },
                    { 39, 3, 9000, "VA3", new DateTime(2023, 6, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), 630000, 70 },
                    { 40, 4, 8000, "VA1", new DateTime(2023, 6, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), 160000, 20 },
                    { 41, 4, 6000, "VA2", new DateTime(2023, 6, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), 78000, 13 },
                    { 42, 4, 9000, "VA3", new DateTime(2023, 6, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), 540000, 60 }
                });

            migrationBuilder.InsertData(
                table: "sales_records",
                columns: new[] { "sales_id", "location_id", "price", "product_name", "sales_date", "total_sales_amount", "total_units" },
                values: new object[,]
                {
                    { 43, 5, 8000, "VA1", new DateTime(2023, 6, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), 264000, 33 },
                    { 44, 5, 6000, "VA2", new DateTime(2023, 6, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), 144000, 24 },
                    { 45, 5, 9000, "VA3", new DateTime(2023, 6, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), 153000, 17 },
                    { 46, 1, 8000, "VA1", new DateTime(2023, 6, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), 184000, 23 },
                    { 47, 1, 6000, "VA2", new DateTime(2023, 6, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), 72000, 12 },
                    { 48, 1, 9000, "VA3", new DateTime(2023, 6, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), 117000, 13 },
                    { 49, 2, 8000, "VA1", new DateTime(2023, 6, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), 800000, 100 },
                    { 50, 2, 6000, "VA2", new DateTime(2023, 6, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), 720000, 120 },
                    { 51, 2, 9000, "VA3", new DateTime(2023, 6, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), 387000, 43 },
                    { 52, 3, 8000, "VA1", new DateTime(2023, 6, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), 144000, 18 },
                    { 53, 3, 6000, "VA2", new DateTime(2023, 6, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), 102000, 17 },
                    { 54, 3, 9000, "VA3", new DateTime(2023, 6, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), 162000, 18 },
                    { 55, 4, 8000, "VA1", new DateTime(2023, 6, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), 176000, 22 },
                    { 56, 4, 6000, "VA2", new DateTime(2023, 6, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), 150000, 25 },
                    { 57, 4, 9000, "VA3", new DateTime(2023, 6, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), 180000, 20 },
                    { 58, 5, 8000, "VA1", new DateTime(2023, 6, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), 200000, 25 },
                    { 59, 5, 6000, "VA2", new DateTime(2023, 6, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), 210000, 35 },
                    { 60, 5, 9000, "VA3", new DateTime(2023, 6, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), 171000, 19 },
                    { 61, 1, 8000, "VA1", new DateTime(2023, 6, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), 32000, 4 },
                    { 62, 1, 6000, "VA2", new DateTime(2023, 6, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), 30000, 5 },
                    { 63, 1, 9000, "VA3", new DateTime(2023, 6, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), 54000, 6 },
                    { 64, 2, 8000, "VA1", new DateTime(2023, 6, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), 80000, 10 },
                    { 65, 2, 6000, "VA2", new DateTime(2023, 6, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), 192000, 32 },
                    { 66, 2, 9000, "VA3", new DateTime(2023, 6, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), 207000, 23 },
                    { 67, 3, 8000, "VA1", new DateTime(2023, 6, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), 64000, 8 },
                    { 68, 3, 6000, "VA2", new DateTime(2023, 6, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), 90000, 15 },
                    { 69, 3, 9000, "VA3", new DateTime(2023, 6, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), 144000, 16 },
                    { 70, 4, 8000, "VA1", new DateTime(2023, 6, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), 128000, 16 },
                    { 71, 4, 6000, "VA2", new DateTime(2023, 6, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), 120000, 20 },
                    { 72, 4, 9000, "VA3", new DateTime(2023, 6, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), 207000, 23 },
                    { 73, 5, 8000, "VA1", new DateTime(2023, 6, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), 184000, 23 },
                    { 74, 5, 6000, "VA2", new DateTime(2023, 6, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), 108000, 18 },
                    { 75, 5, 9000, "VA3", new DateTime(2023, 6, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), 324000, 36 },
                    { 76, 1, 8000, "VA1", new DateTime(2023, 6, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), 64000, 8 },
                    { 77, 1, 6000, "VA2", new DateTime(2023, 6, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), 54000, 9 },
                    { 78, 1, 9000, "VA3", new DateTime(2023, 6, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), 90000, 10 },
                    { 79, 2, 8000, "VA1", new DateTime(2023, 6, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), 432000, 54 },
                    { 80, 2, 6000, "VA2", new DateTime(2023, 6, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), 390000, 65 },
                    { 81, 2, 9000, "VA3", new DateTime(2023, 6, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), 207000, 23 },
                    { 82, 3, 8000, "VA1", new DateTime(2023, 6, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), 96000, 12 },
                    { 83, 3, 6000, "VA2", new DateTime(2023, 6, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), 138000, 23 },
                    { 84, 3, 9000, "VA3", new DateTime(2023, 6, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), 99000, 11 }
                });

            migrationBuilder.InsertData(
                table: "sales_records",
                columns: new[] { "sales_id", "location_id", "price", "product_name", "sales_date", "total_sales_amount", "total_units" },
                values: new object[,]
                {
                    { 85, 4, 8000, "VA1", new DateTime(2023, 6, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), 160000, 20 },
                    { 86, 4, 6000, "VA2", new DateTime(2023, 6, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), 102000, 17 },
                    { 87, 4, 9000, "VA3", new DateTime(2023, 6, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), 225000, 25 },
                    { 88, 5, 8000, "VA1", new DateTime(2023, 6, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), 144000, 18 },
                    { 89, 5, 6000, "VA2", new DateTime(2023, 6, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), 150000, 25 },
                    { 90, 5, 9000, "VA3", new DateTime(2023, 6, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), 315000, 35 },
                    { 91, 1, 8000, "VA1", new DateTime(2023, 6, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), 360000, 45 },
                    { 92, 1, 6000, "VA2", new DateTime(2023, 6, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), 264000, 44 },
                    { 93, 1, 9000, "VA3", new DateTime(2023, 6, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), 54000, 6 },
                    { 94, 2, 8000, "VA1", new DateTime(2023, 6, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), 256000, 32 },
                    { 95, 2, 6000, "VA2", new DateTime(2023, 6, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), 126000, 21 },
                    { 96, 2, 9000, "VA3", new DateTime(2023, 6, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), 396000, 44 },
                    { 97, 3, 8000, "VA1", new DateTime(2023, 6, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), 328000, 41 },
                    { 98, 3, 6000, "VA2", new DateTime(2023, 6, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), 258000, 43 },
                    { 99, 3, 9000, "VA3", new DateTime(2023, 6, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), 63000, 7 },
                    { 100, 4, 8000, "VA1", new DateTime(2023, 6, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), 352000, 44 },
                    { 101, 4, 6000, "VA2", new DateTime(2023, 6, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), 150000, 25 },
                    { 102, 4, 9000, "VA3", new DateTime(2023, 6, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), 171000, 19 },
                    { 103, 5, 8000, "VA1", new DateTime(2023, 6, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), 320000, 40 },
                    { 104, 5, 6000, "VA2", new DateTime(2023, 6, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), 168000, 28 },
                    { 105, 5, 9000, "VA3", new DateTime(2023, 6, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), 198000, 22 }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "sales_records",
                keyColumn: "sales_id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "sales_records",
                keyColumn: "sales_id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "sales_records",
                keyColumn: "sales_id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "sales_records",
                keyColumn: "sales_id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "sales_records",
                keyColumn: "sales_id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "sales_records",
                keyColumn: "sales_id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "sales_records",
                keyColumn: "sales_id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "sales_records",
                keyColumn: "sales_id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "sales_records",
                keyColumn: "sales_id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "sales_records",
                keyColumn: "sales_id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "sales_records",
                keyColumn: "sales_id",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "sales_records",
                keyColumn: "sales_id",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "sales_records",
                keyColumn: "sales_id",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "sales_records",
                keyColumn: "sales_id",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "sales_records",
                keyColumn: "sales_id",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "sales_records",
                keyColumn: "sales_id",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "sales_records",
                keyColumn: "sales_id",
                keyValue: 17);

            migrationBuilder.DeleteData(
                table: "sales_records",
                keyColumn: "sales_id",
                keyValue: 18);

            migrationBuilder.DeleteData(
                table: "sales_records",
                keyColumn: "sales_id",
                keyValue: 19);

            migrationBuilder.DeleteData(
                table: "sales_records",
                keyColumn: "sales_id",
                keyValue: 20);

            migrationBuilder.DeleteData(
                table: "sales_records",
                keyColumn: "sales_id",
                keyValue: 21);

            migrationBuilder.DeleteData(
                table: "sales_records",
                keyColumn: "sales_id",
                keyValue: 22);

            migrationBuilder.DeleteData(
                table: "sales_records",
                keyColumn: "sales_id",
                keyValue: 23);

            migrationBuilder.DeleteData(
                table: "sales_records",
                keyColumn: "sales_id",
                keyValue: 24);

            migrationBuilder.DeleteData(
                table: "sales_records",
                keyColumn: "sales_id",
                keyValue: 25);

            migrationBuilder.DeleteData(
                table: "sales_records",
                keyColumn: "sales_id",
                keyValue: 26);

            migrationBuilder.DeleteData(
                table: "sales_records",
                keyColumn: "sales_id",
                keyValue: 27);

            migrationBuilder.DeleteData(
                table: "sales_records",
                keyColumn: "sales_id",
                keyValue: 28);

            migrationBuilder.DeleteData(
                table: "sales_records",
                keyColumn: "sales_id",
                keyValue: 29);

            migrationBuilder.DeleteData(
                table: "sales_records",
                keyColumn: "sales_id",
                keyValue: 30);

            migrationBuilder.DeleteData(
                table: "sales_records",
                keyColumn: "sales_id",
                keyValue: 31);

            migrationBuilder.DeleteData(
                table: "sales_records",
                keyColumn: "sales_id",
                keyValue: 32);

            migrationBuilder.DeleteData(
                table: "sales_records",
                keyColumn: "sales_id",
                keyValue: 33);

            migrationBuilder.DeleteData(
                table: "sales_records",
                keyColumn: "sales_id",
                keyValue: 34);

            migrationBuilder.DeleteData(
                table: "sales_records",
                keyColumn: "sales_id",
                keyValue: 35);

            migrationBuilder.DeleteData(
                table: "sales_records",
                keyColumn: "sales_id",
                keyValue: 36);

            migrationBuilder.DeleteData(
                table: "sales_records",
                keyColumn: "sales_id",
                keyValue: 37);

            migrationBuilder.DeleteData(
                table: "sales_records",
                keyColumn: "sales_id",
                keyValue: 38);

            migrationBuilder.DeleteData(
                table: "sales_records",
                keyColumn: "sales_id",
                keyValue: 39);

            migrationBuilder.DeleteData(
                table: "sales_records",
                keyColumn: "sales_id",
                keyValue: 40);

            migrationBuilder.DeleteData(
                table: "sales_records",
                keyColumn: "sales_id",
                keyValue: 41);

            migrationBuilder.DeleteData(
                table: "sales_records",
                keyColumn: "sales_id",
                keyValue: 42);

            migrationBuilder.DeleteData(
                table: "sales_records",
                keyColumn: "sales_id",
                keyValue: 43);

            migrationBuilder.DeleteData(
                table: "sales_records",
                keyColumn: "sales_id",
                keyValue: 44);

            migrationBuilder.DeleteData(
                table: "sales_records",
                keyColumn: "sales_id",
                keyValue: 45);

            migrationBuilder.DeleteData(
                table: "sales_records",
                keyColumn: "sales_id",
                keyValue: 46);

            migrationBuilder.DeleteData(
                table: "sales_records",
                keyColumn: "sales_id",
                keyValue: 47);

            migrationBuilder.DeleteData(
                table: "sales_records",
                keyColumn: "sales_id",
                keyValue: 48);

            migrationBuilder.DeleteData(
                table: "sales_records",
                keyColumn: "sales_id",
                keyValue: 49);

            migrationBuilder.DeleteData(
                table: "sales_records",
                keyColumn: "sales_id",
                keyValue: 50);

            migrationBuilder.DeleteData(
                table: "sales_records",
                keyColumn: "sales_id",
                keyValue: 51);

            migrationBuilder.DeleteData(
                table: "sales_records",
                keyColumn: "sales_id",
                keyValue: 52);

            migrationBuilder.DeleteData(
                table: "sales_records",
                keyColumn: "sales_id",
                keyValue: 53);

            migrationBuilder.DeleteData(
                table: "sales_records",
                keyColumn: "sales_id",
                keyValue: 54);

            migrationBuilder.DeleteData(
                table: "sales_records",
                keyColumn: "sales_id",
                keyValue: 55);

            migrationBuilder.DeleteData(
                table: "sales_records",
                keyColumn: "sales_id",
                keyValue: 56);

            migrationBuilder.DeleteData(
                table: "sales_records",
                keyColumn: "sales_id",
                keyValue: 57);

            migrationBuilder.DeleteData(
                table: "sales_records",
                keyColumn: "sales_id",
                keyValue: 58);

            migrationBuilder.DeleteData(
                table: "sales_records",
                keyColumn: "sales_id",
                keyValue: 59);

            migrationBuilder.DeleteData(
                table: "sales_records",
                keyColumn: "sales_id",
                keyValue: 60);

            migrationBuilder.DeleteData(
                table: "sales_records",
                keyColumn: "sales_id",
                keyValue: 61);

            migrationBuilder.DeleteData(
                table: "sales_records",
                keyColumn: "sales_id",
                keyValue: 62);

            migrationBuilder.DeleteData(
                table: "sales_records",
                keyColumn: "sales_id",
                keyValue: 63);

            migrationBuilder.DeleteData(
                table: "sales_records",
                keyColumn: "sales_id",
                keyValue: 64);

            migrationBuilder.DeleteData(
                table: "sales_records",
                keyColumn: "sales_id",
                keyValue: 65);

            migrationBuilder.DeleteData(
                table: "sales_records",
                keyColumn: "sales_id",
                keyValue: 66);

            migrationBuilder.DeleteData(
                table: "sales_records",
                keyColumn: "sales_id",
                keyValue: 67);

            migrationBuilder.DeleteData(
                table: "sales_records",
                keyColumn: "sales_id",
                keyValue: 68);

            migrationBuilder.DeleteData(
                table: "sales_records",
                keyColumn: "sales_id",
                keyValue: 69);

            migrationBuilder.DeleteData(
                table: "sales_records",
                keyColumn: "sales_id",
                keyValue: 70);

            migrationBuilder.DeleteData(
                table: "sales_records",
                keyColumn: "sales_id",
                keyValue: 71);

            migrationBuilder.DeleteData(
                table: "sales_records",
                keyColumn: "sales_id",
                keyValue: 72);

            migrationBuilder.DeleteData(
                table: "sales_records",
                keyColumn: "sales_id",
                keyValue: 73);

            migrationBuilder.DeleteData(
                table: "sales_records",
                keyColumn: "sales_id",
                keyValue: 74);

            migrationBuilder.DeleteData(
                table: "sales_records",
                keyColumn: "sales_id",
                keyValue: 75);

            migrationBuilder.DeleteData(
                table: "sales_records",
                keyColumn: "sales_id",
                keyValue: 76);

            migrationBuilder.DeleteData(
                table: "sales_records",
                keyColumn: "sales_id",
                keyValue: 77);

            migrationBuilder.DeleteData(
                table: "sales_records",
                keyColumn: "sales_id",
                keyValue: 78);

            migrationBuilder.DeleteData(
                table: "sales_records",
                keyColumn: "sales_id",
                keyValue: 79);

            migrationBuilder.DeleteData(
                table: "sales_records",
                keyColumn: "sales_id",
                keyValue: 80);

            migrationBuilder.DeleteData(
                table: "sales_records",
                keyColumn: "sales_id",
                keyValue: 81);

            migrationBuilder.DeleteData(
                table: "sales_records",
                keyColumn: "sales_id",
                keyValue: 82);

            migrationBuilder.DeleteData(
                table: "sales_records",
                keyColumn: "sales_id",
                keyValue: 83);

            migrationBuilder.DeleteData(
                table: "sales_records",
                keyColumn: "sales_id",
                keyValue: 84);

            migrationBuilder.DeleteData(
                table: "sales_records",
                keyColumn: "sales_id",
                keyValue: 85);

            migrationBuilder.DeleteData(
                table: "sales_records",
                keyColumn: "sales_id",
                keyValue: 86);

            migrationBuilder.DeleteData(
                table: "sales_records",
                keyColumn: "sales_id",
                keyValue: 87);

            migrationBuilder.DeleteData(
                table: "sales_records",
                keyColumn: "sales_id",
                keyValue: 88);

            migrationBuilder.DeleteData(
                table: "sales_records",
                keyColumn: "sales_id",
                keyValue: 89);

            migrationBuilder.DeleteData(
                table: "sales_records",
                keyColumn: "sales_id",
                keyValue: 90);

            migrationBuilder.DeleteData(
                table: "sales_records",
                keyColumn: "sales_id",
                keyValue: 91);

            migrationBuilder.DeleteData(
                table: "sales_records",
                keyColumn: "sales_id",
                keyValue: 92);

            migrationBuilder.DeleteData(
                table: "sales_records",
                keyColumn: "sales_id",
                keyValue: 93);

            migrationBuilder.DeleteData(
                table: "sales_records",
                keyColumn: "sales_id",
                keyValue: 94);

            migrationBuilder.DeleteData(
                table: "sales_records",
                keyColumn: "sales_id",
                keyValue: 95);

            migrationBuilder.DeleteData(
                table: "sales_records",
                keyColumn: "sales_id",
                keyValue: 96);

            migrationBuilder.DeleteData(
                table: "sales_records",
                keyColumn: "sales_id",
                keyValue: 97);

            migrationBuilder.DeleteData(
                table: "sales_records",
                keyColumn: "sales_id",
                keyValue: 98);

            migrationBuilder.DeleteData(
                table: "sales_records",
                keyColumn: "sales_id",
                keyValue: 99);

            migrationBuilder.DeleteData(
                table: "sales_records",
                keyColumn: "sales_id",
                keyValue: 100);

            migrationBuilder.DeleteData(
                table: "sales_records",
                keyColumn: "sales_id",
                keyValue: 101);

            migrationBuilder.DeleteData(
                table: "sales_records",
                keyColumn: "sales_id",
                keyValue: 102);

            migrationBuilder.DeleteData(
                table: "sales_records",
                keyColumn: "sales_id",
                keyValue: 103);

            migrationBuilder.DeleteData(
                table: "sales_records",
                keyColumn: "sales_id",
                keyValue: 104);

            migrationBuilder.DeleteData(
                table: "sales_records",
                keyColumn: "sales_id",
                keyValue: 105);

            migrationBuilder.DeleteData(
                table: "locations",
                keyColumn: "location_id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "locations",
                keyColumn: "location_id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "locations",
                keyColumn: "location_id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "locations",
                keyColumn: "location_id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "locations",
                keyColumn: "location_id",
                keyValue: 5);
        }
    }
}
