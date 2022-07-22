using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SimpleLeaveManagement.Web.Data.Migrations
{
    public partial class AddedLeaveRequest : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "LeaveRequests",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    StartDate = table.Column<DateTime>(type: "TEXT", nullable: false),
                    EndDate = table.Column<DateTime>(type: "TEXT", nullable: false),
                    LeaveTypeId = table.Column<int>(type: "INTEGER", nullable: false),
                    DateRequested = table.Column<DateTime>(type: "TEXT", nullable: false),
                    RequestComments = table.Column<string>(type: "TEXT", nullable: true),
                    Approved = table.Column<bool>(type: "INTEGER", nullable: true),
                    Cancelled = table.Column<bool>(type: "INTEGER", nullable: false),
                    RequestingEmployeeId = table.Column<string>(type: "TEXT", nullable: false),
                    DateCreated = table.Column<DateTime>(type: "TEXT", nullable: false),
                    DateModified = table.Column<DateTime>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_LeaveRequests", x => x.Id);
                    table.ForeignKey(
                        name: "FK_LeaveRequests_LeaveTypes_LeaveTypeId",
                        column: x => x.LeaveTypeId,
                        principalTable: "LeaveTypes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "038bc907-bfb7-4374-8166-02c54e82a2f0",
                column: "ConcurrencyStamp",
                value: "fd43d203-d48e-43f1-9b9e-af4c074b1fa3");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "67f1b1bb-4c4a-4407-9aca-d962316403e6",
                column: "ConcurrencyStamp",
                value: "ab267231-26ce-49ac-8142-143ed6a1b7dc");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "5fa69211-43ed-43c3-9c88-3098a1b16cdc",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "ff50ed2c-8659-494b-9a01-622d6cc8bc80", "AQAAAAEAACcQAAAAEDaeHKXkGs/7XoRwqGCNZGgisDdquRgt7Xb/G2C4TQTura0dkc07T3izzwZK5L7ItA==", "8b37b59d-098c-4c1f-b851-a87182e64c13" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "ecd519f0-a89c-4303-a487-9660982e62ec",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "3b7824e7-ead1-4be9-9585-316e2088e833", "AQAAAAEAACcQAAAAEMD3O38yKgwsdwQYsFM8k4SWw2m58BUQfV9hxV08zbKGjm+xUcA+sZFGD3etH/n2TQ==", "14363c9b-5586-431f-96c6-b8e9d56f2a0b" });

            migrationBuilder.CreateIndex(
                name: "IX_LeaveRequests_LeaveTypeId",
                table: "LeaveRequests",
                column: "LeaveTypeId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "LeaveRequests");

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
    }
}
