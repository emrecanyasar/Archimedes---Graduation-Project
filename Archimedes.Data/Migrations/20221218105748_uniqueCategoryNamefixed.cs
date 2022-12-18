using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Archimedes.Data.Migrations
{
    public partial class uniqueCategoryNamefixed : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "CategoryName",
                table: "Categories",
                type: "nvarchar(450)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(50)",
                oldMaxLength: 50);

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "1",
                column: "ConcurrencyStamp",
                value: "d765b672-f436-42c8-bccd-50073d649014");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "2",
                column: "ConcurrencyStamp",
                value: "4f9e8510-e29b-4ae5-8a2f-b4b0f8878cd8");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "8e552862-a24d-4548-a6c6-9443d048cdb9",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "4c0299aa-a4ff-45a7-be66-94fd74e91a8c", "AQAAAAEAACcQAAAAEI4yPNLA0/oEalMy6Eg6zMzux/q9dQpkZc8Q6VPz4paezW/4gVQxJ5Aw3P8llSrkSA==", "46ddbe0b-afe6-4ff5-beef-760e8953db9b" });

            migrationBuilder.CreateIndex(
                name: "IX_Categories_CategoryName",
                table: "Categories",
                column: "CategoryName",
                unique: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IX_Categories_CategoryName",
                table: "Categories");

            migrationBuilder.AlterColumn<string>(
                name: "CategoryName",
                table: "Categories",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(450)");

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
    }
}
