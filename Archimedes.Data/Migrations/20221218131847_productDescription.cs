using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Archimedes.Data.Migrations
{
    public partial class productDescription : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Description",
                table: "ShopListDetails",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "1",
                column: "ConcurrencyStamp",
                value: "9103cab9-f738-4116-bf0d-55cfd3e405f0");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "2",
                column: "ConcurrencyStamp",
                value: "0baee75d-f64e-4e3e-9a4a-c1ce5c4297ea");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "8e552862-a24d-4548-a6c6-9443d048cdb9",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "2c16dac3-3c46-4a49-ba7c-d2509f293786", "AQAAAAEAACcQAAAAEHee/QQKBWQJ6iu5/En1BQ1tQB4c/FIb0a5IfltNmDKBV2HMSMzKf8pBcTgGLwTqww==", "f4b90356-a140-4629-bb8e-df9dae165490" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Description",
                table: "ShopListDetails");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "1",
                column: "ConcurrencyStamp",
                value: "02d92dbb-c5f6-4a37-b9f0-c6ba5a0ebbe9");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "2",
                column: "ConcurrencyStamp",
                value: "45afa3ef-6e94-4564-a5ac-d9ae2d21fc8d");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "8e552862-a24d-4548-a6c6-9443d048cdb9",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "fa78caea-9439-4679-b4b6-06c771046154", "AQAAAAEAACcQAAAAEMiSPVJUGNAuZwh0O/aK05HEl7j8gfDoShMrjD7k73G2h2HQuW5XiXCGG9rcVBdByg==", "c0df4173-b306-438a-9e19-dc241025af45" });
        }
    }
}
