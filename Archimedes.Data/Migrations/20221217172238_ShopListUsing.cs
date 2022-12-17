using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Archimedes.Data.Migrations
{
    public partial class ShopListUsing : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
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

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Use",
                table: "ShopListDetails");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "1",
                column: "ConcurrencyStamp",
                value: "7cb72bc8-43f1-44fc-82d4-179952f75589");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "2",
                column: "ConcurrencyStamp",
                value: "218efbac-105d-4d82-abf5-a31111cfdcc1");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "8e552862-a24d-4548-a6c6-9443d048cdb9",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "2e23aae9-7245-437d-bf4b-741a8ddaf233", "AQAAAAEAACcQAAAAENQCOk+RXmTcoYc5e1mDfHGiAVD6Ie8gAKVXQGmkOqtSDZrfVXWv9qYqG4VrxjtIsg==", "c33b55f2-b035-435f-a08a-938aba58cc2c" });
        }
    }
}
