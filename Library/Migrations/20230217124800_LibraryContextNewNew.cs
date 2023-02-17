using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Library.Migrations
{
    public partial class LibraryContextNewNew : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
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

            migrationBuilder.InsertData(
                table: "Books",
                columns: new[] { "ID", "Author", "BookEditionYear", "Title" },
                values: new object[,]
                {
                    { 1, "William Shakespeare", 2011, "Romeo and Juliet" },
                    { 2, "Henryk Sienkiewicz", 2002, "Quo vadis" },
                    { 3, "Henryk Sienkiewicz", 2012, "Quo vadis" },
                    { 4, "Juliusz Słowacki", 2014, "Balladyna" },
                    { 5, "Juliusz Słowacki", 2021, "Kordian" },
                    { 6, "Honoré de Balzac", 2018, "Ojciec Goriot" },
                    { 7, "Witold Gombrowicz", 2013, "Ferdydurke" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "ID",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "ID",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "ID",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "ID",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "ID",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "ID",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "ID",
                keyValue: 7);

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "2c5e174e-3b0e-446f-86af-483d56fd7210",
                column: "ConcurrencyStamp",
                value: "7d11d815-bd05-4969-aaa2-e7fbfabaa8bd");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "2c5e174e-3b0e-446f-86af-483d56fd7211",
                column: "ConcurrencyStamp",
                value: "f0d9588d-7c7b-4894-8898-ee2e286dd6a0");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "8e445865-a24d-4543-a6c6-9443d048cdb8",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "8e9f873e-64b3-4aa3-a45b-e8b351d35f2a", "AQAAAAEAACcQAAAAEKYyYR0QVCNH7fC4/W17oh+RajQZjDziGrC5w4dC115BOTvw8rrkfZrD/6hWuzDSIw==", "dd854176-af8e-4627-a6ef-64f4b2dce3d4" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "8e445865-a24d-4543-a6c6-9443d048cdb9",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "892362f8-cf0e-4770-9db0-3af998d977f8", "AQAAAAEAACcQAAAAENYD7z6x4D1zU7IkvlXJUXjN5bGGXcxP9EITfcLQus9ozUh52aKvrqFJYdA4xBgaRw==", "c58d06bf-0ab2-4e13-829b-d3a1ae781120" });
        }
    }
}
