using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace CharityHub.Data.Migrations
{
    /// <inheritdoc />
    public partial class InitialCreate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: new Guid("ec5ea1a3-1b9c-4143-b5cf-a89d640def2d"));

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { new Guid("e8425bd9-be85-44ff-b3c0-dff28eff7e82"), new Guid("21c6347d-2d83-437c-bf73-bcba1e66f134") });

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: new Guid("e8425bd9-be85-44ff-b3c0-dff28eff7e82"));

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("21c6347d-2d83-437c-bf73-bcba1e66f134"));

            migrationBuilder.AlterColumn<string>(
                name: "CampaignTitle",
                table: "Campaigns",
                type: "ntext",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "text");

            migrationBuilder.AlterColumn<string>(
                name: "CampaignDescription",
                table: "Campaigns",
                type: "ntext",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "text");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { new Guid("6bd2a0ae-a175-4889-91d1-2a327695e0c7"), "6bd2a0ae-a175-4889-91d1-2a327695e0c7", "Admin", "ADMIN" },
                    { new Guid("a1d9d8a6-b2eb-4459-bea5-c7492ec7d781"), "a1d9d8a6-b2eb-4459-bea5-c7492ec7d781", "User", "USER" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "DateCreated", "DisplayName", "Email", "EmailConfirmed", "IsActive", "LastLoginDate", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { new Guid("9dd34588-e1ec-48ab-a1de-e66ee77f4eb5"), 0, "e9b93784-e28f-45cc-91ab-37b89c2a6471", new DateTime(2024, 8, 27, 10, 31, 56, 298, DateTimeKind.Local).AddTicks(8800), "Dao Quoc Dat", "datdq@gmail.com", false, true, new DateTime(2024, 8, 27, 10, 31, 56, 298, DateTimeKind.Local).AddTicks(8870), false, null, "DATDQ@GMAIL.COM", "DATDQ@GMAIL.COM", "AQAAAAIAAYagAAAAENRg3Wq5mPtSbfIrdOda8t1HU/zow7G/jV+4QMbhWt8WoxoNXj+EURWKwKE3XIBltw==", "0987654321", false, "9dd34588-e1ec-48ab-a1de-e66ee77f4eb5", false, "datdq@gmail.com" });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { new Guid("6bd2a0ae-a175-4889-91d1-2a327695e0c7"), new Guid("9dd34588-e1ec-48ab-a1de-e66ee77f4eb5") });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: new Guid("a1d9d8a6-b2eb-4459-bea5-c7492ec7d781"));

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { new Guid("6bd2a0ae-a175-4889-91d1-2a327695e0c7"), new Guid("9dd34588-e1ec-48ab-a1de-e66ee77f4eb5") });

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: new Guid("6bd2a0ae-a175-4889-91d1-2a327695e0c7"));

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("9dd34588-e1ec-48ab-a1de-e66ee77f4eb5"));

            migrationBuilder.AlterColumn<string>(
                name: "CampaignTitle",
                table: "Campaigns",
                type: "text",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "ntext");

            migrationBuilder.AlterColumn<string>(
                name: "CampaignDescription",
                table: "Campaigns",
                type: "text",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "ntext");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { new Guid("e8425bd9-be85-44ff-b3c0-dff28eff7e82"), "e8425bd9-be85-44ff-b3c0-dff28eff7e82", "Admin", "ADMIN" },
                    { new Guid("ec5ea1a3-1b9c-4143-b5cf-a89d640def2d"), "ec5ea1a3-1b9c-4143-b5cf-a89d640def2d", "User", "USER" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "DateCreated", "DisplayName", "Email", "EmailConfirmed", "IsActive", "LastLoginDate", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { new Guid("21c6347d-2d83-437c-bf73-bcba1e66f134"), 0, "fe849482-561b-4554-b031-f96aba676178", new DateTime(2024, 8, 26, 4, 34, 7, 401, DateTimeKind.Local).AddTicks(6010), "Dao Quoc Dat", "datdq@gmail.com", false, true, new DateTime(2024, 8, 26, 4, 34, 7, 401, DateTimeKind.Local).AddTicks(6029), false, null, "DATDQ@GMAIL.COM", "DATDQ@GMAIL.COM", "AQAAAAIAAYagAAAAEKA+H97Ffx05V1cqGV5SfmYyjn6zZK3EOTrVU67xE9/yEYr03Zy2FwQdzl7THSTgyA==", "0987654321", false, "21c6347d-2d83-437c-bf73-bcba1e66f134", false, "datdq@gmail.com" });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { new Guid("e8425bd9-be85-44ff-b3c0-dff28eff7e82"), new Guid("21c6347d-2d83-437c-bf73-bcba1e66f134") });
        }
    }
}
