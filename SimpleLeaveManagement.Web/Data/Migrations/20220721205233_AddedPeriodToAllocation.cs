using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SimpleLeaveManagement.Web.Data.Migrations
{
    public partial class AddedPeriodToAllocation : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "Period",
                table: "LeaveAllocations",
                type: "INTEGER",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "038bc907-bfb7-4374-8166-02c54e82a2f0",
                column: "ConcurrencyStamp",
                value: "392f7bc4-f2bc-471c-840d-de979d2909ec");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "67f1b1bb-4c4a-4407-9aca-d962316403e6",
                column: "ConcurrencyStamp",
                value: "634021ea-2012-409c-ae7e-a56216ed19ea");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "5fa69211-43ed-43c3-9c88-3098a1b16cdc",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "0a366a8b-50cf-4085-9494-312df92bf9a4", "AQAAAAEAACcQAAAAEBcfGGgeNtwibg4/J2olA4K4+MVfaSt6V6Msv0VZWq0hKWCmZQ0kXqxxiSXurF88bA==", "d41a52f9-f106-468c-8e71-8dc9cd8906d1" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "ecd519f0-a89c-4303-a487-9660982e62ec",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "70ac3251-8e74-4e35-a2d0-f53cccfdf8f3", "AQAAAAEAACcQAAAAEAKZhrcbA6NEVmG8W3qNRDakPYbF0gv/Pxcg0w7zsfpCVZivkGJJTAclrRKJEY1e8g==", "63e16840-be2e-442f-911e-2161bc610ccc" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Period",
                table: "LeaveAllocations");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "038bc907-bfb7-4374-8166-02c54e82a2f0",
                column: "ConcurrencyStamp",
                value: "4df5364f-8a4c-42be-96ed-a28e7d886c46");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "67f1b1bb-4c4a-4407-9aca-d962316403e6",
                column: "ConcurrencyStamp",
                value: "a03692ea-9c2b-49cc-8dac-adae08773518");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "5fa69211-43ed-43c3-9c88-3098a1b16cdc",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "d1ff5ec7-b8d0-4639-bec4-d9a7ba1790f3", "AQAAAAEAACcQAAAAEMxkSTBLw9B9iYfFbiZlYeqsuHU5R104xPQcyrpdvYEDSkMHlix/z6yDbNcWbA3gww==", "51d810d4-5bb4-48b6-853e-bb50ef470467" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "ecd519f0-a89c-4303-a487-9660982e62ec",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "e7d0f04f-c59e-4625-aaff-1053963665be", "AQAAAAEAACcQAAAAELjSfUGrmzITrqQrGKswB9AbWQ2fnc1lGjNccxZvqDKiVmQCTZ9ERzL4mktmSMclzA==", "3ae0068f-8e00-463b-baa1-9b0ee30df4b0" });
        }
    }
}
