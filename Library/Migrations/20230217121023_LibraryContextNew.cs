using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Library.Migrations
{
    public partial class LibraryContextNew : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "b726ab77-548c-4cb5-b38c-e1724bb540fa", "8e445865-a24d-4543-a6c6-9443d048cdb8" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "d6c64147-ce61-4b5d-8702-176871414e4c", "8e445865-a24d-4543-a6c6-9443d048cdb9" });

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "b726ab77-548c-4cb5-b38c-e1724bb540fa");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "d6c64147-ce61-4b5d-8702-176871414e4c");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "2c5e174e-3b0e-446f-86af-483d56fd7210", "7d11d815-bd05-4969-aaa2-e7fbfabaa8bd", "Admin", "ADMIN" },
                    { "2c5e174e-3b0e-446f-86af-483d56fd7211", "f0d9588d-7c7b-4894-8898-ee2e286dd6a0", "User", "USER" }
                });

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

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "2c5e174e-3b0e-446f-86af-483d56fd7211", "8e445865-a24d-4543-a6c6-9443d048cdb8" });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "2c5e174e-3b0e-446f-86af-483d56fd7210", "8e445865-a24d-4543-a6c6-9443d048cdb9" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "2c5e174e-3b0e-446f-86af-483d56fd7211", "8e445865-a24d-4543-a6c6-9443d048cdb8" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "2c5e174e-3b0e-446f-86af-483d56fd7210", "8e445865-a24d-4543-a6c6-9443d048cdb9" });

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "2c5e174e-3b0e-446f-86af-483d56fd7210");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "2c5e174e-3b0e-446f-86af-483d56fd7211");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "b726ab77-548c-4cb5-b38c-e1724bb540fa", "4c41eb7c-3879-4e7a-abe4-43b412c47d92", "User", "USER" },
                    { "d6c64147-ce61-4b5d-8702-176871414e4c", "ecc18f9c-8c4a-4ebf-8d37-9abf28953bbc", "Admin", "ADMIN" }
                });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "8e445865-a24d-4543-a6c6-9443d048cdb8",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "79fcbf73-082c-4e72-8b21-d8523bae1994", "AQAAAAEAACcQAAAAEAfRa6KwnzHW8m6LJyfpSu7hgWhDJMI4GzGdZAz9elrSEBCeG/sn5PKKTBlqr7YvZg==", "cdc5c95a-63d0-4c03-add1-8c63858de7a1" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "8e445865-a24d-4543-a6c6-9443d048cdb9",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "4f93bdfe-e955-40b9-85fc-5324a6d72b60", "AQAAAAEAACcQAAAAEJlW+JGYy+YqJH/3t22WHUrHPzZjNpTq+qvSbt4QP7L1rJ/Uvxf2gqVuqMaP2nh9yA==", "9b96b856-4243-43fd-95f5-fc234e3f1919" });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "b726ab77-548c-4cb5-b38c-e1724bb540fa", "8e445865-a24d-4543-a6c6-9443d048cdb8" });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "d6c64147-ce61-4b5d-8702-176871414e4c", "8e445865-a24d-4543-a6c6-9443d048cdb9" });
        }
    }
}
