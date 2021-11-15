using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace AircraftAPI.DataAccess.Migrations
{
    public partial class AddedDataAnotations2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Aircrafts",
                keyColumn: "Id",
                keyValue: 1,
                column: "Date",
                value: new DateTime(2021, 11, 15, 13, 17, 35, 550, DateTimeKind.Local).AddTicks(1275));

            migrationBuilder.UpdateData(
                table: "Aircrafts",
                keyColumn: "Id",
                keyValue: 2,
                column: "Date",
                value: new DateTime(2021, 11, 15, 13, 17, 35, 550, DateTimeKind.Local).AddTicks(6191));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Aircrafts",
                keyColumn: "Id",
                keyValue: 1,
                column: "Date",
                value: new DateTime(2021, 11, 15, 13, 12, 7, 961, DateTimeKind.Local).AddTicks(1442));

            migrationBuilder.UpdateData(
                table: "Aircrafts",
                keyColumn: "Id",
                keyValue: 2,
                column: "Date",
                value: new DateTime(2021, 11, 15, 13, 12, 7, 961, DateTimeKind.Local).AddTicks(6458));
        }
    }
}
