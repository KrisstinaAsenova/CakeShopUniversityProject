using Microsoft.EntityFrameworkCore.Migrations;

namespace _101Shop.Migrations
{
    public partial class v4 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "InStock",
                table: "Cakes");

            migrationBuilder.AddColumn<bool>(
                name: "IsSpecial",
                table: "Cakes",
                nullable: false,
                defaultValue: false);

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

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "IsSpecial",
                table: "Cakes");

            migrationBuilder.AddColumn<bool>(
                name: "InStock",
                table: "Cakes",
                type: "bit",
                nullable: false,
                defaultValue: false);

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

            migrationBuilder.UpdateData(
                table: "Cakes",
                keyColumn: "CakeId",
                keyValue: 1,
                column: "InStock",
                value: true);

            migrationBuilder.UpdateData(
                table: "Cakes",
                keyColumn: "CakeId",
                keyValue: 2,
                column: "InStock",
                value: true);

            migrationBuilder.UpdateData(
                table: "Cakes",
                keyColumn: "CakeId",
                keyValue: 3,
                column: "InStock",
                value: true);

            migrationBuilder.UpdateData(
                table: "Cakes",
                keyColumn: "CakeId",
                keyValue: 4,
                column: "InStock",
                value: true);
        }
    }
}
