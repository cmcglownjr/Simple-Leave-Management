using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SimpleLeaveManagement.Web.Data.Migrations
{
    public partial class AddedRolesAndDefaultUsers : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "038bc907-bfb7-4374-8166-02c54e82a2f0", "4df5364f-8a4c-42be-96ed-a28e7d886c46", "Administrator", "ADMINISTRATOR" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "67f1b1bb-4c4a-4407-9aca-d962316403e6", "a03692ea-9c2b-49cc-8dac-adae08773518", "User", "USER" });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "DateJoined", "DateOfBirth", "Email", "EmailConfirmed", "Firstname", "Lastname", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TaxId", "TwoFactorEnabled", "UserName" },
                values: new object[] { "5fa69211-43ed-43c3-9c88-3098a1b16cdc", 0, "d1ff5ec7-b8d0-4639-bec4-d9a7ba1790f3", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "user@localhost.com", true, "System", "User", false, null, "USER@LOCALHOST.COM", "USER@LOCALHOST.COM", "AQAAAAEAACcQAAAAEMxkSTBLw9B9iYfFbiZlYeqsuHU5R104xPQcyrpdvYEDSkMHlix/z6yDbNcWbA3gww==", null, false, "51d810d4-5bb4-48b6-853e-bb50ef470467", null, false, "user@localhost.com" });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "DateJoined", "DateOfBirth", "Email", "EmailConfirmed", "Firstname", "Lastname", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TaxId", "TwoFactorEnabled", "UserName" },
                values: new object[] { "ecd519f0-a89c-4303-a487-9660982e62ec", 0, "e7d0f04f-c59e-4625-aaff-1053963665be", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "admin@localhost.com", true, "System", "Admin", false, null, "ADMIN@LOCALHOST.COM", "ADMIN@LOCALHOST.COM", "AQAAAAEAACcQAAAAELjSfUGrmzITrqQrGKswB9AbWQ2fnc1lGjNccxZvqDKiVmQCTZ9ERzL4mktmSMclzA==", null, false, "3ae0068f-8e00-463b-baa1-9b0ee30df4b0", null, false, "admin@localhost.com" });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "67f1b1bb-4c4a-4407-9aca-d962316403e6", "5fa69211-43ed-43c3-9c88-3098a1b16cdc" });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "038bc907-bfb7-4374-8166-02c54e82a2f0", "ecd519f0-a89c-4303-a487-9660982e62ec" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "67f1b1bb-4c4a-4407-9aca-d962316403e6", "5fa69211-43ed-43c3-9c88-3098a1b16cdc" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "038bc907-bfb7-4374-8166-02c54e82a2f0", "ecd519f0-a89c-4303-a487-9660982e62ec" });

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "038bc907-bfb7-4374-8166-02c54e82a2f0");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "67f1b1bb-4c4a-4407-9aca-d962316403e6");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "5fa69211-43ed-43c3-9c88-3098a1b16cdc");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "ecd519f0-a89c-4303-a487-9660982e62ec");
        }
    }
}
