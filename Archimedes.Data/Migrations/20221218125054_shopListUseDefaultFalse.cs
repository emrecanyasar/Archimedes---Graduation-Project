using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Archimedes.Data.Migrations
{
    public partial class shopListUseDefaultFalse : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "ProductName",
                table: "Products",
                type: "nvarchar(450)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

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

            migrationBuilder.CreateIndex(
                name: "IX_Products_ProductName",
                table: "Products",
                column: "ProductName",
                unique: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IX_Products_ProductName",
                table: "Products");

            migrationBuilder.AlterColumn<string>(
                name: "ProductName",
                table: "Products",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(450)");

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
        }
    }
}
