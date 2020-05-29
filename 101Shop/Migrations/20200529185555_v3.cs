using Microsoft.EntityFrameworkCore.Migrations;

namespace _101Shop.Migrations
{
    public partial class v3 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "771f568e-a7d5-496b-90c4-72ff997368e6",
                column: "ConcurrencyStamp",
                value: "f1bac7d4-86d3-41eb-9a57-25c77cdca494");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "93c66dd9-11c5-4836-b104-a9c333549530",
                column: "ConcurrencyStamp",
                value: "8867d955-56fc-41a0-ba73-2ec5b58c2db8");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "123",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "2dfa2a1b-d990-47c2-8900-3b337e5e7323", "a6bdf6e8-371d-4ddb-9752-a8c32653aec0" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "565dfbc0-2681-4f29-bc97-a619eacf339c",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "c4c7e51d-4c06-42cc-bd45-c66ced2c55f4", "AQAAAAEAACcQAAAAEDCeROYt5VR7UwdOpJjgS4bnVgCERA2ulayepxz0Bak0JJ+WKzLzygq4UkdGRIdajg==", "f909c6bc-8341-4dd2-afd3-a8b89eef5499" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "fe86f129-41f3-4ab8-a61c-5f47239a1393",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "bcba7ee0-7ca8-4525-aedd-f6b9356f45b3", "AQAAAAEAACcQAAAAEEy911w44hmWwY3dToEplSMzcSYXPNIJ9OSsSn+YKx+3h2zBSPsrc9NQBNSeJMJlBg==", "338b2c94-7b75-4e91-916e-5c12faaf07c1" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
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
        }
    }
}
