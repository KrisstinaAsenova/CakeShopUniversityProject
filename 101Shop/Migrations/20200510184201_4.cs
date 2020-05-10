using Microsoft.EntityFrameworkCore.Migrations;

namespace _101Shop.Migrations
{
    public partial class _4 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_OrderDetails_cakes_cakeId",
                table: "OrderDetails");

            migrationBuilder.DropForeignKey(
                name: "FK_ShoppingCartItems_cakes_cakeId",
                table: "ShoppingCartItems");

            migrationBuilder.DropPrimaryKey(
                name: "PK_cakes",
                table: "cakes");

            migrationBuilder.RenameTable(
                name: "cakes",
                newName: "Cakes");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Cakes",
                table: "Cakes",
                column: "cakeId");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "123",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "0d885421-9f6b-49eb-ac76-ba39b157fd36", "eebc65f9-a927-484d-a427-140fc0d18456" });

            migrationBuilder.AddForeignKey(
                name: "FK_OrderDetails_Cakes_cakeId",
                table: "OrderDetails",
                column: "cakeId",
                principalTable: "Cakes",
                principalColumn: "cakeId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_ShoppingCartItems_Cakes_cakeId",
                table: "ShoppingCartItems",
                column: "cakeId",
                principalTable: "Cakes",
                principalColumn: "cakeId",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_OrderDetails_Cakes_cakeId",
                table: "OrderDetails");

            migrationBuilder.DropForeignKey(
                name: "FK_ShoppingCartItems_Cakes_cakeId",
                table: "ShoppingCartItems");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Cakes",
                table: "Cakes");

            migrationBuilder.RenameTable(
                name: "Cakes",
                newName: "cakes");

            migrationBuilder.AddPrimaryKey(
                name: "PK_cakes",
                table: "cakes",
                column: "cakeId");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "123",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "dffbe939-638b-499d-bf5c-db857d435279", "1968be12-196f-4ff9-9ba2-cb4ae9766acd" });

            migrationBuilder.AddForeignKey(
                name: "FK_OrderDetails_cakes_cakeId",
                table: "OrderDetails",
                column: "cakeId",
                principalTable: "cakes",
                principalColumn: "cakeId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_ShoppingCartItems_cakes_cakeId",
                table: "ShoppingCartItems",
                column: "cakeId",
                principalTable: "cakes",
                principalColumn: "cakeId",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
