using Microsoft.EntityFrameworkCore.Migrations;

namespace _101Shop.Migrations
{
    public partial class initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "771f568e-a7d5-496b-90c4-72ff997368e6",
                column: "ConcurrencyStamp",
                value: "0bedbb64-cdb7-44fb-b397-c6a284343fbb");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "93c66dd9-11c5-4836-b104-a9c333549530",
                column: "ConcurrencyStamp",
                value: "4cc4160f-7f68-4379-814f-a11c5cc46533");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "a7b8a4da-39e4-463c-abf1-4fd486b1876d",
                column: "ConcurrencyStamp",
                value: "c286f45c-76ec-408b-914f-457d8a0dd74d");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "123",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "270157b6-79e6-4be3-bf3b-d3b016cf3b4b", "4ba263af-5826-48aa-b4af-14410b6fbf50" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "565dfbc0-2681-4f29-bc97-a619eacf339c",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "bb202fa1-2358-4990-ac46-9522b8a7fa14", "AQAAAAEAACcQAAAAEFegpBsBOW0VKQ4j1XQkAsdjfwFrOIGRC373/nz/mLoZLwPOOoz9UX1yvaxi2i+O3g==", "50aa0953-2c09-4c24-9d6e-55cb85afbbd6" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "a4fe24ba-7c36-4069-a56c-6dac415b26ef",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "2e1fb04e-54f6-4394-a3f0-f9451ee1350e", "AQAAAAEAACcQAAAAEPbAua0CMS0YMdIzQqlPzyrLLUqUAdE519MrgqFV91TKIsmj/P0sSvdLsaaTlh2iiA==", "6cb23269-0eef-4af6-b73b-26babea678a4" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "fe86f129-41f3-4ab8-a61c-5f47239a1393",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "78c4a2f2-0e23-4609-a2f0-044e60d0fb90", "AQAAAAEAACcQAAAAEMC1fFVC/SQx/2Br6T0IUOUHVmcchfPsQqztOExwqC84wYLhHpbddLNaPCbtoxNRWw==", "b9f9dcb2-1451-4be5-be73-ffd5e42a272b" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "771f568e-a7d5-496b-90c4-72ff997368e6",
                column: "ConcurrencyStamp",
                value: "8dce1dba-e056-42e1-bc97-fc647a2f7275");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "93c66dd9-11c5-4836-b104-a9c333549530",
                column: "ConcurrencyStamp",
                value: "f49750ed-deb6-4154-8d36-6cb9f16628f4");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "a7b8a4da-39e4-463c-abf1-4fd486b1876d",
                column: "ConcurrencyStamp",
                value: "622febab-b097-4e7e-bdfb-8d5c614dcb30");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "123",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "897977eb-4911-4926-95b2-28e6d1fe7661", "6e3db578-77a1-4f44-97b1-3e4a0faf07a5" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "565dfbc0-2681-4f29-bc97-a619eacf339c",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "86126767-0a97-4566-821d-d8caa1a88106", "AQAAAAEAACcQAAAAELF7Gx99mV4FMrp/Xyny7L+xgDBXg2L89O42/eHklWjoYaZO+Nvz3e20Gww6w76WmA==", "c78b1e72-a2dd-4b6f-b44f-fafcd3a32b1f" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "a4fe24ba-7c36-4069-a56c-6dac415b26ef",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "376e1d8c-8dad-4a27-9984-cbee5f852c7f", "AQAAAAEAACcQAAAAEIhtozuIkRAe5ZAXad390OnAd4znR1puk1r8bWJWytdIP6ulAltJx7D8B7ChzIxrrA==", "72b96b03-7876-4749-9be5-72f376be8f1e" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "fe86f129-41f3-4ab8-a61c-5f47239a1393",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "81b9bd7a-9b14-45eb-9505-0e098db0b39f", "AQAAAAEAACcQAAAAELzLZOt9emG/wDGLHdk29Ndiur56AVGq8IzrCujwiZe13qWvAVQ5CQpKVKAo8LmCVQ==", "c976c6ac-e8fc-416d-b2b9-497c135d1130" });
        }
    }
}
