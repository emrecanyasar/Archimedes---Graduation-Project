using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Archimedes.Data.Migrations
{
    public partial class uniqueCategoryName : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "CategoryName",
                table: "Categories",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "1",
                column: "ConcurrencyStamp",
                value: "bc049884-4a36-4798-89de-f1d9a36a2c7d");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "2",
                column: "ConcurrencyStamp",
                value: "527e7f8f-bf5f-475d-be26-2331e8bbf00d");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "8e552862-a24d-4548-a6c6-9443d048cdb9",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "21de0725-211b-4436-a1c2-49accccc20b7", "AQAAAAEAACcQAAAAEO/y8YeftFhSTiSZezRAz1sPMm8769qEFbdTGGVn9L3oNKbJ97XiXn4ujqE2gpKvug==", "08e3fb7c-652d-4457-9468-dfd6f646e2f6" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "CategoryName",
                table: "Categories",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(50)",
                oldMaxLength: 50);

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "1",
                column: "ConcurrencyStamp",
                value: "2610c688-1083-4389-b5ad-53a68f82d026");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "2",
                column: "ConcurrencyStamp",
                value: "40aebf45-2bc0-40d8-a2eb-cfa242f0b4ba");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "8e552862-a24d-4548-a6c6-9443d048cdb9",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "0af741b9-3a9f-495f-a423-1a789ba69a7b", "AQAAAAEAACcQAAAAEA8H+68QzNQ8Mh7v0wY0sqgwClbawLkpgQyN6r+3IFfflgvHulzqvs/tSjpeEqDkzA==", "5a00742f-6a08-4735-9814-53ecfdd97e16" });
        }
    }
}
