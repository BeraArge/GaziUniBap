using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DataAccessLayer.Migrations
{
    /// <inheritdoc />
    public partial class SoruOrderAdded : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "Order",
                table: "Sorus",
                type: "integer",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "ModuleRoles",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 10, 15, 12, 25, 10, 478, DateTimeKind.Local).AddTicks(3788), new DateTime(2026, 10, 15, 12, 25, 10, 478, DateTimeKind.Local).AddTicks(3789) });

            migrationBuilder.UpdateData(
                table: "ModuleRoles",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 10, 15, 12, 25, 10, 478, DateTimeKind.Local).AddTicks(3790), new DateTime(2026, 10, 15, 12, 25, 10, 478, DateTimeKind.Local).AddTicks(3791) });

            migrationBuilder.UpdateData(
                table: "ModuleRoles",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 10, 15, 12, 25, 10, 478, DateTimeKind.Local).AddTicks(3792), new DateTime(2026, 10, 15, 12, 25, 10, 478, DateTimeKind.Local).AddTicks(3792) });

            migrationBuilder.UpdateData(
                table: "ModuleRoles",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 10, 15, 12, 25, 10, 478, DateTimeKind.Local).AddTicks(3794), new DateTime(2026, 10, 15, 12, 25, 10, 478, DateTimeKind.Local).AddTicks(3794) });

            migrationBuilder.UpdateData(
                table: "ModuleRoles",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 10, 15, 12, 25, 10, 478, DateTimeKind.Local).AddTicks(3795), new DateTime(2026, 10, 15, 12, 25, 10, 478, DateTimeKind.Local).AddTicks(3796) });

            migrationBuilder.UpdateData(
                table: "ModuleRoles",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 10, 15, 12, 25, 10, 478, DateTimeKind.Local).AddTicks(3797), new DateTime(2026, 10, 15, 12, 25, 10, 478, DateTimeKind.Local).AddTicks(3797) });

            migrationBuilder.UpdateData(
                table: "ModuleRoles",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 10, 15, 12, 25, 10, 478, DateTimeKind.Local).AddTicks(3798), new DateTime(2026, 10, 15, 12, 25, 10, 478, DateTimeKind.Local).AddTicks(3798) });

            migrationBuilder.UpdateData(
                table: "ModuleRoles",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 10, 15, 12, 25, 10, 478, DateTimeKind.Local).AddTicks(3799), new DateTime(2026, 10, 15, 12, 25, 10, 478, DateTimeKind.Local).AddTicks(3800) });

            migrationBuilder.UpdateData(
                table: "ModuleRoles",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 10, 15, 12, 25, 10, 478, DateTimeKind.Local).AddTicks(3801), new DateTime(2026, 10, 15, 12, 25, 10, 478, DateTimeKind.Local).AddTicks(3801) });

            migrationBuilder.UpdateData(
                table: "ModuleRoles",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 10, 15, 12, 25, 10, 478, DateTimeKind.Local).AddTicks(3802), new DateTime(2026, 10, 15, 12, 25, 10, 478, DateTimeKind.Local).AddTicks(3803) });

            migrationBuilder.UpdateData(
                table: "ModuleRoles",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 10, 15, 12, 25, 10, 478, DateTimeKind.Local).AddTicks(3803), new DateTime(2026, 10, 15, 12, 25, 10, 478, DateTimeKind.Local).AddTicks(3804) });

            migrationBuilder.UpdateData(
                table: "ModuleRoles",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 10, 15, 12, 25, 10, 478, DateTimeKind.Local).AddTicks(3805), new DateTime(2026, 10, 15, 12, 25, 10, 478, DateTimeKind.Local).AddTicks(3805) });

            migrationBuilder.UpdateData(
                table: "ModuleRoles",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 10, 15, 12, 25, 10, 478, DateTimeKind.Local).AddTicks(3806), new DateTime(2026, 10, 15, 12, 25, 10, 478, DateTimeKind.Local).AddTicks(3807) });

            migrationBuilder.UpdateData(
                table: "ModuleRoles",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 10, 15, 12, 25, 10, 478, DateTimeKind.Local).AddTicks(3808), new DateTime(2026, 10, 15, 12, 25, 10, 478, DateTimeKind.Local).AddTicks(3808) });

            migrationBuilder.UpdateData(
                table: "ModuleRoles",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 10, 15, 12, 25, 10, 478, DateTimeKind.Local).AddTicks(3809), new DateTime(2026, 10, 15, 12, 25, 10, 478, DateTimeKind.Local).AddTicks(3810) });

            migrationBuilder.UpdateData(
                table: "ModuleRoles",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 10, 15, 12, 25, 10, 478, DateTimeKind.Local).AddTicks(3810), new DateTime(2026, 10, 15, 12, 25, 10, 478, DateTimeKind.Local).AddTicks(3811) });

            migrationBuilder.UpdateData(
                table: "ModuleRoles",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 10, 15, 12, 25, 10, 478, DateTimeKind.Local).AddTicks(3813), new DateTime(2026, 10, 15, 12, 25, 10, 478, DateTimeKind.Local).AddTicks(3813) });

            migrationBuilder.UpdateData(
                table: "ModuleRoles",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 10, 15, 12, 25, 10, 478, DateTimeKind.Local).AddTicks(3814), new DateTime(2026, 10, 15, 12, 25, 10, 478, DateTimeKind.Local).AddTicks(3815) });

            migrationBuilder.UpdateData(
                table: "ModuleRoles",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 10, 15, 12, 25, 10, 478, DateTimeKind.Local).AddTicks(3815), new DateTime(2026, 10, 15, 12, 25, 10, 478, DateTimeKind.Local).AddTicks(3816) });

            migrationBuilder.UpdateData(
                table: "ModuleRoles",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 10, 15, 12, 25, 10, 478, DateTimeKind.Local).AddTicks(3817), new DateTime(2026, 10, 15, 12, 25, 10, 478, DateTimeKind.Local).AddTicks(3817) });

            migrationBuilder.UpdateData(
                table: "ModuleRoles",
                keyColumn: "Id",
                keyValue: 21,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 10, 15, 12, 25, 10, 478, DateTimeKind.Local).AddTicks(3818), new DateTime(2026, 10, 15, 12, 25, 10, 478, DateTimeKind.Local).AddTicks(3819) });

            migrationBuilder.UpdateData(
                table: "ModuleRoles",
                keyColumn: "Id",
                keyValue: 22,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 10, 15, 12, 25, 10, 478, DateTimeKind.Local).AddTicks(3819), new DateTime(2026, 10, 15, 12, 25, 10, 478, DateTimeKind.Local).AddTicks(3820) });

            migrationBuilder.UpdateData(
                table: "ModuleRoles",
                keyColumn: "Id",
                keyValue: 23,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 10, 15, 12, 25, 10, 478, DateTimeKind.Local).AddTicks(3821), new DateTime(2026, 10, 15, 12, 25, 10, 478, DateTimeKind.Local).AddTicks(3821) });

            migrationBuilder.UpdateData(
                table: "ModuleRoles",
                keyColumn: "Id",
                keyValue: 24,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 10, 15, 12, 25, 10, 478, DateTimeKind.Local).AddTicks(3822), new DateTime(2026, 10, 15, 12, 25, 10, 478, DateTimeKind.Local).AddTicks(3823) });

            migrationBuilder.UpdateData(
                table: "ModuleRoles",
                keyColumn: "Id",
                keyValue: 25,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 10, 15, 12, 25, 10, 478, DateTimeKind.Local).AddTicks(3824), new DateTime(2026, 10, 15, 12, 25, 10, 478, DateTimeKind.Local).AddTicks(3824) });

            migrationBuilder.UpdateData(
                table: "ModuleRoles",
                keyColumn: "Id",
                keyValue: 26,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 10, 15, 12, 25, 10, 478, DateTimeKind.Local).AddTicks(3825), new DateTime(2026, 10, 15, 12, 25, 10, 478, DateTimeKind.Local).AddTicks(3826) });

            migrationBuilder.UpdateData(
                table: "ModuleRoles",
                keyColumn: "Id",
                keyValue: 27,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 10, 15, 12, 25, 10, 478, DateTimeKind.Local).AddTicks(3826), new DateTime(2026, 10, 15, 12, 25, 10, 478, DateTimeKind.Local).AddTicks(3827) });

            migrationBuilder.UpdateData(
                table: "ModuleRoles",
                keyColumn: "Id",
                keyValue: 28,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 10, 15, 12, 25, 10, 478, DateTimeKind.Local).AddTicks(3828), new DateTime(2026, 10, 15, 12, 25, 10, 478, DateTimeKind.Local).AddTicks(3828) });

            migrationBuilder.UpdateData(
                table: "Modules",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 10, 15, 12, 25, 10, 478, DateTimeKind.Local).AddTicks(3609), new DateTime(2026, 10, 15, 12, 25, 10, 478, DateTimeKind.Local).AddTicks(3612) });

            migrationBuilder.UpdateData(
                table: "Modules",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 10, 15, 12, 25, 10, 478, DateTimeKind.Local).AddTicks(3616), new DateTime(2026, 10, 15, 12, 25, 10, 478, DateTimeKind.Local).AddTicks(3616) });

            migrationBuilder.UpdateData(
                table: "Modules",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 10, 15, 12, 25, 10, 478, DateTimeKind.Local).AddTicks(3618), new DateTime(2026, 10, 15, 12, 25, 10, 478, DateTimeKind.Local).AddTicks(3618) });

            migrationBuilder.UpdateData(
                table: "Modules",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 10, 15, 12, 25, 10, 478, DateTimeKind.Local).AddTicks(3619), new DateTime(2026, 10, 15, 12, 25, 10, 478, DateTimeKind.Local).AddTicks(3620) });

            migrationBuilder.UpdateData(
                table: "Modules",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 10, 15, 12, 25, 10, 478, DateTimeKind.Local).AddTicks(3622), new DateTime(2026, 10, 15, 12, 25, 10, 478, DateTimeKind.Local).AddTicks(3623) });

            migrationBuilder.UpdateData(
                table: "Modules",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 10, 15, 12, 25, 10, 478, DateTimeKind.Local).AddTicks(3625), new DateTime(2026, 10, 15, 12, 25, 10, 478, DateTimeKind.Local).AddTicks(3625) });

            migrationBuilder.UpdateData(
                table: "Modules",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 10, 15, 12, 25, 10, 478, DateTimeKind.Local).AddTicks(3626), new DateTime(2026, 10, 15, 12, 25, 10, 478, DateTimeKind.Local).AddTicks(3627) });

            migrationBuilder.UpdateData(
                table: "Modules",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 10, 15, 12, 25, 10, 478, DateTimeKind.Local).AddTicks(3629), new DateTime(2026, 10, 15, 12, 25, 10, 478, DateTimeKind.Local).AddTicks(3629) });

            migrationBuilder.UpdateData(
                table: "Modules",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 10, 15, 12, 25, 10, 478, DateTimeKind.Local).AddTicks(3630), new DateTime(2026, 10, 15, 12, 25, 10, 478, DateTimeKind.Local).AddTicks(3631) });

            migrationBuilder.UpdateData(
                table: "Modules",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 10, 15, 12, 25, 10, 478, DateTimeKind.Local).AddTicks(3634), new DateTime(2026, 10, 15, 12, 25, 10, 478, DateTimeKind.Local).AddTicks(3634) });

            migrationBuilder.UpdateData(
                table: "Modules",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 10, 15, 12, 25, 10, 478, DateTimeKind.Local).AddTicks(3636), new DateTime(2026, 10, 15, 12, 25, 10, 478, DateTimeKind.Local).AddTicks(3636) });

            migrationBuilder.UpdateData(
                table: "Modules",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 10, 15, 12, 25, 10, 478, DateTimeKind.Local).AddTicks(3638), new DateTime(2026, 10, 15, 12, 25, 10, 478, DateTimeKind.Local).AddTicks(3638) });

            migrationBuilder.UpdateData(
                table: "Modules",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 10, 15, 12, 25, 10, 478, DateTimeKind.Local).AddTicks(3640), new DateTime(2026, 10, 15, 12, 25, 10, 478, DateTimeKind.Local).AddTicks(3640) });

            migrationBuilder.UpdateData(
                table: "Modules",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 10, 15, 12, 25, 10, 478, DateTimeKind.Local).AddTicks(3641), new DateTime(2026, 10, 15, 12, 25, 10, 478, DateTimeKind.Local).AddTicks(3642) });

            migrationBuilder.UpdateData(
                table: "Modules",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 10, 15, 12, 25, 10, 478, DateTimeKind.Local).AddTicks(3644), new DateTime(2026, 10, 15, 12, 25, 10, 478, DateTimeKind.Local).AddTicks(3644) });

            migrationBuilder.UpdateData(
                table: "Modules",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 10, 15, 12, 25, 10, 478, DateTimeKind.Local).AddTicks(3646), new DateTime(2026, 10, 15, 12, 25, 10, 478, DateTimeKind.Local).AddTicks(3648) });

            migrationBuilder.UpdateData(
                table: "Modules",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 10, 15, 12, 25, 10, 478, DateTimeKind.Local).AddTicks(3650), new DateTime(2026, 10, 15, 12, 25, 10, 478, DateTimeKind.Local).AddTicks(3650) });

            migrationBuilder.UpdateData(
                table: "Modules",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 10, 15, 12, 25, 10, 478, DateTimeKind.Local).AddTicks(3651), new DateTime(2026, 10, 15, 12, 25, 10, 478, DateTimeKind.Local).AddTicks(3652) });

            migrationBuilder.UpdateData(
                table: "Modules",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 10, 15, 12, 25, 10, 478, DateTimeKind.Local).AddTicks(3653), new DateTime(2026, 10, 15, 12, 25, 10, 478, DateTimeKind.Local).AddTicks(3654) });

            migrationBuilder.UpdateData(
                table: "Modules",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 10, 15, 12, 25, 10, 478, DateTimeKind.Local).AddTicks(3740), new DateTime(2026, 10, 15, 12, 25, 10, 478, DateTimeKind.Local).AddTicks(3741) });

            migrationBuilder.UpdateData(
                table: "Modules",
                keyColumn: "Id",
                keyValue: 21,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 10, 15, 12, 25, 10, 478, DateTimeKind.Local).AddTicks(3742), new DateTime(2026, 10, 15, 12, 25, 10, 478, DateTimeKind.Local).AddTicks(3743) });

            migrationBuilder.UpdateData(
                table: "Modules",
                keyColumn: "Id",
                keyValue: 22,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 10, 15, 12, 25, 10, 478, DateTimeKind.Local).AddTicks(3744), new DateTime(2026, 10, 15, 12, 25, 10, 478, DateTimeKind.Local).AddTicks(3745) });

            migrationBuilder.UpdateData(
                table: "Modules",
                keyColumn: "Id",
                keyValue: 23,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 10, 15, 12, 25, 10, 478, DateTimeKind.Local).AddTicks(3747), new DateTime(2026, 10, 15, 12, 25, 10, 478, DateTimeKind.Local).AddTicks(3747) });

            migrationBuilder.UpdateData(
                table: "Modules",
                keyColumn: "Id",
                keyValue: 24,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 10, 15, 12, 25, 10, 478, DateTimeKind.Local).AddTicks(3749), new DateTime(2026, 10, 15, 12, 25, 10, 478, DateTimeKind.Local).AddTicks(3751) });

            migrationBuilder.UpdateData(
                table: "Modules",
                keyColumn: "Id",
                keyValue: 25,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 10, 15, 12, 25, 10, 478, DateTimeKind.Local).AddTicks(3752), new DateTime(2026, 10, 15, 12, 25, 10, 478, DateTimeKind.Local).AddTicks(3752) });

            migrationBuilder.UpdateData(
                table: "Modules",
                keyColumn: "Id",
                keyValue: 26,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 10, 15, 12, 25, 10, 478, DateTimeKind.Local).AddTicks(3753), new DateTime(2026, 10, 15, 12, 25, 10, 478, DateTimeKind.Local).AddTicks(3754) });

            migrationBuilder.UpdateData(
                table: "Modules",
                keyColumn: "Id",
                keyValue: 27,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 10, 15, 12, 25, 10, 478, DateTimeKind.Local).AddTicks(3755), new DateTime(2026, 10, 15, 12, 25, 10, 478, DateTimeKind.Local).AddTicks(3756) });

            migrationBuilder.UpdateData(
                table: "Modules",
                keyColumn: "Id",
                keyValue: 28,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 10, 15, 12, 25, 10, 478, DateTimeKind.Local).AddTicks(3757), new DateTime(2026, 10, 15, 12, 25, 10, 478, DateTimeKind.Local).AddTicks(3758) });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 10, 15, 12, 25, 10, 478, DateTimeKind.Local).AddTicks(2495), new DateTime(2026, 10, 15, 12, 25, 10, 478, DateTimeKind.Local).AddTicks(2507) });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 10, 15, 12, 25, 10, 478, DateTimeKind.Local).AddTicks(2509), new DateTime(2026, 10, 15, 12, 25, 10, 478, DateTimeKind.Local).AddTicks(2509) });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 10, 15, 12, 25, 10, 478, DateTimeKind.Local).AddTicks(2511), new DateTime(2026, 10, 15, 12, 25, 10, 478, DateTimeKind.Local).AddTicks(2511) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "PasswordHash", "PasswordSalt" },
                values: new object[] { new byte[] { 77, 201, 60, 10, 174, 150, 200, 77, 17, 46, 222, 150, 85, 4, 85, 115, 183, 66, 97, 9, 100, 195, 16, 100, 35, 67, 234, 210, 122, 197, 170, 149, 124, 82, 83, 102, 166, 240, 179, 99, 124, 20, 147, 212, 157, 33, 68, 246, 88, 108, 154, 225, 239, 142, 51, 74, 140, 229, 244, 181, 103, 30, 24, 199 }, new byte[] { 75, 53, 157, 110, 175, 252, 104, 95, 228, 211, 67, 214, 137, 77, 188, 158, 88, 206, 204, 146, 29, 223, 57, 108, 227, 200, 88, 0, 63, 241, 253, 185, 166, 71, 78, 176, 69, 15, 97, 192, 87, 191, 252, 66, 35, 42, 151, 109, 145, 34, 211, 94, 179, 199, 7, 118, 66, 121, 35, 159, 134, 188, 130, 226, 110, 38, 172, 79, 29, 12, 208, 44, 78, 144, 121, 113, 76, 224, 191, 53, 193, 93, 196, 22, 163, 84, 158, 220, 215, 213, 150, 42, 31, 145, 227, 79, 133, 153, 240, 220, 229, 14, 250, 69, 135, 117, 53, 55, 183, 213, 210, 157, 134, 185, 172, 168, 118, 46, 217, 8, 90, 216, 18, 151, 221, 64, 242, 37 } });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Order",
                table: "Sorus");

            migrationBuilder.UpdateData(
                table: "ModuleRoles",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 10, 14, 11, 58, 0, 99, DateTimeKind.Local).AddTicks(4265), new DateTime(2026, 10, 14, 11, 58, 0, 99, DateTimeKind.Local).AddTicks(4266) });

            migrationBuilder.UpdateData(
                table: "ModuleRoles",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 10, 14, 11, 58, 0, 99, DateTimeKind.Local).AddTicks(4267), new DateTime(2026, 10, 14, 11, 58, 0, 99, DateTimeKind.Local).AddTicks(4268) });

            migrationBuilder.UpdateData(
                table: "ModuleRoles",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 10, 14, 11, 58, 0, 99, DateTimeKind.Local).AddTicks(4269), new DateTime(2026, 10, 14, 11, 58, 0, 99, DateTimeKind.Local).AddTicks(4270) });

            migrationBuilder.UpdateData(
                table: "ModuleRoles",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 10, 14, 11, 58, 0, 99, DateTimeKind.Local).AddTicks(4271), new DateTime(2026, 10, 14, 11, 58, 0, 99, DateTimeKind.Local).AddTicks(4271) });

            migrationBuilder.UpdateData(
                table: "ModuleRoles",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 10, 14, 11, 58, 0, 99, DateTimeKind.Local).AddTicks(4272), new DateTime(2026, 10, 14, 11, 58, 0, 99, DateTimeKind.Local).AddTicks(4273) });

            migrationBuilder.UpdateData(
                table: "ModuleRoles",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 10, 14, 11, 58, 0, 99, DateTimeKind.Local).AddTicks(4274), new DateTime(2026, 10, 14, 11, 58, 0, 99, DateTimeKind.Local).AddTicks(4274) });

            migrationBuilder.UpdateData(
                table: "ModuleRoles",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 10, 14, 11, 58, 0, 99, DateTimeKind.Local).AddTicks(4275), new DateTime(2026, 10, 14, 11, 58, 0, 99, DateTimeKind.Local).AddTicks(4276) });

            migrationBuilder.UpdateData(
                table: "ModuleRoles",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 10, 14, 11, 58, 0, 99, DateTimeKind.Local).AddTicks(4277), new DateTime(2026, 10, 14, 11, 58, 0, 99, DateTimeKind.Local).AddTicks(4278) });

            migrationBuilder.UpdateData(
                table: "ModuleRoles",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 10, 14, 11, 58, 0, 99, DateTimeKind.Local).AddTicks(4279), new DateTime(2026, 10, 14, 11, 58, 0, 99, DateTimeKind.Local).AddTicks(4279) });

            migrationBuilder.UpdateData(
                table: "ModuleRoles",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 10, 14, 11, 58, 0, 99, DateTimeKind.Local).AddTicks(4280), new DateTime(2026, 10, 14, 11, 58, 0, 99, DateTimeKind.Local).AddTicks(4281) });

            migrationBuilder.UpdateData(
                table: "ModuleRoles",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 10, 14, 11, 58, 0, 99, DateTimeKind.Local).AddTicks(4282), new DateTime(2026, 10, 14, 11, 58, 0, 99, DateTimeKind.Local).AddTicks(4283) });

            migrationBuilder.UpdateData(
                table: "ModuleRoles",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 10, 14, 11, 58, 0, 99, DateTimeKind.Local).AddTicks(4286), new DateTime(2026, 10, 14, 11, 58, 0, 99, DateTimeKind.Local).AddTicks(4286) });

            migrationBuilder.UpdateData(
                table: "ModuleRoles",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 10, 14, 11, 58, 0, 99, DateTimeKind.Local).AddTicks(4287), new DateTime(2026, 10, 14, 11, 58, 0, 99, DateTimeKind.Local).AddTicks(4288) });

            migrationBuilder.UpdateData(
                table: "ModuleRoles",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 10, 14, 11, 58, 0, 99, DateTimeKind.Local).AddTicks(4289), new DateTime(2026, 10, 14, 11, 58, 0, 99, DateTimeKind.Local).AddTicks(4290) });

            migrationBuilder.UpdateData(
                table: "ModuleRoles",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 10, 14, 11, 58, 0, 99, DateTimeKind.Local).AddTicks(4291), new DateTime(2026, 10, 14, 11, 58, 0, 99, DateTimeKind.Local).AddTicks(4291) });

            migrationBuilder.UpdateData(
                table: "ModuleRoles",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 10, 14, 11, 58, 0, 99, DateTimeKind.Local).AddTicks(4293), new DateTime(2026, 10, 14, 11, 58, 0, 99, DateTimeKind.Local).AddTicks(4294) });

            migrationBuilder.UpdateData(
                table: "ModuleRoles",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 10, 14, 11, 58, 0, 99, DateTimeKind.Local).AddTicks(4295), new DateTime(2026, 10, 14, 11, 58, 0, 99, DateTimeKind.Local).AddTicks(4295) });

            migrationBuilder.UpdateData(
                table: "ModuleRoles",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 10, 14, 11, 58, 0, 99, DateTimeKind.Local).AddTicks(4296), new DateTime(2026, 10, 14, 11, 58, 0, 99, DateTimeKind.Local).AddTicks(4297) });

            migrationBuilder.UpdateData(
                table: "ModuleRoles",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 10, 14, 11, 58, 0, 99, DateTimeKind.Local).AddTicks(4298), new DateTime(2026, 10, 14, 11, 58, 0, 99, DateTimeKind.Local).AddTicks(4298) });

            migrationBuilder.UpdateData(
                table: "ModuleRoles",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 10, 14, 11, 58, 0, 99, DateTimeKind.Local).AddTicks(4299), new DateTime(2026, 10, 14, 11, 58, 0, 99, DateTimeKind.Local).AddTicks(4300) });

            migrationBuilder.UpdateData(
                table: "ModuleRoles",
                keyColumn: "Id",
                keyValue: 21,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 10, 14, 11, 58, 0, 99, DateTimeKind.Local).AddTicks(4301), new DateTime(2026, 10, 14, 11, 58, 0, 99, DateTimeKind.Local).AddTicks(4301) });

            migrationBuilder.UpdateData(
                table: "ModuleRoles",
                keyColumn: "Id",
                keyValue: 22,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 10, 14, 11, 58, 0, 99, DateTimeKind.Local).AddTicks(4368), new DateTime(2026, 10, 14, 11, 58, 0, 99, DateTimeKind.Local).AddTicks(4369) });

            migrationBuilder.UpdateData(
                table: "ModuleRoles",
                keyColumn: "Id",
                keyValue: 23,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 10, 14, 11, 58, 0, 99, DateTimeKind.Local).AddTicks(4371), new DateTime(2026, 10, 14, 11, 58, 0, 99, DateTimeKind.Local).AddTicks(4371) });

            migrationBuilder.UpdateData(
                table: "ModuleRoles",
                keyColumn: "Id",
                keyValue: 24,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 10, 14, 11, 58, 0, 99, DateTimeKind.Local).AddTicks(4372), new DateTime(2026, 10, 14, 11, 58, 0, 99, DateTimeKind.Local).AddTicks(4373) });

            migrationBuilder.UpdateData(
                table: "ModuleRoles",
                keyColumn: "Id",
                keyValue: 25,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 10, 14, 11, 58, 0, 99, DateTimeKind.Local).AddTicks(4375), new DateTime(2026, 10, 14, 11, 58, 0, 99, DateTimeKind.Local).AddTicks(4376) });

            migrationBuilder.UpdateData(
                table: "ModuleRoles",
                keyColumn: "Id",
                keyValue: 26,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 10, 14, 11, 58, 0, 99, DateTimeKind.Local).AddTicks(4377), new DateTime(2026, 10, 14, 11, 58, 0, 99, DateTimeKind.Local).AddTicks(4378) });

            migrationBuilder.UpdateData(
                table: "ModuleRoles",
                keyColumn: "Id",
                keyValue: 27,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 10, 14, 11, 58, 0, 99, DateTimeKind.Local).AddTicks(4379), new DateTime(2026, 10, 14, 11, 58, 0, 99, DateTimeKind.Local).AddTicks(4379) });

            migrationBuilder.UpdateData(
                table: "ModuleRoles",
                keyColumn: "Id",
                keyValue: 28,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 10, 14, 11, 58, 0, 99, DateTimeKind.Local).AddTicks(4380), new DateTime(2026, 10, 14, 11, 58, 0, 99, DateTimeKind.Local).AddTicks(4381) });

            migrationBuilder.UpdateData(
                table: "Modules",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 10, 14, 11, 58, 0, 99, DateTimeKind.Local).AddTicks(4167), new DateTime(2026, 10, 14, 11, 58, 0, 99, DateTimeKind.Local).AddTicks(4171) });

            migrationBuilder.UpdateData(
                table: "Modules",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 10, 14, 11, 58, 0, 99, DateTimeKind.Local).AddTicks(4173), new DateTime(2026, 10, 14, 11, 58, 0, 99, DateTimeKind.Local).AddTicks(4174) });

            migrationBuilder.UpdateData(
                table: "Modules",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 10, 14, 11, 58, 0, 99, DateTimeKind.Local).AddTicks(4176), new DateTime(2026, 10, 14, 11, 58, 0, 99, DateTimeKind.Local).AddTicks(4176) });

            migrationBuilder.UpdateData(
                table: "Modules",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 10, 14, 11, 58, 0, 99, DateTimeKind.Local).AddTicks(4179), new DateTime(2026, 10, 14, 11, 58, 0, 99, DateTimeKind.Local).AddTicks(4180) });

            migrationBuilder.UpdateData(
                table: "Modules",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 10, 14, 11, 58, 0, 99, DateTimeKind.Local).AddTicks(4182), new DateTime(2026, 10, 14, 11, 58, 0, 99, DateTimeKind.Local).AddTicks(4183) });

            migrationBuilder.UpdateData(
                table: "Modules",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 10, 14, 11, 58, 0, 99, DateTimeKind.Local).AddTicks(4185), new DateTime(2026, 10, 14, 11, 58, 0, 99, DateTimeKind.Local).AddTicks(4186) });

            migrationBuilder.UpdateData(
                table: "Modules",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 10, 14, 11, 58, 0, 99, DateTimeKind.Local).AddTicks(4187), new DateTime(2026, 10, 14, 11, 58, 0, 99, DateTimeKind.Local).AddTicks(4188) });

            migrationBuilder.UpdateData(
                table: "Modules",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 10, 14, 11, 58, 0, 99, DateTimeKind.Local).AddTicks(4189), new DateTime(2026, 10, 14, 11, 58, 0, 99, DateTimeKind.Local).AddTicks(4191) });

            migrationBuilder.UpdateData(
                table: "Modules",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 10, 14, 11, 58, 0, 99, DateTimeKind.Local).AddTicks(4192), new DateTime(2026, 10, 14, 11, 58, 0, 99, DateTimeKind.Local).AddTicks(4193) });

            migrationBuilder.UpdateData(
                table: "Modules",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 10, 14, 11, 58, 0, 99, DateTimeKind.Local).AddTicks(4194), new DateTime(2026, 10, 14, 11, 58, 0, 99, DateTimeKind.Local).AddTicks(4195) });

            migrationBuilder.UpdateData(
                table: "Modules",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 10, 14, 11, 58, 0, 99, DateTimeKind.Local).AddTicks(4196), new DateTime(2026, 10, 14, 11, 58, 0, 99, DateTimeKind.Local).AddTicks(4197) });

            migrationBuilder.UpdateData(
                table: "Modules",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 10, 14, 11, 58, 0, 99, DateTimeKind.Local).AddTicks(4198), new DateTime(2026, 10, 14, 11, 58, 0, 99, DateTimeKind.Local).AddTicks(4199) });

            migrationBuilder.UpdateData(
                table: "Modules",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 10, 14, 11, 58, 0, 99, DateTimeKind.Local).AddTicks(4200), new DateTime(2026, 10, 14, 11, 58, 0, 99, DateTimeKind.Local).AddTicks(4201) });

            migrationBuilder.UpdateData(
                table: "Modules",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 10, 14, 11, 58, 0, 99, DateTimeKind.Local).AddTicks(4202), new DateTime(2026, 10, 14, 11, 58, 0, 99, DateTimeKind.Local).AddTicks(4203) });

            migrationBuilder.UpdateData(
                table: "Modules",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 10, 14, 11, 58, 0, 99, DateTimeKind.Local).AddTicks(4204), new DateTime(2026, 10, 14, 11, 58, 0, 99, DateTimeKind.Local).AddTicks(4205) });

            migrationBuilder.UpdateData(
                table: "Modules",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 10, 14, 11, 58, 0, 99, DateTimeKind.Local).AddTicks(4206), new DateTime(2026, 10, 14, 11, 58, 0, 99, DateTimeKind.Local).AddTicks(4207) });

            migrationBuilder.UpdateData(
                table: "Modules",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 10, 14, 11, 58, 0, 99, DateTimeKind.Local).AddTicks(4209), new DateTime(2026, 10, 14, 11, 58, 0, 99, DateTimeKind.Local).AddTicks(4210) });

            migrationBuilder.UpdateData(
                table: "Modules",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 10, 14, 11, 58, 0, 99, DateTimeKind.Local).AddTicks(4211), new DateTime(2026, 10, 14, 11, 58, 0, 99, DateTimeKind.Local).AddTicks(4212) });

            migrationBuilder.UpdateData(
                table: "Modules",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 10, 14, 11, 58, 0, 99, DateTimeKind.Local).AddTicks(4213), new DateTime(2026, 10, 14, 11, 58, 0, 99, DateTimeKind.Local).AddTicks(4213) });

            migrationBuilder.UpdateData(
                table: "Modules",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 10, 14, 11, 58, 0, 99, DateTimeKind.Local).AddTicks(4215), new DateTime(2026, 10, 14, 11, 58, 0, 99, DateTimeKind.Local).AddTicks(4215) });

            migrationBuilder.UpdateData(
                table: "Modules",
                keyColumn: "Id",
                keyValue: 21,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 10, 14, 11, 58, 0, 99, DateTimeKind.Local).AddTicks(4218), new DateTime(2026, 10, 14, 11, 58, 0, 99, DateTimeKind.Local).AddTicks(4219) });

            migrationBuilder.UpdateData(
                table: "Modules",
                keyColumn: "Id",
                keyValue: 22,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 10, 14, 11, 58, 0, 99, DateTimeKind.Local).AddTicks(4221), new DateTime(2026, 10, 14, 11, 58, 0, 99, DateTimeKind.Local).AddTicks(4222) });

            migrationBuilder.UpdateData(
                table: "Modules",
                keyColumn: "Id",
                keyValue: 23,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 10, 14, 11, 58, 0, 99, DateTimeKind.Local).AddTicks(4223), new DateTime(2026, 10, 14, 11, 58, 0, 99, DateTimeKind.Local).AddTicks(4223) });

            migrationBuilder.UpdateData(
                table: "Modules",
                keyColumn: "Id",
                keyValue: 24,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 10, 14, 11, 58, 0, 99, DateTimeKind.Local).AddTicks(4225), new DateTime(2026, 10, 14, 11, 58, 0, 99, DateTimeKind.Local).AddTicks(4225) });

            migrationBuilder.UpdateData(
                table: "Modules",
                keyColumn: "Id",
                keyValue: 25,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 10, 14, 11, 58, 0, 99, DateTimeKind.Local).AddTicks(4229), new DateTime(2026, 10, 14, 11, 58, 0, 99, DateTimeKind.Local).AddTicks(4230) });

            migrationBuilder.UpdateData(
                table: "Modules",
                keyColumn: "Id",
                keyValue: 26,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 10, 14, 11, 58, 0, 99, DateTimeKind.Local).AddTicks(4231), new DateTime(2026, 10, 14, 11, 58, 0, 99, DateTimeKind.Local).AddTicks(4232) });

            migrationBuilder.UpdateData(
                table: "Modules",
                keyColumn: "Id",
                keyValue: 27,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 10, 14, 11, 58, 0, 99, DateTimeKind.Local).AddTicks(4233), new DateTime(2026, 10, 14, 11, 58, 0, 99, DateTimeKind.Local).AddTicks(4233) });

            migrationBuilder.UpdateData(
                table: "Modules",
                keyColumn: "Id",
                keyValue: 28,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 10, 14, 11, 58, 0, 99, DateTimeKind.Local).AddTicks(4235), new DateTime(2026, 10, 14, 11, 58, 0, 99, DateTimeKind.Local).AddTicks(4235) });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 10, 14, 11, 58, 0, 99, DateTimeKind.Local).AddTicks(2912), new DateTime(2026, 10, 14, 11, 58, 0, 99, DateTimeKind.Local).AddTicks(2925) });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 10, 14, 11, 58, 0, 99, DateTimeKind.Local).AddTicks(2927), new DateTime(2026, 10, 14, 11, 58, 0, 99, DateTimeKind.Local).AddTicks(2928) });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 10, 14, 11, 58, 0, 99, DateTimeKind.Local).AddTicks(2929), new DateTime(2026, 10, 14, 11, 58, 0, 99, DateTimeKind.Local).AddTicks(2929) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "PasswordHash", "PasswordSalt" },
                values: new object[] { new byte[] { 125, 209, 27, 153, 177, 57, 130, 44, 35, 140, 59, 252, 18, 25, 46, 93, 220, 86, 2, 48, 66, 31, 10, 54, 106, 209, 210, 130, 66, 45, 165, 7, 22, 108, 49, 45, 24, 144, 192, 57, 208, 75, 57, 168, 105, 235, 213, 53, 169, 133, 145, 181, 238, 140, 138, 99, 41, 154, 141, 126, 130, 123, 147, 62 }, new byte[] { 183, 139, 133, 224, 206, 173, 218, 83, 167, 114, 231, 169, 36, 99, 136, 249, 249, 75, 77, 144, 153, 63, 191, 104, 207, 203, 248, 40, 62, 233, 104, 116, 241, 72, 26, 81, 240, 170, 209, 182, 112, 254, 43, 100, 0, 208, 32, 158, 198, 172, 76, 233, 247, 170, 17, 218, 189, 118, 195, 221, 82, 62, 104, 36, 150, 80, 50, 197, 217, 193, 9, 51, 192, 217, 76, 119, 205, 120, 5, 245, 63, 236, 175, 10, 58, 228, 236, 161, 230, 57, 28, 111, 167, 222, 50, 50, 182, 128, 111, 220, 155, 46, 208, 58, 72, 133, 154, 53, 170, 238, 116, 116, 89, 223, 141, 220, 238, 96, 251, 221, 68, 109, 233, 106, 63, 3, 229, 18 } });
        }
    }
}
