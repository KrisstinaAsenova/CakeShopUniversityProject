using Microsoft.EntityFrameworkCore.Migrations;

namespace _101Shop.Migrations
{
    public partial class initial7 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "771f568e-a7d5-496b-90c4-72ff997368e6", "c6fcd199-bb08-4698-9c81-f84cf25a5e84", "Admin", "ADMIN" },
                    { "93c66dd9-11c5-4836-b104-a9c333549530", "0580e5f0-98b3-42f0-b38a-f9513d7c9b6d", "Cook", "COOK" }
                });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "123",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "1c1ec9e0-052d-42e6-be36-c245086d237f", "eb8cc652-7c71-4283-b4ff-e96b18563297" });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "Type", "UserName" },
                values: new object[,]
                {
                    { "fe86f129-41f3-4ab8-a61c-5f47239a1393", 0, "e1ac18d2-7988-4e21-9a6a-bd7b749bdebb", "admin@gmail.com", false, true, null, "ADMIN@GMAIL.COM", "ADMIN", "AQAAAAEAACcQAAAAEKAt6x4LozPO5r7hVo6rLwhx0vMB/yq5WPKNfsbFLO4Bm/tHL4MsFV4QGDPeje1ElQ==", null, false, "7I5VNHIJTSZNOT3KDWKNFUV5PVYBHGXN", false, null, "admin" },
                    { "565dfbc0-2681-4f29-bc97-a619eacf339c", 0, "076d8bc6-3831-4b5b-86c4-6742e79c3180", "cook@gmail.com", false, true, null, "COOK@GMAIL.COM", "COOK", "AQAAAAEAACcQAAAAECFAPh+NPyhHc3kc/zOcm89KVFVyQif/CNdVfjJ4Nh8aaIW0fsCGcZmmo2Odf2t73A==", null, false, "15CLJEKQCTLPRXMVXXNSWXZH6R6KJRRU", false, null, "cook" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "UserId", "RoleId" },
                values: new object[] { "fe86f129-41f3-4ab8-a61c-5f47239a1393", "771f568e-a7d5-496b-90c4-72ff997368e6" });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "UserId", "RoleId" },
                values: new object[] { "565dfbc0-2681-4f29-bc97-a619eacf339c", "771f568e-a7d5-496b-90c4-72ff997368e6" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "93c66dd9-11c5-4836-b104-a9c333549530");

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "UserId", "RoleId" },
                keyValues: new object[] { "565dfbc0-2681-4f29-bc97-a619eacf339c", "771f568e-a7d5-496b-90c4-72ff997368e6" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "UserId", "RoleId" },
                keyValues: new object[] { "fe86f129-41f3-4ab8-a61c-5f47239a1393", "771f568e-a7d5-496b-90c4-72ff997368e6" });

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "771f568e-a7d5-496b-90c4-72ff997368e6");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "565dfbc0-2681-4f29-bc97-a619eacf339c");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "fe86f129-41f3-4ab8-a61c-5f47239a1393");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "123",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "e7f64b18-f2fd-41e4-a556-6022be33dcf2", "1b89b4a1-08cc-433b-8a0c-848f3f90a2ad" });
        }
    }
}
