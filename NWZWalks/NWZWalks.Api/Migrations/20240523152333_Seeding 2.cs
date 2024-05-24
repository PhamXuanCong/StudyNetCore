using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace NWZWalks.Api.Migrations
{
    /// <inheritdoc />
    public partial class Seeding2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: new Guid("42d8f71c-f6c7-465e-8236-2677caff8988"));

            migrationBuilder.DeleteData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: new Guid("73176b3b-effe-434b-861a-aa0e1f4b43b1"));

            migrationBuilder.InsertData(
                table: "Walks",
                columns: new[] { "Id", "Length", "Name", "RegionId", "WalkDifficultyId" },
                values: new object[] { new Guid("98381b5d-2d66-444b-993c-fb45ac2a8fc6"), 20.0, "CC", new Guid("9d93f2a3-6444-4d06-8ffd-09a4cf649142"), new Guid("a9c59452-c42d-4200-b509-88cd296220e5") });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Walks",
                keyColumn: "Id",
                keyValue: new Guid("98381b5d-2d66-444b-993c-fb45ac2a8fc6"));

            migrationBuilder.InsertData(
                table: "Regions",
                columns: new[] { "Id", "Area", "Code", "Lat", "Long", "Name", "Population" },
                values: new object[,]
                {
                    { new Guid("42d8f71c-f6c7-465e-8236-2677caff8988"), 0.0, "12345", 0.0, 0.0, "Cong dep trai", 0L },
                    { new Guid("73176b3b-effe-434b-861a-aa0e1f4b43b1"), 0.0, "1234", 0.0, 0.0, "Cong dep trai", 0L }
                });
        }
    }
}
