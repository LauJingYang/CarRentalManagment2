using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace CarRentalManagment2.Migrations
{
    /// <inheritdoc />
    public partial class SeedData : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Colour",
                columns: new[] { "Id", "CreatedBy", "DateCreated", "DateUpdated", "Name", "UpdatedBy" },
                values: new object[,]
                {
                    { 1, "System", new DateTime(2024, 11, 18, 16, 42, 4, 244, DateTimeKind.Local).AddTicks(8740), new DateTime(2024, 11, 18, 16, 42, 4, 244, DateTimeKind.Local).AddTicks(8749), "Black", "System" },
                    { 2, "System", new DateTime(2024, 11, 18, 16, 42, 4, 244, DateTimeKind.Local).AddTicks(8751), new DateTime(2024, 11, 18, 16, 42, 4, 244, DateTimeKind.Local).AddTicks(8751), "Blue", "System" }
                });

            migrationBuilder.InsertData(
                table: "Make",
                columns: new[] { "Id", "CreatedBy", "DateCreated", "DateUpdated", "Name", "UpdatedBy" },
                values: new object[,]
                {
                    { 1, "System", new DateTime(2024, 11, 18, 16, 42, 4, 244, DateTimeKind.Local).AddTicks(9004), new DateTime(2024, 11, 18, 16, 42, 4, 244, DateTimeKind.Local).AddTicks(9004), "BMW", "System" },
                    { 2, "System", new DateTime(2024, 11, 18, 16, 42, 4, 244, DateTimeKind.Local).AddTicks(9006), new DateTime(2024, 11, 18, 16, 42, 4, 244, DateTimeKind.Local).AddTicks(9006), "Toyota", "System" }
                });

            migrationBuilder.InsertData(
                table: "Model",
                columns: new[] { "Id", "CreatedBy", "DateCreated", "DateUpdated", "Name", "UpdatedBy" },
                values: new object[,]
                {
                    { 1, "System", new DateTime(2024, 11, 18, 16, 42, 4, 244, DateTimeKind.Local).AddTicks(9216), new DateTime(2024, 11, 18, 16, 42, 4, 244, DateTimeKind.Local).AddTicks(9217), "i4", "System" },
                    { 2, "System", new DateTime(2024, 11, 18, 16, 42, 4, 244, DateTimeKind.Local).AddTicks(9218), new DateTime(2024, 11, 18, 16, 42, 4, 244, DateTimeKind.Local).AddTicks(9219), "X5", "System" },
                    { 3, "System", new DateTime(2024, 11, 18, 16, 42, 4, 244, DateTimeKind.Local).AddTicks(9220), new DateTime(2024, 11, 18, 16, 42, 4, 244, DateTimeKind.Local).AddTicks(9220), "Prius", "System" },
                    { 4, "System", new DateTime(2024, 11, 18, 16, 42, 4, 244, DateTimeKind.Local).AddTicks(9221), new DateTime(2024, 11, 18, 16, 42, 4, 244, DateTimeKind.Local).AddTicks(9222), "C-HR", "System" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Colour",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Colour",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Make",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Make",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Model",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Model",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Model",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Model",
                keyColumn: "Id",
                keyValue: 4);
        }
    }
}
