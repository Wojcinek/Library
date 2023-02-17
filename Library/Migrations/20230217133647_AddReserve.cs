using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Library.Migrations
{
    public partial class AddReserve : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "2c5e174e-3b0e-446f-86af-483d56fd7210",
                column: "ConcurrencyStamp",
                value: "100ba2bd-0094-4b3e-b4dd-b6950fec8517");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "2c5e174e-3b0e-446f-86af-483d56fd7211",
                column: "ConcurrencyStamp",
                value: "c8d2921a-d3f1-4019-b8bf-3fb099b5623b");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "8e445865-a24d-4543-a6c6-9443d048cdb8",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "ed0b68fe-66bf-4995-8b21-1e77f242fcab", "AQAAAAEAACcQAAAAEHzzA9gu2o+CEMecQGP7iQEeJ1YMUqrJROIY3S115oyaLOw99asUgbKnRdi5imdIBQ==", "ac28b5d1-f049-4a5c-b094-1ee370986a5d" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "8e445865-a24d-4543-a6c6-9443d048cdb9",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "28b144b6-7780-477b-8ccb-4655b8694cb2", "AQAAAAEAACcQAAAAEIIKq39KcWf9SKdHMpKqtZYKzC1c4ogc9W64OdSNPQLTmzucTfYNetx8QYZklOYVFA==", "f435ea9f-a7e5-40d9-84d8-123ecf1b004b" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "2c5e174e-3b0e-446f-86af-483d56fd7210",
                column: "ConcurrencyStamp",
                value: "a64b2552-4178-4f7b-93db-064adfa9d231");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "2c5e174e-3b0e-446f-86af-483d56fd7211",
                column: "ConcurrencyStamp",
                value: "28be0e7e-f5a1-4ed0-b817-7e106513590b");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "8e445865-a24d-4543-a6c6-9443d048cdb8",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "f6c98538-9d8c-439d-aa8f-5404a321ebc8", "AQAAAAEAACcQAAAAEKI4vZxcNb352LXBPKqyVJD6D7e0puHf7AtyThBvyo705VWxZAZiEDYgFuEHxdKyVw==", "73561af3-f0cb-441e-9326-13e9e8520c1c" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "8e445865-a24d-4543-a6c6-9443d048cdb9",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "347b9770-cd83-429f-a84d-d36dec95b7c3", "AQAAAAEAACcQAAAAEMBWJBFEHedvGPwQbXVAhHyQAcnIDnhbakIMhoIR8KuAjcsyQE0fX5HcO6Iyr5+8Uw==", "030fecca-c2f9-4f65-928d-d066f936dc3f" });
        }
    }
}
