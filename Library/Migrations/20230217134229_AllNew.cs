using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Library.Migrations
{
    public partial class AllNew : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Reserve",
                columns: table => new
                {
                    id_rental = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Books = table.Column<int>(type: "int", nullable: false),
                    LibraryUser = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    date_from = table.Column<DateTime>(type: "date", nullable: false),
                    date_to = table.Column<DateTime>(type: "date", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Reserve", x => x.id_rental);
                    table.ForeignKey(
                        name: "FK_Reserve_AspNetUsers_LibraryUser",
                        column: x => x.LibraryUser,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Reserve_Books_Books",
                        column: x => x.Books,
                        principalTable: "Books",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "2c5e174e-3b0e-446f-86af-483d56fd7210",
                column: "ConcurrencyStamp",
                value: "3c599fd3-33e5-4576-90c0-c220b02556ef");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "2c5e174e-3b0e-446f-86af-483d56fd7211",
                column: "ConcurrencyStamp",
                value: "af721511-8485-4ce5-aa8d-65f218618b7b");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "8e445865-a24d-4543-a6c6-9443d048cdb8",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "c01906df-647e-4529-bcd3-53d239fc97cd", "AQAAAAEAACcQAAAAENdkFp+Zsa2nHW3v3stYKlpCRhVeYVjzdrVt2VYkfRAgAr19VvWLLZq9XTDZQKzpEw==", "9123f6c7-5f48-4176-a027-50c115c3672b" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "8e445865-a24d-4543-a6c6-9443d048cdb9",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "735db25f-7b0d-438f-9e40-39644d618ee5", "AQAAAAEAACcQAAAAEPCiguyTCV9zf3DIBLTlNT8oeIeAoNl7JO07I0IO2u15Z8xxgePdztb4tB2jVWIi2Q==", "635d681f-87fd-4d43-b450-4dbdfa9b4cb5" });

            migrationBuilder.CreateIndex(
                name: "IX_Reserve_Books",
                table: "Reserve",
                column: "Books");

            migrationBuilder.CreateIndex(
                name: "IX_Reserve_LibraryUser",
                table: "Reserve",
                column: "LibraryUser");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Reserve");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "2c5e174e-3b0e-446f-86af-483d56fd7210",
                column: "ConcurrencyStamp",
                value: "2e20de0f-0665-47a6-944b-1a7b8ab9db5e");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "2c5e174e-3b0e-446f-86af-483d56fd7211",
                column: "ConcurrencyStamp",
                value: "98eb36bb-866e-4979-b73a-2ea2e16479e3");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "8e445865-a24d-4543-a6c6-9443d048cdb8",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "73c3eaa8-7a0c-4908-a47a-30b55e337d4f", "AQAAAAEAACcQAAAAEEHnNL4Ilhl/ibBh04ttdNl3+AGVmAOlc4YeLgITXbfQ6G/imyNd/P8tkWUVgvZHvQ==", "13279a38-309d-409e-a120-0e80f0b87a05" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "8e445865-a24d-4543-a6c6-9443d048cdb9",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "96252f10-364c-4821-b22d-098c18124c92", "AQAAAAEAACcQAAAAEAokA0mhHwfj3ubMwMle2keBsUgzk6U+tRBr8Xod1ttjCaCuxlPRqx/NtQKZVCRLXA==", "58d2abfe-b94b-47ca-86a4-d63a963f255f" });
        }
    }
}
