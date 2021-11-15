using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace AircraftAPI.DataAccess.Migrations
{
    public partial class AddedDataAnotations1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "DateTime",
                table: "Aircrafts",
                newName: "Date");

            migrationBuilder.AlterColumn<string>(
                name: "Location",
                table: "Aircrafts",
                type: "nvarchar(255)",
                maxLength: 255,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(128)",
                oldMaxLength: 128,
                oldNullable: true);

            migrationBuilder.UpdateData(
                table: "Aircrafts",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Date", "Registration" },
                values: new object[] { new DateTime(2021, 11, 15, 13, 12, 7, 961, DateTimeKind.Local).AddTicks(1442), "G-RNAC" });

            migrationBuilder.UpdateData(
                table: "Aircrafts",
                keyColumn: "Id",
                keyValue: 2,
                column: "Date",
                value: new DateTime(2021, 11, 15, 13, 12, 7, 961, DateTimeKind.Local).AddTicks(6458));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Date",
                table: "Aircrafts",
                newName: "DateTime");

            migrationBuilder.AlterColumn<string>(
                name: "Location",
                table: "Aircrafts",
                type: "nvarchar(128)",
                maxLength: 128,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(255)",
                oldMaxLength: 255,
                oldNullable: true);

            migrationBuilder.UpdateData(
                table: "Aircrafts",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateTime", "Registration" },
                values: new object[] { new DateTime(2021, 11, 10, 13, 4, 1, 575, DateTimeKind.Local).AddTicks(6944), "G-RNAC”" });

            migrationBuilder.UpdateData(
                table: "Aircrafts",
                keyColumn: "Id",
                keyValue: 2,
                column: "DateTime",
                value: new DateTime(2021, 11, 10, 13, 4, 1, 576, DateTimeKind.Local).AddTicks(3912));
        }
    }
}
