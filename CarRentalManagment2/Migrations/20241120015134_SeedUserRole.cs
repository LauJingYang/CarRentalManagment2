using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace CarRentalManagment2.Migrations
{
    /// <inheritdoc />
    public partial class SeedUserRole : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "FirstName",
                table: "AspNetUsers",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "LastName",
                table: "AspNetUsers",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "ad2bcf0c-20db-474f-8407-5a6b159518ba", null, "Administrator", "ADMINISTRATOR" },
                    { "bd2bcf0c-20db-474f-8407-5a6b159518bb", null, "User", "USER" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "FirstName", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { "3781efa7-66dc-47f0-860f-e506d04102e4", 0, "f5b84e25-117a-43c9-8ce4-11850d14b3c7", "admin@localhost.com", true, "Admin", "User", false, null, "ADMIN@LOCALHOST.COM", "ADMIN@LOCALHOST.COM", "AQAAAAIAAYagAAAAEMLhDjkaUu+JW8KFDCUv0avLEHkjQxcMma/fXohBZ1PfYzCWowsgb09q3KJ/31YEdA==", null, false, "7b7b8cea-4e7e-44aa-8d66-617cdbbba5a7", false, "admin@localhost.com" });

            migrationBuilder.UpdateData(
                table: "Colour",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 11, 20, 9, 51, 33, 541, DateTimeKind.Local).AddTicks(1048), new DateTime(2024, 11, 20, 9, 51, 33, 541, DateTimeKind.Local).AddTicks(1058) });

            migrationBuilder.UpdateData(
                table: "Colour",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 11, 20, 9, 51, 33, 541, DateTimeKind.Local).AddTicks(1059), new DateTime(2024, 11, 20, 9, 51, 33, 541, DateTimeKind.Local).AddTicks(1060) });

            migrationBuilder.UpdateData(
                table: "Make",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 11, 20, 9, 51, 33, 541, DateTimeKind.Local).AddTicks(1272), new DateTime(2024, 11, 20, 9, 51, 33, 541, DateTimeKind.Local).AddTicks(1273) });

            migrationBuilder.UpdateData(
                table: "Make",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 11, 20, 9, 51, 33, 541, DateTimeKind.Local).AddTicks(1274), new DateTime(2024, 11, 20, 9, 51, 33, 541, DateTimeKind.Local).AddTicks(1274) });

            migrationBuilder.UpdateData(
                table: "Model",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 11, 20, 9, 51, 33, 541, DateTimeKind.Local).AddTicks(1368), new DateTime(2024, 11, 20, 9, 51, 33, 541, DateTimeKind.Local).AddTicks(1369) });

            migrationBuilder.UpdateData(
                table: "Model",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 11, 20, 9, 51, 33, 541, DateTimeKind.Local).AddTicks(1370), new DateTime(2024, 11, 20, 9, 51, 33, 541, DateTimeKind.Local).AddTicks(1370) });

            migrationBuilder.UpdateData(
                table: "Model",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 11, 20, 9, 51, 33, 541, DateTimeKind.Local).AddTicks(1372), new DateTime(2024, 11, 20, 9, 51, 33, 541, DateTimeKind.Local).AddTicks(1372) });

            migrationBuilder.UpdateData(
                table: "Model",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 11, 20, 9, 51, 33, 541, DateTimeKind.Local).AddTicks(1373), new DateTime(2024, 11, 20, 9, 51, 33, 541, DateTimeKind.Local).AddTicks(1374) });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "ad2bcf0c-20db-474f-8407-5a6b159518ba", "3781efa7-66dc-47f0-860f-e506d04102e4" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "bd2bcf0c-20db-474f-8407-5a6b159518bb");

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "ad2bcf0c-20db-474f-8407-5a6b159518ba", "3781efa7-66dc-47f0-860f-e506d04102e4" });

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "ad2bcf0c-20db-474f-8407-5a6b159518ba");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3781efa7-66dc-47f0-860f-e506d04102e4");

            migrationBuilder.DropColumn(
                name: "FirstName",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "LastName",
                table: "AspNetUsers");

            migrationBuilder.UpdateData(
                table: "Colour",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 11, 18, 17, 11, 1, 456, DateTimeKind.Local).AddTicks(9672), new DateTime(2024, 11, 18, 17, 11, 1, 456, DateTimeKind.Local).AddTicks(9685) });

            migrationBuilder.UpdateData(
                table: "Colour",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 11, 18, 17, 11, 1, 456, DateTimeKind.Local).AddTicks(9691), new DateTime(2024, 11, 18, 17, 11, 1, 456, DateTimeKind.Local).AddTicks(9692) });

            migrationBuilder.UpdateData(
                table: "Make",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 11, 18, 17, 11, 1, 457, DateTimeKind.Local).AddTicks(1910), new DateTime(2024, 11, 18, 17, 11, 1, 457, DateTimeKind.Local).AddTicks(1929) });

            migrationBuilder.UpdateData(
                table: "Make",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 11, 18, 17, 11, 1, 457, DateTimeKind.Local).AddTicks(1935), new DateTime(2024, 11, 18, 17, 11, 1, 457, DateTimeKind.Local).AddTicks(1937) });

            migrationBuilder.UpdateData(
                table: "Model",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 11, 18, 17, 11, 1, 457, DateTimeKind.Local).AddTicks(2343), new DateTime(2024, 11, 18, 17, 11, 1, 457, DateTimeKind.Local).AddTicks(2345) });

            migrationBuilder.UpdateData(
                table: "Model",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 11, 18, 17, 11, 1, 457, DateTimeKind.Local).AddTicks(2350), new DateTime(2024, 11, 18, 17, 11, 1, 457, DateTimeKind.Local).AddTicks(2352) });

            migrationBuilder.UpdateData(
                table: "Model",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 11, 18, 17, 11, 1, 457, DateTimeKind.Local).AddTicks(2356), new DateTime(2024, 11, 18, 17, 11, 1, 457, DateTimeKind.Local).AddTicks(2358) });

            migrationBuilder.UpdateData(
                table: "Model",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 11, 18, 17, 11, 1, 457, DateTimeKind.Local).AddTicks(2363), new DateTime(2024, 11, 18, 17, 11, 1, 457, DateTimeKind.Local).AddTicks(2365) });
        }
    }
}
