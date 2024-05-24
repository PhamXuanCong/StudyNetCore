using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace NWZWalks.Api.Migrations
{
    /// <inheritdoc />
    public partial class Seedingdata : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Regions",
                columns: new[] { "Id", "Area", "Code", "Lat", "Long", "Name", "Population" },
                values: new object[,]
                {
                    { new Guid("42d8f71c-f6c7-465e-8236-2677caff8988"), 0.0, "12345", 0.0, 0.0, "Cong dep trai", 0L },
                    { new Guid("73176b3b-effe-434b-861a-aa0e1f4b43b1"), 0.0, "1234", 0.0, 0.0, "Cong dep trai", 0L }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: new Guid("42d8f71c-f6c7-465e-8236-2677caff8988"));

            migrationBuilder.DeleteData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: new Guid("73176b3b-effe-434b-861a-aa0e1f4b43b1"));
        }
    }
}
