using Microsoft.EntityFrameworkCore.Migrations;

namespace _101Shop.Migrations
{
    public partial class v6 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ShoppingCartItems_Cakes_cakeId",
                table: "ShoppingCartItems");

            migrationBuilder.RenameColumn(
                name: "cakeId",
                table: "ShoppingCartItems",
                newName: "CakeId");

            migrationBuilder.RenameIndex(
                name: "IX_ShoppingCartItems_cakeId",
                table: "ShoppingCartItems",
                newName: "IX_ShoppingCartItems_CakeId");

            migrationBuilder.RenameColumn(
                name: "cakeId",
                table: "Cakes",
                newName: "CakeId");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "123",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "63f95d15-f032-433f-98d6-e88b141e3d74", "4182b9e9-f3b7-44ec-bdde-8b262e515bdb" });

            migrationBuilder.AddForeignKey(
                name: "FK_ShoppingCartItems_Cakes_CakeId",
                table: "ShoppingCartItems",
                column: "CakeId",
                principalTable: "Cakes",
                principalColumn: "CakeId",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ShoppingCartItems_Cakes_CakeId",
                table: "ShoppingCartItems");

            migrationBuilder.RenameColumn(
                name: "CakeId",
                table: "ShoppingCartItems",
                newName: "cakeId");

            migrationBuilder.RenameIndex(
                name: "IX_ShoppingCartItems_CakeId",
                table: "ShoppingCartItems",
                newName: "IX_ShoppingCartItems_cakeId");

            migrationBuilder.RenameColumn(
                name: "CakeId",
                table: "Cakes",
                newName: "cakeId");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "123",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "2fbdaad9-c1b8-4734-a7de-7ff61a68b532", "14ef02b3-015c-46d1-a5f5-83ba0b62686b" });

            migrationBuilder.AddForeignKey(
                name: "FK_ShoppingCartItems_Cakes_cakeId",
                table: "ShoppingCartItems",
                column: "cakeId",
                principalTable: "Cakes",
                principalColumn: "cakeId",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
