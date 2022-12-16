using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Archimedes.Data.Migrations
{
    public partial class AddAppUserId : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
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

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "1",
                column: "ConcurrencyStamp",
                value: "d6b1abb1-d91d-4e67-8a1f-9edee8d43b07");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "2",
                column: "ConcurrencyStamp",
                value: "9582a8ec-a0bb-47e4-ac79-ce7a7f74fa7a");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "8e552862-a24d-4548-a6c6-9443d048cdb9",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "3cca9a0c-916e-419f-8d04-1b14f6ab2922", "AQAAAAEAACcQAAAAED/DuHah3CldV01/kDg8DAbVcxnJBrj/FGoWR8IuyIuiVKkRfnWhf9sWNjpmx1o86w==", "8eee9901-46b9-4656-ad18-e5c2c8bb8e8f" });
        }
    }
}
