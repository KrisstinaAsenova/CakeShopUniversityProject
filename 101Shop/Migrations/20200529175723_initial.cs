using Microsoft.EntityFrameworkCore.Migrations;

namespace _101Shop.Migrations
{
    public partial class initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_OrderDetails_Cakes_cakeId",
                table: "OrderDetails");

            migrationBuilder.RenameColumn(
                name: "cakeId",
                table: "OrderDetails",
                newName: "CakeId");

            migrationBuilder.RenameIndex(
                name: "IX_OrderDetails_cakeId",
                table: "OrderDetails",
                newName: "IX_OrderDetails_CakeId");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "771f568e-a7d5-496b-90c4-72ff997368e6",
                column: "ConcurrencyStamp",
                value: "c8ea55ad-6dc2-4568-9b85-35bccfc17c96");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "93c66dd9-11c5-4836-b104-a9c333549530",
                column: "ConcurrencyStamp",
                value: "4d2a7da3-4f5d-4d7b-a0bd-4960122b2010");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "123",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "8dde2a92-a07b-47e8-bd55-dd47b071203c", "fa50f7ca-e956-4899-8edf-1d21b8372785" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "565dfbc0-2681-4f29-bc97-a619eacf339c",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "02d9d130-c0f7-4388-8cb2-05b933c9a8a9", "AQAAAAEAACcQAAAAEHxuMgIr4GlnYH0C5B1Qm4y09eM+qfW00MNMRKnswAP26g+fXVk5dCv3AgzgOsb/JQ==", "fdb66701-9cc0-4c44-a47a-e03974902ce6" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "fe86f129-41f3-4ab8-a61c-5f47239a1393",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "8a062aa6-322c-4027-9ae8-ae05d3a1f1e8", "AQAAAAEAACcQAAAAEGavU8xDgjLmqQQUG3EbG7p2bfvJKFUWuWwOopYC2jB6LyzxrERIjPKWNaSYuxOFOw==", "25914e69-a470-4639-a112-49833b72aaa3" });

            migrationBuilder.AddForeignKey(
                name: "FK_OrderDetails_Cakes_CakeId",
                table: "OrderDetails",
                column: "CakeId",
                principalTable: "Cakes",
                principalColumn: "CakeId",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_OrderDetails_Cakes_CakeId",
                table: "OrderDetails");

            migrationBuilder.RenameColumn(
                name: "CakeId",
                table: "OrderDetails",
                newName: "cakeId");

            migrationBuilder.RenameIndex(
                name: "IX_OrderDetails_CakeId",
                table: "OrderDetails",
                newName: "IX_OrderDetails_cakeId");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "771f568e-a7d5-496b-90c4-72ff997368e6",
                column: "ConcurrencyStamp",
                value: "86eba4c1-90ac-4c18-a4bc-700b12503a57");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "93c66dd9-11c5-4836-b104-a9c333549530",
                column: "ConcurrencyStamp",
                value: "9b61e4b5-4d4c-4482-9d1e-c713c482c21e");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "123",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "b57969d5-f488-41af-b915-ba5d9ab77d5c", "0d02e4e3-20f1-4f8c-bfdd-7c123eb77e8b" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "565dfbc0-2681-4f29-bc97-a619eacf339c",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "bf4cbd85-5acc-47e0-8d13-3a59c5421d09", "AQAAAAEAACcQAAAAECJ6EgsW//4yWrmmee/3yUi6WQ6u20b7Syl5MhlSqER/Q6x4ItRk6qGb9Q+pLBwBpg==", "daa6a7ce-6a44-42fb-9ba4-262a8b3f5ae5" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "fe86f129-41f3-4ab8-a61c-5f47239a1393",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "7eb9afd6-57aa-4c88-bb40-481554f08e8e", "AQAAAAEAACcQAAAAEBj+PO/wnvA3T3erfshhFRXJXM0P9USc2osLbyeXsTuvpJ86XM34sj0FzvxGCB2Y2A==", "eaaeb8a7-3aa1-4d0e-bcc1-4b949a600c59" });

            migrationBuilder.AddForeignKey(
                name: "FK_OrderDetails_Cakes_cakeId",
                table: "OrderDetails",
                column: "cakeId",
                principalTable: "Cakes",
                principalColumn: "CakeId",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
