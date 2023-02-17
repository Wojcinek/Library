using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Library.Migrations
{
    public partial class SeedData : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "b726ab77-548c-4cb5-b38c-e1724bb540fa", "4c41eb7c-3879-4e7a-abe4-43b412c47d92", "User", "USER" },
                    { "d6c64147-ce61-4b5d-8702-176871414e4c", "ecc18f9c-8c4a-4ebf-8d37-9abf28953bbc", "Admin", "ADMIN" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "FirstName", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { "8e445865-a24d-4543-a6c6-9443d048cdb8", 0, "79fcbf73-082c-4e72-8b21-d8523bae1994", "user@user.user", false, "User", "User", false, null, "USER@USER.USER", "USER@USER.USER", "AQAAAAEAACcQAAAAEAfRa6KwnzHW8m6LJyfpSu7hgWhDJMI4GzGdZAz9elrSEBCeG/sn5PKKTBlqr7YvZg==", "987654321", false, "cdc5c95a-63d0-4c03-add1-8c63858de7a1", false, "user@user.user" },
                    { "8e445865-a24d-4543-a6c6-9443d048cdb9", 0, "4f93bdfe-e955-40b9-85fc-5324a6d72b60", "admin@admin.admin", false, "Admin", "Admin", false, null, "ADMIN@ADMIN.ADMIN", "ADMIN@ADMIN.ADMIN", "AQAAAAEAACcQAAAAEJlW+JGYy+YqJH/3t22WHUrHPzZjNpTq+qvSbt4QP7L1rJ/Uvxf2gqVuqMaP2nh9yA==", "123456789", false, "9b96b856-4243-43fd-95f5-fc234e3f1919", false, "admin@admin.admin" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "b726ab77-548c-4cb5-b38c-e1724bb540fa", "8e445865-a24d-4543-a6c6-9443d048cdb8" });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "d6c64147-ce61-4b5d-8702-176871414e4c", "8e445865-a24d-4543-a6c6-9443d048cdb9" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
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

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "8e445865-a24d-4543-a6c6-9443d048cdb8");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "8e445865-a24d-4543-a6c6-9443d048cdb9");
        }
    }
}
