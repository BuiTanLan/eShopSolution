using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace eShopSolution.Data.Migrations
{
    public partial class SeedIdentityUser : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateTime>(
                name: "OrderDate",
                table: "Orders",
                nullable: false,
                defaultValue: new DateTime(2020, 4, 9, 10, 11, 20, 429, DateTimeKind.Local).AddTicks(7250),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2020, 4, 6, 19, 51, 59, 901, DateTimeKind.Local).AddTicks(8529));

            migrationBuilder.InsertData(
                table: "AppRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Description", "Name", "NormalizedName" },
                values: new object[] { new Guid("b4748151-acd7-440d-a489-34434effecd9"), "a8229a07-51d1-4ecf-9072-9bfbb045ecc2", "Asministrator role", "admin", "admin" });

            migrationBuilder.InsertData(
                table: "AppUserRoles",
                columns: new[] { "UserId", "RoleId" },
                values: new object[] { new Guid("e49bf92d-feca-44fa-b121-0e1495a84ad8"), new Guid("b4748151-acd7-440d-a489-34434effecd9") });

            migrationBuilder.InsertData(
                table: "AppUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Dob", "Email", "EmailConfirmed", "FirstName", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { new Guid("e49bf92d-feca-44fa-b121-0e1495a84ad8"), 0, "33e747a1-7d0e-44b5-acd0-ba9e7fa4acf0", new DateTime(2020, 4, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), "tanlanhcmus@gmail.com", true, "Lan", "Bui Tan", false, null, "tanlanhcmus@gmail.com", "admin", "AQAAAAEAACcQAAAAEB1xR27VAU+IMjcdy7d/PIpqfiXDLLH8Zk2OwxVzTDCHHfNJXFjOi+8VcSwTQu1Xxw==", null, false, "", false, "admin" });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 1,
                column: "Status",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 2,
                column: "Status",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1,
                column: "DateCreated",
                value: new DateTime(2020, 4, 9, 10, 11, 20, 447, DateTimeKind.Local).AddTicks(3547));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AppRoles",
                keyColumn: "Id",
                keyValue: new Guid("b4748151-acd7-440d-a489-34434effecd9"));

            migrationBuilder.DeleteData(
                table: "AppUserRoles",
                keyColumns: new[] { "UserId", "RoleId" },
                keyValues: new object[] { new Guid("e49bf92d-feca-44fa-b121-0e1495a84ad8"), new Guid("b4748151-acd7-440d-a489-34434effecd9") });

            migrationBuilder.DeleteData(
                table: "AppUsers",
                keyColumn: "Id",
                keyValue: new Guid("e49bf92d-feca-44fa-b121-0e1495a84ad8"));

            migrationBuilder.AlterColumn<DateTime>(
                name: "OrderDate",
                table: "Orders",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2020, 4, 6, 19, 51, 59, 901, DateTimeKind.Local).AddTicks(8529),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2020, 4, 9, 10, 11, 20, 429, DateTimeKind.Local).AddTicks(7250));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 1,
                column: "Status",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 2,
                column: "Status",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1,
                column: "DateCreated",
                value: new DateTime(2020, 4, 6, 19, 51, 59, 922, DateTimeKind.Local).AddTicks(9520));
        }
    }
}
