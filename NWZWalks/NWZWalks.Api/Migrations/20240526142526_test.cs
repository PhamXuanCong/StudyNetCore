using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace NWZWalks.Api.Migrations
{
    /// <inheritdoc />
    public partial class test : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "WalkDifficulty",
                keyColumn: "Id",
                keyValue: new Guid("47acbc33-ea7f-4ea3-9892-662b1f3bd985"));

            migrationBuilder.InsertData(
                table: "WalkDifficulty",
                columns: new[] { "Id", "Code" },
                values: new object[] { new Guid("19dc39a1-6a28-4785-bf00-a045cf488f18"), "1234" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "WalkDifficulty",
                keyColumn: "Id",
                keyValue: new Guid("19dc39a1-6a28-4785-bf00-a045cf488f18"));

            migrationBuilder.InsertData(
                table: "WalkDifficulty",
                columns: new[] { "Id", "Code" },
                values: new object[] { new Guid("47acbc33-ea7f-4ea3-9892-662b1f3bd985"), "1234" });
        }
    }
}
