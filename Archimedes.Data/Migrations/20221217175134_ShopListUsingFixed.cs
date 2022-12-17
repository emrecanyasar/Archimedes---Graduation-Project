using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Archimedes.Data.Migrations
{
    public partial class ShopListUsingFixed : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Use",
                table: "ShopListDetails");

            migrationBuilder.AddColumn<bool>(
                name: "Use",
                table: "ShopLists",
                type: "bit",
                nullable: false,
                defaultValue: false);

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

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Use",
                table: "ShopLists");

            migrationBuilder.AddColumn<bool>(
                name: "Use",
                table: "ShopListDetails",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "1",
                column: "ConcurrencyStamp",
                value: "c4f93774-1cf8-4c3e-9591-12db0349b576");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "2",
                column: "ConcurrencyStamp",
                value: "bc0022af-9a17-4e80-a6b9-70232ee12bb0");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "8e552862-a24d-4548-a6c6-9443d048cdb9",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "c7b723b1-f159-4784-bf3e-a00081cd72da", "AQAAAAEAACcQAAAAECO43kNSOlAGweroPqbYjWMX+um42JTke+KIhJp8FQ4YA+l88ZkXegS7Sp2k4zthXQ==", "5023548b-fffc-4ff1-a8df-ec6bbcc13547" });
        }
    }
}
