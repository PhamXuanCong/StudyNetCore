using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace NWZWalks.Api.Migrations
{
    /// <inheritdoc />
    public partial class fakedata : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "WalkDifficulty",
                keyColumn: "Id",
                keyValue: new Guid("19dc39a1-6a28-4785-bf00-a045cf488f18"));

            migrationBuilder.DeleteData(
                table: "WalkDifficulty",
                keyColumn: "Id",
                keyValue: new Guid("98381b5d-2d66-444b-993c-fb45ac2a8fc6"));

            migrationBuilder.InsertData(
                table: "WalkDifficulty",
                columns: new[] { "Id", "Code" },
                values: new object[,]
                {
                    { new Guid("0342d4a6-c73f-416e-a05d-b05faa63d87b"), "codeName35" },
                    { new Guid("0354c9f7-f9df-47da-adc8-25bff8d7923f"), "codeName37" },
                    { new Guid("03993c45-019c-438b-be07-e015e8813677"), "codeName32" },
                    { new Guid("089df368-06cc-4932-a3bc-dda27d8726fc"), "codeName18" },
                    { new Guid("0b419edc-84c2-456a-8c22-448e0f9d370a"), "codeName14" },
                    { new Guid("18bfdc1a-3750-45f3-a9ee-8da0f86034de"), "codeName13" },
                    { new Guid("1992df25-fe79-4a31-93c0-bbe41c352727"), "codeName17" },
                    { new Guid("20a5925f-5a51-4136-8bc4-6b031449bec1"), "codeName19" },
                    { new Guid("28cec6b0-e51c-4b6d-a1d9-7f99bed4d106"), "codeName46" },
                    { new Guid("2ad6c10d-177f-4a63-a196-e0097e71d31d"), "codeName41" },
                    { new Guid("2df9e37b-ad60-4b9e-a8a3-d943c8ddf57d"), "codeName0" },
                    { new Guid("32a7d96d-7fd3-477a-ac0c-3dc5d6618cd9"), "codeName9" },
                    { new Guid("3df23f0c-e38f-4fe3-9d50-0b8483b1f5af"), "codeName4" },
                    { new Guid("5186aa69-5eaa-4120-9c0a-a0dbe4deb81a"), "codeName25" },
                    { new Guid("51b2aaf8-16be-433c-a42e-456de4a34d94"), "codeName22" },
                    { new Guid("51dc0719-90d6-4447-990d-fa615deb6b76"), "codeName15" },
                    { new Guid("531520ce-e3b6-444e-a840-6f6b89fee954"), "codeName24" },
                    { new Guid("64c944ef-2f45-4604-b05d-714527cbf794"), "codeName48" },
                    { new Guid("64e67170-33c5-41f2-b811-0e692d657dd0"), "codeName10" },
                    { new Guid("6a25231c-4465-4b58-a4f3-7891ab24959a"), "codeName49" },
                    { new Guid("6a57b417-01e7-4dc2-8bce-4250903120df"), "codeName38" },
                    { new Guid("6db2a021-2853-48cc-a651-7315f9e1f31d"), "codeName8" },
                    { new Guid("709bcb67-0cce-41ef-9342-56f6b2aed31b"), "codeName28" },
                    { new Guid("7497dc4d-cc5d-4cb3-a5ea-86bb7af85a2c"), "codeName21" },
                    { new Guid("7553afa9-e8e7-4b4a-ab5e-87317ad653cd"), "codeName11" },
                    { new Guid("7895c14c-09b5-4e75-af89-7acc301e0e2a"), "codeName3" },
                    { new Guid("7b156e16-a564-47e4-b8b4-3fb1cd0d928b"), "codeName44" },
                    { new Guid("7bafb2e3-c630-49e5-b3c1-307a051205b3"), "codeName12" },
                    { new Guid("7bec5fcb-4a27-4a34-8372-7b5f6e7a0488"), "codeName36" },
                    { new Guid("7fb26f08-3520-4d4c-a79c-5d78c74c5035"), "codeName27" },
                    { new Guid("8b99248a-59c5-4c8b-8ae8-de73a8dd0d45"), "codeName23" },
                    { new Guid("8fd89747-c83c-4fe7-a87e-f8ec660dc0d2"), "codeName6" },
                    { new Guid("9b535872-d82f-47b3-aeea-d9e9068e12c0"), "codeName7" },
                    { new Guid("9bb7b4f1-9b05-4205-8cac-52d5a5388c57"), "codeName40" },
                    { new Guid("9de22ec9-c394-4b32-b003-b68c3bbbd8ef"), "codeName29" },
                    { new Guid("a0320d6f-9443-4888-9c21-01d751f45f15"), "codeName26" },
                    { new Guid("a0f6b199-d118-484b-9ef0-906eef59401f"), "codeName20" },
                    { new Guid("a8ccc4a4-c20b-4f56-b357-af566312152d"), "codeName42" },
                    { new Guid("b365508b-8123-4194-9d08-daa94bcd15ee"), "codeName33" },
                    { new Guid("c82f864d-37e6-46e5-8d69-309b52469032"), "codeName2" },
                    { new Guid("c959409e-c464-44ae-8544-bf4f37d98ef9"), "codeName5" },
                    { new Guid("ca1e234f-b590-48c9-9a7b-a661a73656d2"), "codeName30" },
                    { new Guid("cd73c1be-b65e-448c-9984-55c427685f63"), "codeName43" },
                    { new Guid("d1d19441-ae16-4e9a-b4bc-533e1d1dbf80"), "codeName31" },
                    { new Guid("d79664ce-1617-4f47-a554-79e667fc4c97"), "codeName47" },
                    { new Guid("dae1250a-d1f4-49f7-ad12-fea7482b319b"), "codeName1" },
                    { new Guid("dce52e9a-97d5-41ba-ae7f-29306172f101"), "codeName34" },
                    { new Guid("ea92758c-3952-4e92-9018-4e79640e6678"), "codeName16" },
                    { new Guid("f23772a1-2343-48fe-886c-ecb83af74af7"), "codeName39" },
                    { new Guid("fb970037-1b30-4e58-99ee-20c1a4fe725d"), "codeName45" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "WalkDifficulty",
                keyColumn: "Id",
                keyValue: new Guid("0342d4a6-c73f-416e-a05d-b05faa63d87b"));

            migrationBuilder.DeleteData(
                table: "WalkDifficulty",
                keyColumn: "Id",
                keyValue: new Guid("0354c9f7-f9df-47da-adc8-25bff8d7923f"));

            migrationBuilder.DeleteData(
                table: "WalkDifficulty",
                keyColumn: "Id",
                keyValue: new Guid("03993c45-019c-438b-be07-e015e8813677"));

            migrationBuilder.DeleteData(
                table: "WalkDifficulty",
                keyColumn: "Id",
                keyValue: new Guid("089df368-06cc-4932-a3bc-dda27d8726fc"));

            migrationBuilder.DeleteData(
                table: "WalkDifficulty",
                keyColumn: "Id",
                keyValue: new Guid("0b419edc-84c2-456a-8c22-448e0f9d370a"));

            migrationBuilder.DeleteData(
                table: "WalkDifficulty",
                keyColumn: "Id",
                keyValue: new Guid("18bfdc1a-3750-45f3-a9ee-8da0f86034de"));

            migrationBuilder.DeleteData(
                table: "WalkDifficulty",
                keyColumn: "Id",
                keyValue: new Guid("1992df25-fe79-4a31-93c0-bbe41c352727"));

            migrationBuilder.DeleteData(
                table: "WalkDifficulty",
                keyColumn: "Id",
                keyValue: new Guid("20a5925f-5a51-4136-8bc4-6b031449bec1"));

            migrationBuilder.DeleteData(
                table: "WalkDifficulty",
                keyColumn: "Id",
                keyValue: new Guid("28cec6b0-e51c-4b6d-a1d9-7f99bed4d106"));

            migrationBuilder.DeleteData(
                table: "WalkDifficulty",
                keyColumn: "Id",
                keyValue: new Guid("2ad6c10d-177f-4a63-a196-e0097e71d31d"));

            migrationBuilder.DeleteData(
                table: "WalkDifficulty",
                keyColumn: "Id",
                keyValue: new Guid("2df9e37b-ad60-4b9e-a8a3-d943c8ddf57d"));

            migrationBuilder.DeleteData(
                table: "WalkDifficulty",
                keyColumn: "Id",
                keyValue: new Guid("32a7d96d-7fd3-477a-ac0c-3dc5d6618cd9"));

            migrationBuilder.DeleteData(
                table: "WalkDifficulty",
                keyColumn: "Id",
                keyValue: new Guid("3df23f0c-e38f-4fe3-9d50-0b8483b1f5af"));

            migrationBuilder.DeleteData(
                table: "WalkDifficulty",
                keyColumn: "Id",
                keyValue: new Guid("5186aa69-5eaa-4120-9c0a-a0dbe4deb81a"));

            migrationBuilder.DeleteData(
                table: "WalkDifficulty",
                keyColumn: "Id",
                keyValue: new Guid("51b2aaf8-16be-433c-a42e-456de4a34d94"));

            migrationBuilder.DeleteData(
                table: "WalkDifficulty",
                keyColumn: "Id",
                keyValue: new Guid("51dc0719-90d6-4447-990d-fa615deb6b76"));

            migrationBuilder.DeleteData(
                table: "WalkDifficulty",
                keyColumn: "Id",
                keyValue: new Guid("531520ce-e3b6-444e-a840-6f6b89fee954"));

            migrationBuilder.DeleteData(
                table: "WalkDifficulty",
                keyColumn: "Id",
                keyValue: new Guid("64c944ef-2f45-4604-b05d-714527cbf794"));

            migrationBuilder.DeleteData(
                table: "WalkDifficulty",
                keyColumn: "Id",
                keyValue: new Guid("64e67170-33c5-41f2-b811-0e692d657dd0"));

            migrationBuilder.DeleteData(
                table: "WalkDifficulty",
                keyColumn: "Id",
                keyValue: new Guid("6a25231c-4465-4b58-a4f3-7891ab24959a"));

            migrationBuilder.DeleteData(
                table: "WalkDifficulty",
                keyColumn: "Id",
                keyValue: new Guid("6a57b417-01e7-4dc2-8bce-4250903120df"));

            migrationBuilder.DeleteData(
                table: "WalkDifficulty",
                keyColumn: "Id",
                keyValue: new Guid("6db2a021-2853-48cc-a651-7315f9e1f31d"));

            migrationBuilder.DeleteData(
                table: "WalkDifficulty",
                keyColumn: "Id",
                keyValue: new Guid("709bcb67-0cce-41ef-9342-56f6b2aed31b"));

            migrationBuilder.DeleteData(
                table: "WalkDifficulty",
                keyColumn: "Id",
                keyValue: new Guid("7497dc4d-cc5d-4cb3-a5ea-86bb7af85a2c"));

            migrationBuilder.DeleteData(
                table: "WalkDifficulty",
                keyColumn: "Id",
                keyValue: new Guid("7553afa9-e8e7-4b4a-ab5e-87317ad653cd"));

            migrationBuilder.DeleteData(
                table: "WalkDifficulty",
                keyColumn: "Id",
                keyValue: new Guid("7895c14c-09b5-4e75-af89-7acc301e0e2a"));

            migrationBuilder.DeleteData(
                table: "WalkDifficulty",
                keyColumn: "Id",
                keyValue: new Guid("7b156e16-a564-47e4-b8b4-3fb1cd0d928b"));

            migrationBuilder.DeleteData(
                table: "WalkDifficulty",
                keyColumn: "Id",
                keyValue: new Guid("7bafb2e3-c630-49e5-b3c1-307a051205b3"));

            migrationBuilder.DeleteData(
                table: "WalkDifficulty",
                keyColumn: "Id",
                keyValue: new Guid("7bec5fcb-4a27-4a34-8372-7b5f6e7a0488"));

            migrationBuilder.DeleteData(
                table: "WalkDifficulty",
                keyColumn: "Id",
                keyValue: new Guid("7fb26f08-3520-4d4c-a79c-5d78c74c5035"));

            migrationBuilder.DeleteData(
                table: "WalkDifficulty",
                keyColumn: "Id",
                keyValue: new Guid("8b99248a-59c5-4c8b-8ae8-de73a8dd0d45"));

            migrationBuilder.DeleteData(
                table: "WalkDifficulty",
                keyColumn: "Id",
                keyValue: new Guid("8fd89747-c83c-4fe7-a87e-f8ec660dc0d2"));

            migrationBuilder.DeleteData(
                table: "WalkDifficulty",
                keyColumn: "Id",
                keyValue: new Guid("9b535872-d82f-47b3-aeea-d9e9068e12c0"));

            migrationBuilder.DeleteData(
                table: "WalkDifficulty",
                keyColumn: "Id",
                keyValue: new Guid("9bb7b4f1-9b05-4205-8cac-52d5a5388c57"));

            migrationBuilder.DeleteData(
                table: "WalkDifficulty",
                keyColumn: "Id",
                keyValue: new Guid("9de22ec9-c394-4b32-b003-b68c3bbbd8ef"));

            migrationBuilder.DeleteData(
                table: "WalkDifficulty",
                keyColumn: "Id",
                keyValue: new Guid("a0320d6f-9443-4888-9c21-01d751f45f15"));

            migrationBuilder.DeleteData(
                table: "WalkDifficulty",
                keyColumn: "Id",
                keyValue: new Guid("a0f6b199-d118-484b-9ef0-906eef59401f"));

            migrationBuilder.DeleteData(
                table: "WalkDifficulty",
                keyColumn: "Id",
                keyValue: new Guid("a8ccc4a4-c20b-4f56-b357-af566312152d"));

            migrationBuilder.DeleteData(
                table: "WalkDifficulty",
                keyColumn: "Id",
                keyValue: new Guid("b365508b-8123-4194-9d08-daa94bcd15ee"));

            migrationBuilder.DeleteData(
                table: "WalkDifficulty",
                keyColumn: "Id",
                keyValue: new Guid("c82f864d-37e6-46e5-8d69-309b52469032"));

            migrationBuilder.DeleteData(
                table: "WalkDifficulty",
                keyColumn: "Id",
                keyValue: new Guid("c959409e-c464-44ae-8544-bf4f37d98ef9"));

            migrationBuilder.DeleteData(
                table: "WalkDifficulty",
                keyColumn: "Id",
                keyValue: new Guid("ca1e234f-b590-48c9-9a7b-a661a73656d2"));

            migrationBuilder.DeleteData(
                table: "WalkDifficulty",
                keyColumn: "Id",
                keyValue: new Guid("cd73c1be-b65e-448c-9984-55c427685f63"));

            migrationBuilder.DeleteData(
                table: "WalkDifficulty",
                keyColumn: "Id",
                keyValue: new Guid("d1d19441-ae16-4e9a-b4bc-533e1d1dbf80"));

            migrationBuilder.DeleteData(
                table: "WalkDifficulty",
                keyColumn: "Id",
                keyValue: new Guid("d79664ce-1617-4f47-a554-79e667fc4c97"));

            migrationBuilder.DeleteData(
                table: "WalkDifficulty",
                keyColumn: "Id",
                keyValue: new Guid("dae1250a-d1f4-49f7-ad12-fea7482b319b"));

            migrationBuilder.DeleteData(
                table: "WalkDifficulty",
                keyColumn: "Id",
                keyValue: new Guid("dce52e9a-97d5-41ba-ae7f-29306172f101"));

            migrationBuilder.DeleteData(
                table: "WalkDifficulty",
                keyColumn: "Id",
                keyValue: new Guid("ea92758c-3952-4e92-9018-4e79640e6678"));

            migrationBuilder.DeleteData(
                table: "WalkDifficulty",
                keyColumn: "Id",
                keyValue: new Guid("f23772a1-2343-48fe-886c-ecb83af74af7"));

            migrationBuilder.DeleteData(
                table: "WalkDifficulty",
                keyColumn: "Id",
                keyValue: new Guid("fb970037-1b30-4e58-99ee-20c1a4fe725d"));

            migrationBuilder.InsertData(
                table: "WalkDifficulty",
                columns: new[] { "Id", "Code" },
                values: new object[,]
                {
                    { new Guid("19dc39a1-6a28-4785-bf00-a045cf488f18"), "1234" },
                    { new Guid("98381b5d-2d66-444b-993c-fb45ac2a8fc6"), "123" }
                });
        }
    }
}
