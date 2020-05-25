using Microsoft.EntityFrameworkCore.Migrations;

namespace _101Shop.Migrations
{
    public partial class init2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "AddressLine1",
                table: "Orders");

            migrationBuilder.DropColumn(
                name: "AddressLine2",
                table: "Orders");

            migrationBuilder.DropColumn(
                name: "City",
                table: "Orders");

            migrationBuilder.DropColumn(
                name: "Country",
                table: "Orders");

            migrationBuilder.DropColumn(
                name: "State",
                table: "Orders");

            migrationBuilder.DropColumn(
                name: "ZipCode",
                table: "Orders");

            migrationBuilder.AddColumn<string>(
                name: "AddressLine",
                table: "Orders",
                maxLength: 100,
                nullable: false,
                defaultValue: "");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "771f568e-a7d5-496b-90c4-72ff997368e6",
                column: "ConcurrencyStamp",
                value: "78cf7ae4-af03-4056-9260-c3ae6a9fb9ae");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "93c66dd9-11c5-4836-b104-a9c333549530",
                column: "ConcurrencyStamp",
                value: "c1e9d79c-c5cc-441d-91c2-f60be1749b8c");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "123",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "b916fb33-32bb-435c-84eb-d2b7ac3458e8", "bbf54a49-14d5-4554-8ae3-10b075bc1f50" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "565dfbc0-2681-4f29-bc97-a619eacf339c",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "1e6c38c2-783d-4a36-9dd2-aab8cd56bb16", "AQAAAAEAACcQAAAAEOdiUrf0xwX93jnMnvdvM1ElWfhnFbE5kkK3lQYAaerNj1IGwvuEBxWvzHYTtwK0/Q==", "d1b279dd-788f-4d8a-a86d-c5d6c914c06f" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "fe86f129-41f3-4ab8-a61c-5f47239a1393",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "e0db9247-99d8-4467-aa88-14b090449b97", "AQAAAAEAACcQAAAAEL/BdqA1s4sh452BSR+712kpPZvfMz34MhrjgrHKSJaq5XqDXXd59UrxrHQvEGCB6A==", "3ff73c6c-a665-4395-a9f0-2891738dc9f9" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "AddressLine",
                table: "Orders");

            migrationBuilder.AddColumn<string>(
                name: "AddressLine1",
                table: "Orders",
                type: "nvarchar(100)",
                maxLength: 100,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "AddressLine2",
                table: "Orders",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "City",
                table: "Orders",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Country",
                table: "Orders",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "State",
                table: "Orders",
                type: "nvarchar(10)",
                maxLength: 10,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "ZipCode",
                table: "Orders",
                type: "nvarchar(10)",
                maxLength: 10,
                nullable: false,
                defaultValue: "");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "771f568e-a7d5-496b-90c4-72ff997368e6",
                column: "ConcurrencyStamp",
                value: "2de9c476-baae-4f54-b242-d697f61b665b");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "93c66dd9-11c5-4836-b104-a9c333549530",
                column: "ConcurrencyStamp",
                value: "da0fe6fd-2e73-459f-a997-8fad93f02da4");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "123",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "8f905db6-4607-463a-9b61-5f191c7c9616", "a44d4623-0dac-41ca-be9d-3216ff50b4be" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "565dfbc0-2681-4f29-bc97-a619eacf339c",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "a038bde7-9854-4c34-bba6-740e1f9c5d82", "AQAAAAEAACcQAAAAEGzunSJY981+qkAvxAdVILMRmxM9CSKZ5+YF7H6DPwl3CaFLciKx2EVZFSMuxsw8gg==", "4d6587b8-c9a7-4ba9-bb12-33d144761b76" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "fe86f129-41f3-4ab8-a61c-5f47239a1393",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "9d6ce619-1c1c-41d2-b572-d6b80610cc3a", "AQAAAAEAACcQAAAAENx7NFTQ24J0esdUz6W5N0rUfy7WTaDFHwC2Apl3FicqV9Jk7+TfcxlOY8f7FY4Hhw==", "73ca3518-684a-4159-8d84-5a2dd5e1c721" });
        }
    }
}
