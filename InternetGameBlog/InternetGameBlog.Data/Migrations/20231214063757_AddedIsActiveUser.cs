using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace InternetGameBlog.Data.Migrations
{
    public partial class AddedIsActiveUser : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<bool>(
                name: "IsActive",
                table: "AspNetUsers",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "111c3195-4e75-4ea9-9f4c-7c69f3fb34c6",
                columns: new[] { "ConcurrencyStamp", "IsActive", "PasswordHash", "SecurityStamp" },
                values: new object[] { "102dd735-020a-435b-a000-20c151b73dc6", true, "AQAAAAEAACcQAAAAELSCZpS8zEFioYp1x7FtAytTJQftxjSkWReK/xHoN/D7CUf+7KKnBl06ZVFTI+X69w==", "cfef31c7-b402-4527-993c-f01ec12267e0" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "16592260-d4ab-4d15-a34c-8aa894c70025",
                columns: new[] { "ConcurrencyStamp", "IsActive", "PasswordHash", "SecurityStamp" },
                values: new object[] { "09ff3a23-276d-4aa0-a1c9-15029cd9bb41", true, "AQAAAAEAACcQAAAAEIesvwqBYT0YxnRCg53RHKIcSYmfXm/jya8tdNjrORH4UO0spza9y1v+PhL1FS4gUg==", "0c8658d3-c5c4-4cf7-8b4e-c4ba7469cd17" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "605e03f7-dfb6-4fdb-9f36-481520c6b714",
                columns: new[] { "ConcurrencyStamp", "IsActive", "PasswordHash", "SecurityStamp" },
                values: new object[] { "f1151290-e19a-49cb-988f-0c699abb9f11", true, "AQAAAAEAACcQAAAAEIkiNpS7HiA9MHSiETodYOQ+TqaixH+qdd4yZpEUEzuNT7U2LHlxL+jcY59hL7rfMQ==", "461374ba-2e7f-40cd-b0c5-da2cbd747e53" });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: "523c6221-c7ec-4156-973c-ef365392be01",
                column: "CreatedOn",
                value: new DateTime(2023, 12, 14, 8, 37, 56, 892, DateTimeKind.Local).AddTicks(1093));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "IsActive",
                table: "AspNetUsers");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "111c3195-4e75-4ea9-9f4c-7c69f3fb34c6",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "44d80cdf-ce76-4daa-b17d-5b42f88ecf82", "AQAAAAEAACcQAAAAEEp4DP1jcIvt7eDH+z4SboPmYyqez7fEnn2krSMvp6daPgEWlAksOfG7/A1BDyiogA==", "772dccf8-1f86-4976-8761-a4f2cc3e3754" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "16592260-d4ab-4d15-a34c-8aa894c70025",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "827c16e8-627e-447c-a139-5f573fbe4230", "AQAAAAEAACcQAAAAEM/X6IwGmx5QskQIZZeVXje/L+rYGcLVdGfg+bHylT1QLy+rmE7TGdF0EYiTFJsu6g==", "142b6e73-0d6f-41dc-b02e-ffcb01729b8b" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "605e03f7-dfb6-4fdb-9f36-481520c6b714",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "f1fcc17d-9e10-40cd-8d2e-0a955fdc7d20", "AQAAAAEAACcQAAAAEFn3bZbqtmDfKJhACVq7JRm2Yb+5YQV5F47QEg+8IpZman6LO1NZVjpv/lBAkso04A==", "884e3986-3c36-48c4-a04a-ab84067e1d5d" });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: "523c6221-c7ec-4156-973c-ef365392be01",
                column: "CreatedOn",
                value: new DateTime(2023, 11, 23, 8, 43, 22, 218, DateTimeKind.Local).AddTicks(3433));
        }
    }
}
