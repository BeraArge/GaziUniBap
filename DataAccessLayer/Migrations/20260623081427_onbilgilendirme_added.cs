using System;
using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

namespace DataAccessLayer.Migrations
{
    /// <inheritdoc />
    public partial class onbilgilendirme_added : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "FullName",
                table: "Users");

            migrationBuilder.CreateTable(
                name: "OnBilgilendirmes",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    OnBilgilendirmeMetni = table.Column<string>(type: "text", nullable: true),
                    CreatedAt = table.Column<DateTime>(type: "timestamp without time zone", nullable: true),
                    UpdatedAt = table.Column<DateTime>(type: "timestamp without time zone", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_OnBilgilendirmes", x => x.Id);
                });

            migrationBuilder.UpdateData(
                table: "ModuleRoles",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 6, 23, 11, 14, 26, 926, DateTimeKind.Local).AddTicks(3489), new DateTime(2026, 6, 23, 11, 14, 26, 926, DateTimeKind.Local).AddTicks(3489) });

            migrationBuilder.UpdateData(
                table: "ModuleRoles",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 6, 23, 11, 14, 26, 926, DateTimeKind.Local).AddTicks(3491), new DateTime(2026, 6, 23, 11, 14, 26, 926, DateTimeKind.Local).AddTicks(3492) });

            migrationBuilder.UpdateData(
                table: "ModuleRoles",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 6, 23, 11, 14, 26, 926, DateTimeKind.Local).AddTicks(3493), new DateTime(2026, 6, 23, 11, 14, 26, 926, DateTimeKind.Local).AddTicks(3494) });

            migrationBuilder.UpdateData(
                table: "ModuleRoles",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 6, 23, 11, 14, 26, 926, DateTimeKind.Local).AddTicks(3495), new DateTime(2026, 6, 23, 11, 14, 26, 926, DateTimeKind.Local).AddTicks(3495) });

            migrationBuilder.UpdateData(
                table: "ModuleRoles",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 6, 23, 11, 14, 26, 926, DateTimeKind.Local).AddTicks(3496), new DateTime(2026, 6, 23, 11, 14, 26, 926, DateTimeKind.Local).AddTicks(3497) });

            migrationBuilder.UpdateData(
                table: "ModuleRoles",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 6, 23, 11, 14, 26, 926, DateTimeKind.Local).AddTicks(3498), new DateTime(2026, 6, 23, 11, 14, 26, 926, DateTimeKind.Local).AddTicks(3499) });

            migrationBuilder.UpdateData(
                table: "ModuleRoles",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 6, 23, 11, 14, 26, 926, DateTimeKind.Local).AddTicks(3500), new DateTime(2026, 6, 23, 11, 14, 26, 926, DateTimeKind.Local).AddTicks(3501) });

            migrationBuilder.UpdateData(
                table: "ModuleRoles",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 6, 23, 11, 14, 26, 926, DateTimeKind.Local).AddTicks(3502), new DateTime(2026, 6, 23, 11, 14, 26, 926, DateTimeKind.Local).AddTicks(3503) });

            migrationBuilder.UpdateData(
                table: "ModuleRoles",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 6, 23, 11, 14, 26, 926, DateTimeKind.Local).AddTicks(3504), new DateTime(2026, 6, 23, 11, 14, 26, 926, DateTimeKind.Local).AddTicks(3504) });

            migrationBuilder.UpdateData(
                table: "ModuleRoles",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 6, 23, 11, 14, 26, 926, DateTimeKind.Local).AddTicks(3505), new DateTime(2026, 6, 23, 11, 14, 26, 926, DateTimeKind.Local).AddTicks(3506) });

            migrationBuilder.UpdateData(
                table: "ModuleRoles",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 6, 23, 11, 14, 26, 926, DateTimeKind.Local).AddTicks(3507), new DateTime(2026, 6, 23, 11, 14, 26, 926, DateTimeKind.Local).AddTicks(3507) });

            migrationBuilder.UpdateData(
                table: "ModuleRoles",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 6, 23, 11, 14, 26, 926, DateTimeKind.Local).AddTicks(3508), new DateTime(2026, 6, 23, 11, 14, 26, 926, DateTimeKind.Local).AddTicks(3509) });

            migrationBuilder.UpdateData(
                table: "ModuleRoles",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 6, 23, 11, 14, 26, 926, DateTimeKind.Local).AddTicks(3510), new DateTime(2026, 6, 23, 11, 14, 26, 926, DateTimeKind.Local).AddTicks(3511) });

            migrationBuilder.UpdateData(
                table: "ModuleRoles",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 6, 23, 11, 14, 26, 926, DateTimeKind.Local).AddTicks(3512), new DateTime(2026, 6, 23, 11, 14, 26, 926, DateTimeKind.Local).AddTicks(3512) });

            migrationBuilder.UpdateData(
                table: "ModuleRoles",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 6, 23, 11, 14, 26, 926, DateTimeKind.Local).AddTicks(3513), new DateTime(2026, 6, 23, 11, 14, 26, 926, DateTimeKind.Local).AddTicks(3514) });

            migrationBuilder.UpdateData(
                table: "ModuleRoles",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 6, 23, 11, 14, 26, 926, DateTimeKind.Local).AddTicks(3516), new DateTime(2026, 6, 23, 11, 14, 26, 926, DateTimeKind.Local).AddTicks(3517) });

            migrationBuilder.UpdateData(
                table: "ModuleRoles",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 6, 23, 11, 14, 26, 926, DateTimeKind.Local).AddTicks(3518), new DateTime(2026, 6, 23, 11, 14, 26, 926, DateTimeKind.Local).AddTicks(3518) });

            migrationBuilder.UpdateData(
                table: "ModuleRoles",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 6, 23, 11, 14, 26, 926, DateTimeKind.Local).AddTicks(3519), new DateTime(2026, 6, 23, 11, 14, 26, 926, DateTimeKind.Local).AddTicks(3520) });

            migrationBuilder.UpdateData(
                table: "ModuleRoles",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 6, 23, 11, 14, 26, 926, DateTimeKind.Local).AddTicks(3521), new DateTime(2026, 6, 23, 11, 14, 26, 926, DateTimeKind.Local).AddTicks(3522) });

            migrationBuilder.UpdateData(
                table: "ModuleRoles",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 6, 23, 11, 14, 26, 926, DateTimeKind.Local).AddTicks(3523), new DateTime(2026, 6, 23, 11, 14, 26, 926, DateTimeKind.Local).AddTicks(3523) });

            migrationBuilder.UpdateData(
                table: "ModuleRoles",
                keyColumn: "Id",
                keyValue: 21,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 6, 23, 11, 14, 26, 926, DateTimeKind.Local).AddTicks(3524), new DateTime(2026, 6, 23, 11, 14, 26, 926, DateTimeKind.Local).AddTicks(3525) });

            migrationBuilder.UpdateData(
                table: "ModuleRoles",
                keyColumn: "Id",
                keyValue: 22,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 6, 23, 11, 14, 26, 926, DateTimeKind.Local).AddTicks(3526), new DateTime(2026, 6, 23, 11, 14, 26, 926, DateTimeKind.Local).AddTicks(3526) });

            migrationBuilder.UpdateData(
                table: "ModuleRoles",
                keyColumn: "Id",
                keyValue: 23,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 6, 23, 11, 14, 26, 926, DateTimeKind.Local).AddTicks(3527), new DateTime(2026, 6, 23, 11, 14, 26, 926, DateTimeKind.Local).AddTicks(3528) });

            migrationBuilder.UpdateData(
                table: "ModuleRoles",
                keyColumn: "Id",
                keyValue: 24,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 6, 23, 11, 14, 26, 926, DateTimeKind.Local).AddTicks(3529), new DateTime(2026, 6, 23, 11, 14, 26, 926, DateTimeKind.Local).AddTicks(3530) });

            migrationBuilder.UpdateData(
                table: "ModuleRoles",
                keyColumn: "Id",
                keyValue: 25,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 6, 23, 11, 14, 26, 926, DateTimeKind.Local).AddTicks(3531), new DateTime(2026, 6, 23, 11, 14, 26, 926, DateTimeKind.Local).AddTicks(3531) });

            migrationBuilder.UpdateData(
                table: "ModuleRoles",
                keyColumn: "Id",
                keyValue: 26,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 6, 23, 11, 14, 26, 926, DateTimeKind.Local).AddTicks(3532), new DateTime(2026, 6, 23, 11, 14, 26, 926, DateTimeKind.Local).AddTicks(3533) });

            migrationBuilder.UpdateData(
                table: "ModuleRoles",
                keyColumn: "Id",
                keyValue: 27,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 6, 23, 11, 14, 26, 926, DateTimeKind.Local).AddTicks(3534), new DateTime(2026, 6, 23, 11, 14, 26, 926, DateTimeKind.Local).AddTicks(3534) });

            migrationBuilder.UpdateData(
                table: "ModuleRoles",
                keyColumn: "Id",
                keyValue: 28,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 6, 23, 11, 14, 26, 926, DateTimeKind.Local).AddTicks(3535), new DateTime(2026, 6, 23, 11, 14, 26, 926, DateTimeKind.Local).AddTicks(3536) });

            migrationBuilder.UpdateData(
                table: "Modules",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 6, 23, 11, 14, 26, 926, DateTimeKind.Local).AddTicks(3294), new DateTime(2026, 6, 23, 11, 14, 26, 926, DateTimeKind.Local).AddTicks(3296) });

            migrationBuilder.UpdateData(
                table: "Modules",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 6, 23, 11, 14, 26, 926, DateTimeKind.Local).AddTicks(3299), new DateTime(2026, 6, 23, 11, 14, 26, 926, DateTimeKind.Local).AddTicks(3299) });

            migrationBuilder.UpdateData(
                table: "Modules",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 6, 23, 11, 14, 26, 926, DateTimeKind.Local).AddTicks(3301), new DateTime(2026, 6, 23, 11, 14, 26, 926, DateTimeKind.Local).AddTicks(3302) });

            migrationBuilder.UpdateData(
                table: "Modules",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 6, 23, 11, 14, 26, 926, DateTimeKind.Local).AddTicks(3303), new DateTime(2026, 6, 23, 11, 14, 26, 926, DateTimeKind.Local).AddTicks(3304) });

            migrationBuilder.UpdateData(
                table: "Modules",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 6, 23, 11, 14, 26, 926, DateTimeKind.Local).AddTicks(3306), new DateTime(2026, 6, 23, 11, 14, 26, 926, DateTimeKind.Local).AddTicks(3306) });

            migrationBuilder.UpdateData(
                table: "Modules",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 6, 23, 11, 14, 26, 926, DateTimeKind.Local).AddTicks(3308), new DateTime(2026, 6, 23, 11, 14, 26, 926, DateTimeKind.Local).AddTicks(3308) });

            migrationBuilder.UpdateData(
                table: "Modules",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 6, 23, 11, 14, 26, 926, DateTimeKind.Local).AddTicks(3310), new DateTime(2026, 6, 23, 11, 14, 26, 926, DateTimeKind.Local).AddTicks(3311) });

            migrationBuilder.UpdateData(
                table: "Modules",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 6, 23, 11, 14, 26, 926, DateTimeKind.Local).AddTicks(3313), new DateTime(2026, 6, 23, 11, 14, 26, 926, DateTimeKind.Local).AddTicks(3314) });

            migrationBuilder.UpdateData(
                table: "Modules",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 6, 23, 11, 14, 26, 926, DateTimeKind.Local).AddTicks(3316), new DateTime(2026, 6, 23, 11, 14, 26, 926, DateTimeKind.Local).AddTicks(3316) });

            migrationBuilder.UpdateData(
                table: "Modules",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 6, 23, 11, 14, 26, 926, DateTimeKind.Local).AddTicks(3318), new DateTime(2026, 6, 23, 11, 14, 26, 926, DateTimeKind.Local).AddTicks(3318) });

            migrationBuilder.UpdateData(
                table: "Modules",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 6, 23, 11, 14, 26, 926, DateTimeKind.Local).AddTicks(3320), new DateTime(2026, 6, 23, 11, 14, 26, 926, DateTimeKind.Local).AddTicks(3320) });

            migrationBuilder.UpdateData(
                table: "Modules",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 6, 23, 11, 14, 26, 926, DateTimeKind.Local).AddTicks(3322), new DateTime(2026, 6, 23, 11, 14, 26, 926, DateTimeKind.Local).AddTicks(3323) });

            migrationBuilder.UpdateData(
                table: "Modules",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 6, 23, 11, 14, 26, 926, DateTimeKind.Local).AddTicks(3324), new DateTime(2026, 6, 23, 11, 14, 26, 926, DateTimeKind.Local).AddTicks(3325) });

            migrationBuilder.UpdateData(
                table: "Modules",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 6, 23, 11, 14, 26, 926, DateTimeKind.Local).AddTicks(3326), new DateTime(2026, 6, 23, 11, 14, 26, 926, DateTimeKind.Local).AddTicks(3327) });

            migrationBuilder.UpdateData(
                table: "Modules",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 6, 23, 11, 14, 26, 926, DateTimeKind.Local).AddTicks(3328), new DateTime(2026, 6, 23, 11, 14, 26, 926, DateTimeKind.Local).AddTicks(3329) });

            migrationBuilder.UpdateData(
                table: "Modules",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 6, 23, 11, 14, 26, 926, DateTimeKind.Local).AddTicks(3330), new DateTime(2026, 6, 23, 11, 14, 26, 926, DateTimeKind.Local).AddTicks(3331) });

            migrationBuilder.UpdateData(
                table: "Modules",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 6, 23, 11, 14, 26, 926, DateTimeKind.Local).AddTicks(3333), new DateTime(2026, 6, 23, 11, 14, 26, 926, DateTimeKind.Local).AddTicks(3334) });

            migrationBuilder.UpdateData(
                table: "Modules",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 6, 23, 11, 14, 26, 926, DateTimeKind.Local).AddTicks(3335), new DateTime(2026, 6, 23, 11, 14, 26, 926, DateTimeKind.Local).AddTicks(3335) });

            migrationBuilder.UpdateData(
                table: "Modules",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 6, 23, 11, 14, 26, 926, DateTimeKind.Local).AddTicks(3337), new DateTime(2026, 6, 23, 11, 14, 26, 926, DateTimeKind.Local).AddTicks(3337) });

            migrationBuilder.UpdateData(
                table: "Modules",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 6, 23, 11, 14, 26, 926, DateTimeKind.Local).AddTicks(3339), new DateTime(2026, 6, 23, 11, 14, 26, 926, DateTimeKind.Local).AddTicks(3340) });

            migrationBuilder.UpdateData(
                table: "Modules",
                keyColumn: "Id",
                keyValue: 21,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 6, 23, 11, 14, 26, 926, DateTimeKind.Local).AddTicks(3341), new DateTime(2026, 6, 23, 11, 14, 26, 926, DateTimeKind.Local).AddTicks(3342) });

            migrationBuilder.UpdateData(
                table: "Modules",
                keyColumn: "Id",
                keyValue: 22,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 6, 23, 11, 14, 26, 926, DateTimeKind.Local).AddTicks(3343), new DateTime(2026, 6, 23, 11, 14, 26, 926, DateTimeKind.Local).AddTicks(3344) });

            migrationBuilder.UpdateData(
                table: "Modules",
                keyColumn: "Id",
                keyValue: 23,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 6, 23, 11, 14, 26, 926, DateTimeKind.Local).AddTicks(3444), new DateTime(2026, 6, 23, 11, 14, 26, 926, DateTimeKind.Local).AddTicks(3445) });

            migrationBuilder.UpdateData(
                table: "Modules",
                keyColumn: "Id",
                keyValue: 24,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 6, 23, 11, 14, 26, 926, DateTimeKind.Local).AddTicks(3446), new DateTime(2026, 6, 23, 11, 14, 26, 926, DateTimeKind.Local).AddTicks(3447) });

            migrationBuilder.UpdateData(
                table: "Modules",
                keyColumn: "Id",
                keyValue: 25,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 6, 23, 11, 14, 26, 926, DateTimeKind.Local).AddTicks(3448), new DateTime(2026, 6, 23, 11, 14, 26, 926, DateTimeKind.Local).AddTicks(3449) });

            migrationBuilder.UpdateData(
                table: "Modules",
                keyColumn: "Id",
                keyValue: 26,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 6, 23, 11, 14, 26, 926, DateTimeKind.Local).AddTicks(3451), new DateTime(2026, 6, 23, 11, 14, 26, 926, DateTimeKind.Local).AddTicks(3451) });

            migrationBuilder.UpdateData(
                table: "Modules",
                keyColumn: "Id",
                keyValue: 27,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 6, 23, 11, 14, 26, 926, DateTimeKind.Local).AddTicks(3453), new DateTime(2026, 6, 23, 11, 14, 26, 926, DateTimeKind.Local).AddTicks(3453) });

            migrationBuilder.UpdateData(
                table: "Modules",
                keyColumn: "Id",
                keyValue: 28,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 6, 23, 11, 14, 26, 926, DateTimeKind.Local).AddTicks(3455), new DateTime(2026, 6, 23, 11, 14, 26, 926, DateTimeKind.Local).AddTicks(3455) });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 6, 23, 11, 14, 26, 926, DateTimeKind.Local).AddTicks(2220), new DateTime(2026, 6, 23, 11, 14, 26, 926, DateTimeKind.Local).AddTicks(2233) });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 6, 23, 11, 14, 26, 926, DateTimeKind.Local).AddTicks(2235), new DateTime(2026, 6, 23, 11, 14, 26, 926, DateTimeKind.Local).AddTicks(2237) });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 6, 23, 11, 14, 26, 926, DateTimeKind.Local).AddTicks(2238), new DateTime(2026, 6, 23, 11, 14, 26, 926, DateTimeKind.Local).AddTicks(2238) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "PasswordHash", "PasswordSalt" },
                values: new object[] { new byte[] { 36, 27, 235, 74, 172, 184, 63, 61, 213, 31, 53, 255, 27, 177, 164, 180, 37, 18, 218, 103, 28, 134, 32, 222, 242, 38, 181, 137, 155, 210, 198, 180, 240, 34, 146, 162, 48, 29, 7, 115, 112, 221, 165, 205, 149, 70, 80, 3, 70, 245, 242, 64, 198, 233, 178, 191, 118, 68, 147, 222, 158, 254, 198, 58 }, new byte[] { 171, 143, 75, 157, 156, 125, 161, 205, 192, 141, 225, 243, 94, 37, 40, 230, 5, 152, 230, 136, 223, 202, 40, 100, 105, 64, 107, 136, 148, 83, 5, 89, 67, 83, 177, 155, 196, 199, 228, 169, 191, 26, 209, 21, 193, 157, 169, 43, 15, 11, 78, 128, 253, 55, 166, 221, 55, 137, 214, 12, 88, 0, 36, 224, 70, 171, 191, 97, 30, 169, 27, 68, 178, 113, 182, 35, 255, 249, 182, 25, 47, 146, 151, 93, 218, 114, 44, 169, 12, 170, 86, 220, 114, 44, 147, 111, 106, 128, 82, 17, 135, 90, 236, 230, 164, 189, 211, 183, 137, 139, 97, 4, 109, 249, 139, 55, 99, 176, 132, 141, 157, 108, 129, 134, 132, 162, 118, 238 } });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "OnBilgilendirmes");

            migrationBuilder.AddColumn<string>(
                name: "FullName",
                table: "Users",
                type: "text",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "ModuleRoles",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 6, 17, 17, 20, 40, 694, DateTimeKind.Local).AddTicks(877), new DateTime(2026, 6, 17, 17, 20, 40, 694, DateTimeKind.Local).AddTicks(878) });

            migrationBuilder.UpdateData(
                table: "ModuleRoles",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 6, 17, 17, 20, 40, 694, DateTimeKind.Local).AddTicks(879), new DateTime(2026, 6, 17, 17, 20, 40, 694, DateTimeKind.Local).AddTicks(880) });

            migrationBuilder.UpdateData(
                table: "ModuleRoles",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 6, 17, 17, 20, 40, 694, DateTimeKind.Local).AddTicks(880), new DateTime(2026, 6, 17, 17, 20, 40, 694, DateTimeKind.Local).AddTicks(881) });

            migrationBuilder.UpdateData(
                table: "ModuleRoles",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 6, 17, 17, 20, 40, 694, DateTimeKind.Local).AddTicks(882), new DateTime(2026, 6, 17, 17, 20, 40, 694, DateTimeKind.Local).AddTicks(883) });

            migrationBuilder.UpdateData(
                table: "ModuleRoles",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 6, 17, 17, 20, 40, 694, DateTimeKind.Local).AddTicks(884), new DateTime(2026, 6, 17, 17, 20, 40, 694, DateTimeKind.Local).AddTicks(884) });

            migrationBuilder.UpdateData(
                table: "ModuleRoles",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 6, 17, 17, 20, 40, 694, DateTimeKind.Local).AddTicks(885), new DateTime(2026, 6, 17, 17, 20, 40, 694, DateTimeKind.Local).AddTicks(886) });

            migrationBuilder.UpdateData(
                table: "ModuleRoles",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 6, 17, 17, 20, 40, 694, DateTimeKind.Local).AddTicks(887), new DateTime(2026, 6, 17, 17, 20, 40, 694, DateTimeKind.Local).AddTicks(887) });

            migrationBuilder.UpdateData(
                table: "ModuleRoles",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 6, 17, 17, 20, 40, 694, DateTimeKind.Local).AddTicks(888), new DateTime(2026, 6, 17, 17, 20, 40, 694, DateTimeKind.Local).AddTicks(889) });

            migrationBuilder.UpdateData(
                table: "ModuleRoles",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 6, 17, 17, 20, 40, 694, DateTimeKind.Local).AddTicks(889), new DateTime(2026, 6, 17, 17, 20, 40, 694, DateTimeKind.Local).AddTicks(890) });

            migrationBuilder.UpdateData(
                table: "ModuleRoles",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 6, 17, 17, 20, 40, 694, DateTimeKind.Local).AddTicks(891), new DateTime(2026, 6, 17, 17, 20, 40, 694, DateTimeKind.Local).AddTicks(892) });

            migrationBuilder.UpdateData(
                table: "ModuleRoles",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 6, 17, 17, 20, 40, 694, DateTimeKind.Local).AddTicks(892), new DateTime(2026, 6, 17, 17, 20, 40, 694, DateTimeKind.Local).AddTicks(893) });

            migrationBuilder.UpdateData(
                table: "ModuleRoles",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 6, 17, 17, 20, 40, 694, DateTimeKind.Local).AddTicks(968), new DateTime(2026, 6, 17, 17, 20, 40, 694, DateTimeKind.Local).AddTicks(969) });

            migrationBuilder.UpdateData(
                table: "ModuleRoles",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 6, 17, 17, 20, 40, 694, DateTimeKind.Local).AddTicks(971), new DateTime(2026, 6, 17, 17, 20, 40, 694, DateTimeKind.Local).AddTicks(971) });

            migrationBuilder.UpdateData(
                table: "ModuleRoles",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 6, 17, 17, 20, 40, 694, DateTimeKind.Local).AddTicks(972), new DateTime(2026, 6, 17, 17, 20, 40, 694, DateTimeKind.Local).AddTicks(973) });

            migrationBuilder.UpdateData(
                table: "ModuleRoles",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 6, 17, 17, 20, 40, 694, DateTimeKind.Local).AddTicks(974), new DateTime(2026, 6, 17, 17, 20, 40, 694, DateTimeKind.Local).AddTicks(974) });

            migrationBuilder.UpdateData(
                table: "ModuleRoles",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 6, 17, 17, 20, 40, 694, DateTimeKind.Local).AddTicks(975), new DateTime(2026, 6, 17, 17, 20, 40, 694, DateTimeKind.Local).AddTicks(976) });

            migrationBuilder.UpdateData(
                table: "ModuleRoles",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 6, 17, 17, 20, 40, 694, DateTimeKind.Local).AddTicks(977), new DateTime(2026, 6, 17, 17, 20, 40, 694, DateTimeKind.Local).AddTicks(977) });

            migrationBuilder.UpdateData(
                table: "ModuleRoles",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 6, 17, 17, 20, 40, 694, DateTimeKind.Local).AddTicks(978), new DateTime(2026, 6, 17, 17, 20, 40, 694, DateTimeKind.Local).AddTicks(979) });

            migrationBuilder.UpdateData(
                table: "ModuleRoles",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 6, 17, 17, 20, 40, 694, DateTimeKind.Local).AddTicks(980), new DateTime(2026, 6, 17, 17, 20, 40, 694, DateTimeKind.Local).AddTicks(980) });

            migrationBuilder.UpdateData(
                table: "ModuleRoles",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 6, 17, 17, 20, 40, 694, DateTimeKind.Local).AddTicks(981), new DateTime(2026, 6, 17, 17, 20, 40, 694, DateTimeKind.Local).AddTicks(982) });

            migrationBuilder.UpdateData(
                table: "ModuleRoles",
                keyColumn: "Id",
                keyValue: 21,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 6, 17, 17, 20, 40, 694, DateTimeKind.Local).AddTicks(983), new DateTime(2026, 6, 17, 17, 20, 40, 694, DateTimeKind.Local).AddTicks(983) });

            migrationBuilder.UpdateData(
                table: "ModuleRoles",
                keyColumn: "Id",
                keyValue: 22,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 6, 17, 17, 20, 40, 694, DateTimeKind.Local).AddTicks(984), new DateTime(2026, 6, 17, 17, 20, 40, 694, DateTimeKind.Local).AddTicks(985) });

            migrationBuilder.UpdateData(
                table: "ModuleRoles",
                keyColumn: "Id",
                keyValue: 23,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 6, 17, 17, 20, 40, 694, DateTimeKind.Local).AddTicks(986), new DateTime(2026, 6, 17, 17, 20, 40, 694, DateTimeKind.Local).AddTicks(986) });

            migrationBuilder.UpdateData(
                table: "ModuleRoles",
                keyColumn: "Id",
                keyValue: 24,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 6, 17, 17, 20, 40, 694, DateTimeKind.Local).AddTicks(987), new DateTime(2026, 6, 17, 17, 20, 40, 694, DateTimeKind.Local).AddTicks(988) });

            migrationBuilder.UpdateData(
                table: "ModuleRoles",
                keyColumn: "Id",
                keyValue: 25,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 6, 17, 17, 20, 40, 694, DateTimeKind.Local).AddTicks(989), new DateTime(2026, 6, 17, 17, 20, 40, 694, DateTimeKind.Local).AddTicks(989) });

            migrationBuilder.UpdateData(
                table: "ModuleRoles",
                keyColumn: "Id",
                keyValue: 26,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 6, 17, 17, 20, 40, 694, DateTimeKind.Local).AddTicks(990), new DateTime(2026, 6, 17, 17, 20, 40, 694, DateTimeKind.Local).AddTicks(991) });

            migrationBuilder.UpdateData(
                table: "ModuleRoles",
                keyColumn: "Id",
                keyValue: 27,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 6, 17, 17, 20, 40, 694, DateTimeKind.Local).AddTicks(992), new DateTime(2026, 6, 17, 17, 20, 40, 694, DateTimeKind.Local).AddTicks(992) });

            migrationBuilder.UpdateData(
                table: "ModuleRoles",
                keyColumn: "Id",
                keyValue: 28,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 6, 17, 17, 20, 40, 694, DateTimeKind.Local).AddTicks(993), new DateTime(2026, 6, 17, 17, 20, 40, 694, DateTimeKind.Local).AddTicks(994) });

            migrationBuilder.UpdateData(
                table: "Modules",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 6, 17, 17, 20, 40, 694, DateTimeKind.Local).AddTicks(786), new DateTime(2026, 6, 17, 17, 20, 40, 694, DateTimeKind.Local).AddTicks(788) });

            migrationBuilder.UpdateData(
                table: "Modules",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 6, 17, 17, 20, 40, 694, DateTimeKind.Local).AddTicks(790), new DateTime(2026, 6, 17, 17, 20, 40, 694, DateTimeKind.Local).AddTicks(791) });

            migrationBuilder.UpdateData(
                table: "Modules",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 6, 17, 17, 20, 40, 694, DateTimeKind.Local).AddTicks(793), new DateTime(2026, 6, 17, 17, 20, 40, 694, DateTimeKind.Local).AddTicks(793) });

            migrationBuilder.UpdateData(
                table: "Modules",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 6, 17, 17, 20, 40, 694, DateTimeKind.Local).AddTicks(795), new DateTime(2026, 6, 17, 17, 20, 40, 694, DateTimeKind.Local).AddTicks(796) });

            migrationBuilder.UpdateData(
                table: "Modules",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 6, 17, 17, 20, 40, 694, DateTimeKind.Local).AddTicks(798), new DateTime(2026, 6, 17, 17, 20, 40, 694, DateTimeKind.Local).AddTicks(798) });

            migrationBuilder.UpdateData(
                table: "Modules",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 6, 17, 17, 20, 40, 694, DateTimeKind.Local).AddTicks(800), new DateTime(2026, 6, 17, 17, 20, 40, 694, DateTimeKind.Local).AddTicks(800) });

            migrationBuilder.UpdateData(
                table: "Modules",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 6, 17, 17, 20, 40, 694, DateTimeKind.Local).AddTicks(802), new DateTime(2026, 6, 17, 17, 20, 40, 694, DateTimeKind.Local).AddTicks(802) });

            migrationBuilder.UpdateData(
                table: "Modules",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 6, 17, 17, 20, 40, 694, DateTimeKind.Local).AddTicks(804), new DateTime(2026, 6, 17, 17, 20, 40, 694, DateTimeKind.Local).AddTicks(804) });

            migrationBuilder.UpdateData(
                table: "Modules",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 6, 17, 17, 20, 40, 694, DateTimeKind.Local).AddTicks(806), new DateTime(2026, 6, 17, 17, 20, 40, 694, DateTimeKind.Local).AddTicks(806) });

            migrationBuilder.UpdateData(
                table: "Modules",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 6, 17, 17, 20, 40, 694, DateTimeKind.Local).AddTicks(808), new DateTime(2026, 6, 17, 17, 20, 40, 694, DateTimeKind.Local).AddTicks(808) });

            migrationBuilder.UpdateData(
                table: "Modules",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 6, 17, 17, 20, 40, 694, DateTimeKind.Local).AddTicks(810), new DateTime(2026, 6, 17, 17, 20, 40, 694, DateTimeKind.Local).AddTicks(810) });

            migrationBuilder.UpdateData(
                table: "Modules",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 6, 17, 17, 20, 40, 694, DateTimeKind.Local).AddTicks(812), new DateTime(2026, 6, 17, 17, 20, 40, 694, DateTimeKind.Local).AddTicks(813) });

            migrationBuilder.UpdateData(
                table: "Modules",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 6, 17, 17, 20, 40, 694, DateTimeKind.Local).AddTicks(814), new DateTime(2026, 6, 17, 17, 20, 40, 694, DateTimeKind.Local).AddTicks(815) });

            migrationBuilder.UpdateData(
                table: "Modules",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 6, 17, 17, 20, 40, 694, DateTimeKind.Local).AddTicks(816), new DateTime(2026, 6, 17, 17, 20, 40, 694, DateTimeKind.Local).AddTicks(817) });

            migrationBuilder.UpdateData(
                table: "Modules",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 6, 17, 17, 20, 40, 694, DateTimeKind.Local).AddTicks(818), new DateTime(2026, 6, 17, 17, 20, 40, 694, DateTimeKind.Local).AddTicks(819) });

            migrationBuilder.UpdateData(
                table: "Modules",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 6, 17, 17, 20, 40, 694, DateTimeKind.Local).AddTicks(820), new DateTime(2026, 6, 17, 17, 20, 40, 694, DateTimeKind.Local).AddTicks(821) });

            migrationBuilder.UpdateData(
                table: "Modules",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 6, 17, 17, 20, 40, 694, DateTimeKind.Local).AddTicks(822), new DateTime(2026, 6, 17, 17, 20, 40, 694, DateTimeKind.Local).AddTicks(823) });

            migrationBuilder.UpdateData(
                table: "Modules",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 6, 17, 17, 20, 40, 694, DateTimeKind.Local).AddTicks(824), new DateTime(2026, 6, 17, 17, 20, 40, 694, DateTimeKind.Local).AddTicks(825) });

            migrationBuilder.UpdateData(
                table: "Modules",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 6, 17, 17, 20, 40, 694, DateTimeKind.Local).AddTicks(826), new DateTime(2026, 6, 17, 17, 20, 40, 694, DateTimeKind.Local).AddTicks(827) });

            migrationBuilder.UpdateData(
                table: "Modules",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 6, 17, 17, 20, 40, 694, DateTimeKind.Local).AddTicks(828), new DateTime(2026, 6, 17, 17, 20, 40, 694, DateTimeKind.Local).AddTicks(829) });

            migrationBuilder.UpdateData(
                table: "Modules",
                keyColumn: "Id",
                keyValue: 21,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 6, 17, 17, 20, 40, 694, DateTimeKind.Local).AddTicks(831), new DateTime(2026, 6, 17, 17, 20, 40, 694, DateTimeKind.Local).AddTicks(831) });

            migrationBuilder.UpdateData(
                table: "Modules",
                keyColumn: "Id",
                keyValue: 22,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 6, 17, 17, 20, 40, 694, DateTimeKind.Local).AddTicks(833), new DateTime(2026, 6, 17, 17, 20, 40, 694, DateTimeKind.Local).AddTicks(833) });

            migrationBuilder.UpdateData(
                table: "Modules",
                keyColumn: "Id",
                keyValue: 23,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 6, 17, 17, 20, 40, 694, DateTimeKind.Local).AddTicks(835), new DateTime(2026, 6, 17, 17, 20, 40, 694, DateTimeKind.Local).AddTicks(835) });

            migrationBuilder.UpdateData(
                table: "Modules",
                keyColumn: "Id",
                keyValue: 24,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 6, 17, 17, 20, 40, 694, DateTimeKind.Local).AddTicks(837), new DateTime(2026, 6, 17, 17, 20, 40, 694, DateTimeKind.Local).AddTicks(837) });

            migrationBuilder.UpdateData(
                table: "Modules",
                keyColumn: "Id",
                keyValue: 25,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 6, 17, 17, 20, 40, 694, DateTimeKind.Local).AddTicks(839), new DateTime(2026, 6, 17, 17, 20, 40, 694, DateTimeKind.Local).AddTicks(839) });

            migrationBuilder.UpdateData(
                table: "Modules",
                keyColumn: "Id",
                keyValue: 26,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 6, 17, 17, 20, 40, 694, DateTimeKind.Local).AddTicks(841), new DateTime(2026, 6, 17, 17, 20, 40, 694, DateTimeKind.Local).AddTicks(841) });

            migrationBuilder.UpdateData(
                table: "Modules",
                keyColumn: "Id",
                keyValue: 27,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 6, 17, 17, 20, 40, 694, DateTimeKind.Local).AddTicks(845), new DateTime(2026, 6, 17, 17, 20, 40, 694, DateTimeKind.Local).AddTicks(846) });

            migrationBuilder.UpdateData(
                table: "Modules",
                keyColumn: "Id",
                keyValue: 28,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 6, 17, 17, 20, 40, 694, DateTimeKind.Local).AddTicks(847), new DateTime(2026, 6, 17, 17, 20, 40, 694, DateTimeKind.Local).AddTicks(848) });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 6, 17, 17, 20, 40, 693, DateTimeKind.Local).AddTicks(9665), new DateTime(2026, 6, 17, 17, 20, 40, 693, DateTimeKind.Local).AddTicks(9681) });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 6, 17, 17, 20, 40, 693, DateTimeKind.Local).AddTicks(9682), new DateTime(2026, 6, 17, 17, 20, 40, 693, DateTimeKind.Local).AddTicks(9683) });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 6, 17, 17, 20, 40, 693, DateTimeKind.Local).AddTicks(9684), new DateTime(2026, 6, 17, 17, 20, 40, 693, DateTimeKind.Local).AddTicks(9684) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "FullName", "PasswordHash", "PasswordSalt" },
                values: new object[] { null, new byte[] { 201, 211, 23, 84, 149, 180, 70, 138, 199, 121, 154, 80, 129, 64, 51, 202, 219, 221, 153, 203, 172, 79, 211, 248, 253, 5, 17, 156, 140, 129, 247, 29, 95, 33, 222, 145, 166, 40, 35, 48, 175, 224, 163, 59, 215, 215, 44, 190, 223, 90, 158, 50, 145, 134, 233, 194, 22, 32, 114, 235, 203, 186, 140, 28 }, new byte[] { 109, 248, 169, 114, 220, 141, 23, 210, 154, 184, 190, 246, 168, 254, 172, 232, 169, 232, 186, 163, 112, 133, 212, 203, 248, 94, 100, 1, 57, 56, 228, 64, 246, 127, 84, 225, 42, 121, 229, 152, 254, 65, 40, 147, 169, 136, 144, 28, 120, 237, 232, 86, 159, 89, 208, 196, 139, 149, 15, 213, 162, 104, 235, 219, 169, 76, 84, 168, 240, 77, 66, 159, 181, 109, 228, 180, 249, 175, 224, 100, 0, 89, 77, 189, 150, 224, 201, 241, 80, 136, 124, 9, 244, 161, 65, 110, 25, 138, 210, 221, 18, 36, 232, 180, 240, 196, 157, 230, 110, 104, 147, 108, 242, 254, 207, 67, 43, 8, 21, 6, 129, 177, 64, 95, 239, 208, 156, 205 } });
        }
    }
}
