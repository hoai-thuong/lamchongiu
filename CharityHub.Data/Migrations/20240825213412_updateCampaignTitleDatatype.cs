using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace CharityHub.Data.Migrations
{
    /// <inheritdoc />
    public partial class updateCampaignTitleDatatype : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: new Guid("873fc61c-b5f8-46a7-96d8-f5b9e3228d21"));

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { new Guid("3adf5142-aebc-485d-9c4e-5d8ffdc09b46"), new Guid("67f792ad-dae0-4572-91fa-eefbe9708fa3") });

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: new Guid("3adf5142-aebc-485d-9c4e-5d8ffdc09b46"));

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("67f792ad-dae0-4572-91fa-eefbe9708fa3"));

            migrationBuilder.AlterColumn<string>(
                name: "CampaignTitle",
                table: "Campaigns",
                type: "text",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(100)",
                oldMaxLength: 100);

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

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
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
                type: "nvarchar(100)",
                maxLength: 100,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "text");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { new Guid("3adf5142-aebc-485d-9c4e-5d8ffdc09b46"), "3adf5142-aebc-485d-9c4e-5d8ffdc09b46", "Admin", "ADMIN" },
                    { new Guid("873fc61c-b5f8-46a7-96d8-f5b9e3228d21"), "873fc61c-b5f8-46a7-96d8-f5b9e3228d21", "User", "USER" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "DateCreated", "DisplayName", "Email", "EmailConfirmed", "IsActive", "LastLoginDate", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { new Guid("67f792ad-dae0-4572-91fa-eefbe9708fa3"), 0, "f6da9ca5-1840-4502-838e-5da97aa09b88", new DateTime(2024, 8, 26, 3, 43, 15, 610, DateTimeKind.Local).AddTicks(966), "Dao Quoc Dat", "datdq@gmail.com", false, true, new DateTime(2024, 8, 26, 3, 43, 15, 610, DateTimeKind.Local).AddTicks(984), false, null, "DATDQ@GMAIL.COM", "DATDQ@GMAIL.COM", "AQAAAAIAAYagAAAAENRA8VNbNK8dRl5onpiswRXplqT+WGpwoCQnfigPM1TgFwGq8kohESDJWa98VYkCJw==", "0987654321", false, "67f792ad-dae0-4572-91fa-eefbe9708fa3", false, "datdq@gmail.com" });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { new Guid("3adf5142-aebc-485d-9c4e-5d8ffdc09b46"), new Guid("67f792ad-dae0-4572-91fa-eefbe9708fa3") });
        }
    }
}
