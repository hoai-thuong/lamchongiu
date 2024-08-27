using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace CharityHub.Data.Migrations
{
    /// <inheritdoc />
    public partial class UpdateMoneyDataType : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: new Guid("877e6f28-4b75-40d2-81c2-0d4128e932a8"));

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { new Guid("9366193f-8ffd-4fc6-a45b-aaf14d247faa"), new Guid("3fa1de39-3502-4a91-aed2-d4b3e0500cd8") });

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: new Guid("9366193f-8ffd-4fc6-a45b-aaf14d247faa"));

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("3fa1de39-3502-4a91-aed2-d4b3e0500cd8"));

            migrationBuilder.AlterColumn<decimal>(
                name: "Amount",
                table: "Donations",
                type: "decimal(12,2)",
                nullable: false,
                oldClrType: typeof(decimal),
                oldType: "decimal(10,2)");

            migrationBuilder.AlterColumn<decimal>(
                name: "TargetAmount",
                table: "Campaigns",
                type: "decimal(12,2)",
                nullable: false,
                oldClrType: typeof(decimal),
                oldType: "decimal(10,2)");

            migrationBuilder.AlterColumn<decimal>(
                name: "CurrentAmount",
                table: "Campaigns",
                type: "decimal(12,2)",
                nullable: false,
                oldClrType: typeof(decimal),
                oldType: "decimal(10,2)");

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

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
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

            migrationBuilder.AlterColumn<decimal>(
                name: "Amount",
                table: "Donations",
                type: "decimal(10,2)",
                nullable: false,
                oldClrType: typeof(decimal),
                oldType: "decimal(12,2)");

            migrationBuilder.AlterColumn<decimal>(
                name: "TargetAmount",
                table: "Campaigns",
                type: "decimal(10,2)",
                nullable: false,
                oldClrType: typeof(decimal),
                oldType: "decimal(12,2)");

            migrationBuilder.AlterColumn<decimal>(
                name: "CurrentAmount",
                table: "Campaigns",
                type: "decimal(10,2)",
                nullable: false,
                oldClrType: typeof(decimal),
                oldType: "decimal(12,2)");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { new Guid("877e6f28-4b75-40d2-81c2-0d4128e932a8"), "877e6f28-4b75-40d2-81c2-0d4128e932a8", "User", "USER" },
                    { new Guid("9366193f-8ffd-4fc6-a45b-aaf14d247faa"), "9366193f-8ffd-4fc6-a45b-aaf14d247faa", "Admin", "ADMIN" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "DateCreated", "DisplayName", "Email", "EmailConfirmed", "IsActive", "LastLoginDate", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { new Guid("3fa1de39-3502-4a91-aed2-d4b3e0500cd8"), 0, "daca19d6-4c82-4038-8fc4-de83dc2dd07c", new DateTime(2024, 8, 25, 18, 44, 40, 601, DateTimeKind.Local).AddTicks(1015), "Dao Quoc Dat", "datdq@gmail.com", false, true, new DateTime(2024, 8, 25, 18, 44, 40, 601, DateTimeKind.Local).AddTicks(1033), false, null, "DATDQ@GMAIL.COM", "DATDQ@GMAIL.COM", "AQAAAAIAAYagAAAAEHh8sGqawexIfuJ8Sp5Hpq2CxWZoL7sFKbx3YSWY68TabRW0p78fHqUHB3BWS9oujA==", "0987654321", false, "3fa1de39-3502-4a91-aed2-d4b3e0500cd8", false, "datdq@gmail.com" });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { new Guid("9366193f-8ffd-4fc6-a45b-aaf14d247faa"), new Guid("3fa1de39-3502-4a91-aed2-d4b3e0500cd8") });
        }
    }
}
