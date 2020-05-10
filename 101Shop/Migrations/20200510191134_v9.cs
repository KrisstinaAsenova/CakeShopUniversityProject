using Microsoft.EntityFrameworkCore.Migrations;

namespace _101Shop.Migrations
{
    public partial class v9 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "123",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "514da16f-1522-46e7-a069-eeaf6fd28220", "395a596b-3acd-4b5a-b4ed-e083407461c8" });

            migrationBuilder.UpdateData(
                table: "Cakes",
                keyColumn: "CakeId",
                keyValue: 1,
                column: "ImageUrl",
                value: "/images/tikva.jpg");

            migrationBuilder.UpdateData(
                table: "Cakes",
                keyColumn: "CakeId",
                keyValue: 2,
                column: "ImageUrl",
                value: "/images/shokolad.jpg");

            migrationBuilder.UpdateData(
                table: "Cakes",
                keyColumn: "CakeId",
                keyValue: 4,
                column: "ImageUrl",
                value: "/images/shokolad.jpg");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "123",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "6b422204-c12f-42e5-83e1-91a964b34bdb", "c93bf5b1-b230-4e7a-983b-b868c8c0c233" });

            migrationBuilder.UpdateData(
                table: "Cakes",
                keyColumn: "CakeId",
                keyValue: 1,
                column: "ImageUrl",
                value: "~/images/tikva.jpg");

            migrationBuilder.UpdateData(
                table: "Cakes",
                keyColumn: "CakeId",
                keyValue: 2,
                column: "ImageUrl",
                value: "images/shokolad.jpg");

            migrationBuilder.UpdateData(
                table: "Cakes",
                keyColumn: "CakeId",
                keyValue: 4,
                column: "ImageUrl",
                value: "~/images/shokolad.jpg");
        }
    }
}
