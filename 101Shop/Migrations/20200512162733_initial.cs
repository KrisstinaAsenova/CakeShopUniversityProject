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

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "771f568e-a7d5-496b-90c4-72ff997368e6",
                column: "ConcurrencyStamp",
                value: "c6fcd199-bb08-4698-9c81-f84cf25a5e84");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "93c66dd9-11c5-4836-b104-a9c333549530",
                column: "ConcurrencyStamp",
                value: "0580e5f0-98b3-42f0-b38a-f9513d7c9b6d");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "123",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "1c1ec9e0-052d-42e6-be36-c245086d237f", "eb8cc652-7c71-4283-b4ff-e96b18563297" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "565dfbc0-2681-4f29-bc97-a619eacf339c",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "076d8bc6-3831-4b5b-86c4-6742e79c3180", "AQAAAAEAACcQAAAAECFAPh+NPyhHc3kc/zOcm89KVFVyQif/CNdVfjJ4Nh8aaIW0fsCGcZmmo2Odf2t73A==", "15CLJEKQCTLPRXMVXXNSWXZH6R6KJRRU" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "fe86f129-41f3-4ab8-a61c-5f47239a1393",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "e1ac18d2-7988-4e21-9a6a-bd7b749bdebb", "AQAAAAEAACcQAAAAEKAt6x4LozPO5r7hVo6rLwhx0vMB/yq5WPKNfsbFLO4Bm/tHL4MsFV4QGDPeje1ElQ==", "7I5VNHIJTSZNOT3KDWKNFUV5PVYBHGXN" });
        }
    }
}
