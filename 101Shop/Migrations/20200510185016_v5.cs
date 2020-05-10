using Microsoft.EntityFrameworkCore.Migrations;

namespace _101Shop.Migrations
{
    public partial class v5 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "123",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "2fbdaad9-c1b8-4734-a7de-7ff61a68b532", "14ef02b3-015c-46d1-a5f5-83ba0b62686b" });

            migrationBuilder.UpdateData(
                table: "Cakes",
                keyColumn: "cakeId",
                keyValue: 1,
                column: "ImageUrl",
                value: "~/images/tikva.jpg");

            migrationBuilder.UpdateData(
                table: "Cakes",
                keyColumn: "cakeId",
                keyValue: 2,
                column: "ImageUrl",
                value: "~/images/shokolad.jpg");

            migrationBuilder.UpdateData(
                table: "Cakes",
                keyColumn: "cakeId",
                keyValue: 3,
                column: "ImageUrl",
                value: "~/images/tikva.jpg");

            migrationBuilder.UpdateData(
                table: "Cakes",
                keyColumn: "cakeId",
                keyValue: 4,
                column: "ImageUrl",
                value: "~/images/shokolad.jpg");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "123",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "0d885421-9f6b-49eb-ac76-ba39b157fd36", "eebc65f9-a927-484d-a427-140fc0d18456" });

            migrationBuilder.UpdateData(
                table: "Cakes",
                keyColumn: "cakeId",
                keyValue: 1,
                column: "ImageUrl",
                value: null);

            migrationBuilder.UpdateData(
                table: "Cakes",
                keyColumn: "cakeId",
                keyValue: 2,
                column: "ImageUrl",
                value: null);

            migrationBuilder.UpdateData(
                table: "Cakes",
                keyColumn: "cakeId",
                keyValue: 3,
                column: "ImageUrl",
                value: null);

            migrationBuilder.UpdateData(
                table: "Cakes",
                keyColumn: "cakeId",
                keyValue: 4,
                column: "ImageUrl",
                value: null);
        }
    }
}
