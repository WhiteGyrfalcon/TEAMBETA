using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace InternetGameBlog.Data.Migrations
{
    public partial class AllowNullProfilePicture : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "ProfilePicUrl",
                table: "AspNetUsers",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "111c3195-4e75-4ea9-9f4c-7c69f3fb34c6",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "4dc5bf98-96b4-4f0d-a64d-f1001efbf2ef", "AQAAAAEAACcQAAAAEExmP0eiKHMVB2Vlg8nP+7eYrA2rJHmTOozYzadR4jUf9oSBV32c52+EXyHNTDrVHw==", "906f194b-17a5-498a-b14a-bcd458ea6361" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "16592260-d4ab-4d15-a34c-8aa894c70025",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "4d8f9ed5-e6f0-4c73-94d0-ce67b344dfd1", "AQAAAAEAACcQAAAAELBbIOgAJlOoZjZz7h2WXyj2uKq/P92djInzSJ7tdzKsEmwiAUao1OTbuIktGXxsQg==", "a7c1b009-3f68-4f57-92f3-dba906291e16" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "605e03f7-dfb6-4fdb-9f36-481520c6b714",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "79d55fe7-b1c2-4536-a17d-81a0beefd7a3", "AQAAAAEAACcQAAAAEB/YDagx6TXD120LCdLwtQyN88c3nQHXZWt8WVEkRFIqRGc9381HXWrVTZ1zpFLT+g==", "c7e21419-2d31-4246-8bd9-eec2753abaad" });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: "523c6221-c7ec-4156-973c-ef365392be01",
                column: "CreatedOn",
                value: new DateTime(2024, 1, 25, 9, 0, 26, 73, DateTimeKind.Local).AddTicks(1476));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "ProfilePicUrl",
                table: "AspNetUsers",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "111c3195-4e75-4ea9-9f4c-7c69f3fb34c6",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "102dd735-020a-435b-a000-20c151b73dc6", "AQAAAAEAACcQAAAAELSCZpS8zEFioYp1x7FtAytTJQftxjSkWReK/xHoN/D7CUf+7KKnBl06ZVFTI+X69w==", "cfef31c7-b402-4527-993c-f01ec12267e0" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "16592260-d4ab-4d15-a34c-8aa894c70025",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "09ff3a23-276d-4aa0-a1c9-15029cd9bb41", "AQAAAAEAACcQAAAAEIesvwqBYT0YxnRCg53RHKIcSYmfXm/jya8tdNjrORH4UO0spza9y1v+PhL1FS4gUg==", "0c8658d3-c5c4-4cf7-8b4e-c4ba7469cd17" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "605e03f7-dfb6-4fdb-9f36-481520c6b714",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "f1151290-e19a-49cb-988f-0c699abb9f11", "AQAAAAEAACcQAAAAEIkiNpS7HiA9MHSiETodYOQ+TqaixH+qdd4yZpEUEzuNT7U2LHlxL+jcY59hL7rfMQ==", "461374ba-2e7f-40cd-b0c5-da2cbd747e53" });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: "523c6221-c7ec-4156-973c-ef365392be01",
                column: "CreatedOn",
                value: new DateTime(2023, 12, 14, 8, 37, 56, 892, DateTimeKind.Local).AddTicks(1093));
        }
    }
}
