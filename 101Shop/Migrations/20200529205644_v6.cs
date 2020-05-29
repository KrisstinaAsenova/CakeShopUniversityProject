using Microsoft.EntityFrameworkCore.Migrations;

namespace _101Shop.Migrations
{
    public partial class v6 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Type",
                table: "AspNetUsers");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "771f568e-a7d5-496b-90c4-72ff997368e6",
                column: "ConcurrencyStamp",
                value: "ed89c5bf-fdba-4ede-9a6d-2dac11d2dbdc");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "93c66dd9-11c5-4836-b104-a9c333549530",
                column: "ConcurrencyStamp",
                value: "bfe56098-0f41-4832-9408-6d40b19054ff");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "a7b8a4da-39e4-463c-abf1-4fd486b1876d",
                column: "ConcurrencyStamp",
                value: "429f33c7-eccb-428c-8923-472b447f4deb");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "123",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "b0ac3a68-bafd-4b28-a60b-323b54f69734", "973f734a-b0bc-45ab-8db8-5e4f8561b565" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "565dfbc0-2681-4f29-bc97-a619eacf339c",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "a374d835-ebb3-4e39-84f7-6995ac1100f5", "AQAAAAEAACcQAAAAEHNXq7IKsMCVqLn8GJunheUugpt/YcGkC4tla7P69GFCD+b9NtNRpHj0jgO3hjRkeg==", "efeb68fe-e906-4feb-a9cc-dfe9ff305eb0" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "a4fe24ba-7c36-4069-a56c-6dac415b26ef",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "21aca02b-3d2a-475b-b231-d28c16e7c606", "AQAAAAEAACcQAAAAENN73zqKIoBap3hED3x1tk/JQ3zHG88b0LrCod37Nekpzro4JQb4SI19RIz/WBJ0og==", "b4077980-1bba-43fc-9703-6d0f091c0c63" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "fe86f129-41f3-4ab8-a61c-5f47239a1393",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "97cb4c3c-c12a-4dec-bad6-d078710e90be", "AQAAAAEAACcQAAAAELpm5OrZ4Oi+39gkkKoSDAxTuS6vdu2zDEdcCTFZVbbN1UbjGCecU2me5EaSUY+j9A==", "45e5e617-261f-4e68-b335-524cb01793d2" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Type",
                table: "AspNetUsers",
                type: "nvarchar(max)",
                nullable: true);

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

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "a7b8a4da-39e4-463c-abf1-4fd486b1876d",
                column: "ConcurrencyStamp",
                value: "c3c1c91d-1ff4-4c4d-a6ec-5aeb6a224503");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "123",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp", "Type" },
                values: new object[] { "27576c54-b29e-4404-a7f4-745e0e9a6c6f", "892535e4-1481-4176-b858-3133e77a05b8", "Admin" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "565dfbc0-2681-4f29-bc97-a619eacf339c",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "82ef17ac-64cf-483d-91ce-717e6a303bcc", "AQAAAAEAACcQAAAAECZjvi7rmi7mMSZCvgU0hmE7jNfWsJkJx6mEHhLcnfjq0e5bciWplud3sl9k+VfCiQ==", "fab874ec-ed68-49ed-be15-ed8ae0fc528d" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "a4fe24ba-7c36-4069-a56c-6dac415b26ef",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "415fa708-32f0-43db-a294-1092e832287c", "AQAAAAEAACcQAAAAEDfeDvPJj8v+7iiyoiiR2C45cD5RJkTxLi+pB7duBZ3i6LV09MsiZIdGFgtTd+4MDQ==", "179e0439-a95d-4818-9678-6bd9ad7e5403" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "fe86f129-41f3-4ab8-a61c-5f47239a1393",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "64967dba-5cc5-481d-9b8a-d199f7003fec", "AQAAAAEAACcQAAAAEEjDMI/gF6+jjp8smaGt0dGkD1Y3dvbBa8Fjc7cTO9w0UxqN5AWUIzXNsvhj+EBFUQ==", "7133f1b5-d00a-4b0d-a51e-8044c5503937" });
        }
    }
}
