using Microsoft.EntityFrameworkCore.Migrations;

namespace _101Shop.Migrations
{
    public partial class v5 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "UserId", "RoleId" },
                keyValues: new object[] { "565dfbc0-2681-4f29-bc97-a619eacf339c", "771f568e-a7d5-496b-90c4-72ff997368e6" });

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "771f568e-a7d5-496b-90c4-72ff997368e6",
                column: "ConcurrencyStamp",
                value: "91da6fde-2999-47a7-b700-49786eaf4255");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "93c66dd9-11c5-4836-b104-a9c333549530",
                column: "ConcurrencyStamp",
                value: "88baf7c1-0f46-439c-800c-da9bd43ac344");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "a7b8a4da-39e4-463c-abf1-4fd486b1876d", "c3c1c91d-1ff4-4c4d-a6ec-5aeb6a224503", "Delivery", "DELIVERY" });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "UserId", "RoleId" },
                values: new object[] { "565dfbc0-2681-4f29-bc97-a619eacf339c", "93c66dd9-11c5-4836-b104-a9c333549530" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "123",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "27576c54-b29e-4404-a7f4-745e0e9a6c6f", "892535e4-1481-4176-b858-3133e77a05b8" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "565dfbc0-2681-4f29-bc97-a619eacf339c",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "82ef17ac-64cf-483d-91ce-717e6a303bcc", "AQAAAAEAACcQAAAAECZjvi7rmi7mMSZCvgU0hmE7jNfWsJkJx6mEHhLcnfjq0e5bciWplud3sl9k+VfCiQ==", "fab874ec-ed68-49ed-be15-ed8ae0fc528d" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "fe86f129-41f3-4ab8-a61c-5f47239a1393",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "64967dba-5cc5-481d-9b8a-d199f7003fec", "AQAAAAEAACcQAAAAEEjDMI/gF6+jjp8smaGt0dGkD1Y3dvbBa8Fjc7cTO9w0UxqN5AWUIzXNsvhj+EBFUQ==", "7133f1b5-d00a-4b0d-a51e-8044c5503937" });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "Type", "UserName" },
                values: new object[] { "a4fe24ba-7c36-4069-a56c-6dac415b26ef", 0, "415fa708-32f0-43db-a294-1092e832287c", "delivery@gmail.com", false, true, null, "DELIVERY@GMAIL.COM", "DELIVERY", "AQAAAAEAACcQAAAAEDfeDvPJj8v+7iiyoiiR2C45cD5RJkTxLi+pB7duBZ3i6LV09MsiZIdGFgtTd+4MDQ==", null, false, "179e0439-a95d-4818-9678-6bd9ad7e5403", false, null, "delivery" });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "UserId", "RoleId" },
                values: new object[] { "a4fe24ba-7c36-4069-a56c-6dac415b26ef", "a7b8a4da-39e4-463c-abf1-4fd486b1876d" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "UserId", "RoleId" },
                keyValues: new object[] { "565dfbc0-2681-4f29-bc97-a619eacf339c", "93c66dd9-11c5-4836-b104-a9c333549530" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "UserId", "RoleId" },
                keyValues: new object[] { "a4fe24ba-7c36-4069-a56c-6dac415b26ef", "a7b8a4da-39e4-463c-abf1-4fd486b1876d" });

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "a7b8a4da-39e4-463c-abf1-4fd486b1876d");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "a4fe24ba-7c36-4069-a56c-6dac415b26ef");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "771f568e-a7d5-496b-90c4-72ff997368e6",
                column: "ConcurrencyStamp",
                value: "dbd57802-862c-4037-8fca-a7aa49d74d7b");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "93c66dd9-11c5-4836-b104-a9c333549530",
                column: "ConcurrencyStamp",
                value: "7ec1d787-e8e2-457e-8341-c65ebea80af3");

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "UserId", "RoleId" },
                values: new object[] { "565dfbc0-2681-4f29-bc97-a619eacf339c", "771f568e-a7d5-496b-90c4-72ff997368e6" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "123",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "0fbd4565-58b6-4300-ad62-2e3705e079cf", "c9b58224-8e6f-42f8-94d2-a028191a9830" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "565dfbc0-2681-4f29-bc97-a619eacf339c",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "7bba399e-b6c1-458c-951c-31dd1c3d7491", "AQAAAAEAACcQAAAAEP8KiLGiAOXRMQYfu50sIzkyIJnu6B0oirZ5VETKC6YkhHka8yYaXr40Kyo61g5thA==", "277333c9-d300-4e57-953a-17bb665dc941" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "fe86f129-41f3-4ab8-a61c-5f47239a1393",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "53e6fa41-5500-4fc1-b842-4347bf68d782", "AQAAAAEAACcQAAAAEBKgDZCKQzXO5KS0debRIFSQD8PyPtAX1F3s7K81HmJ6OJzR4yBGNeSz6RbveUw09A==", "d612427d-beee-4b50-a3d2-5a869f20be13" });
        }
    }
}
