using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DataAccessLayer.Migrations
{
    /// <inheritdoc />
    public partial class sorucevaplamasureleriadded : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "AciklamaOkumaSuresiSaniye",
                table: "SoruUsers",
                type: "integer",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "CevaplamaSuresiSaniye",
                table: "SoruUsers",
                type: "integer",
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
                columns: new[] { "PasswordHash", "PasswordSalt" },
                values: new object[] { new byte[] { 201, 211, 23, 84, 149, 180, 70, 138, 199, 121, 154, 80, 129, 64, 51, 202, 219, 221, 153, 203, 172, 79, 211, 248, 253, 5, 17, 156, 140, 129, 247, 29, 95, 33, 222, 145, 166, 40, 35, 48, 175, 224, 163, 59, 215, 215, 44, 190, 223, 90, 158, 50, 145, 134, 233, 194, 22, 32, 114, 235, 203, 186, 140, 28 }, new byte[] { 109, 248, 169, 114, 220, 141, 23, 210, 154, 184, 190, 246, 168, 254, 172, 232, 169, 232, 186, 163, 112, 133, 212, 203, 248, 94, 100, 1, 57, 56, 228, 64, 246, 127, 84, 225, 42, 121, 229, 152, 254, 65, 40, 147, 169, 136, 144, 28, 120, 237, 232, 86, 159, 89, 208, 196, 139, 149, 15, 213, 162, 104, 235, 219, 169, 76, 84, 168, 240, 77, 66, 159, 181, 109, 228, 180, 249, 175, 224, 100, 0, 89, 77, 189, 150, 224, 201, 241, 80, 136, 124, 9, 244, 161, 65, 110, 25, 138, 210, 221, 18, 36, 232, 180, 240, 196, 157, 230, 110, 104, 147, 108, 242, 254, 207, 67, 43, 8, 21, 6, 129, 177, 64, 95, 239, 208, 156, 205 } });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "AciklamaOkumaSuresiSaniye",
                table: "SoruUsers");

            migrationBuilder.DropColumn(
                name: "CevaplamaSuresiSaniye",
                table: "SoruUsers");

            migrationBuilder.UpdateData(
                table: "ModuleRoles",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 6, 16, 15, 36, 32, 263, DateTimeKind.Local).AddTicks(3132), new DateTime(2026, 6, 16, 15, 36, 32, 263, DateTimeKind.Local).AddTicks(3133) });

            migrationBuilder.UpdateData(
                table: "ModuleRoles",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 6, 16, 15, 36, 32, 263, DateTimeKind.Local).AddTicks(3134), new DateTime(2026, 6, 16, 15, 36, 32, 263, DateTimeKind.Local).AddTicks(3134) });

            migrationBuilder.UpdateData(
                table: "ModuleRoles",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 6, 16, 15, 36, 32, 263, DateTimeKind.Local).AddTicks(3135), new DateTime(2026, 6, 16, 15, 36, 32, 263, DateTimeKind.Local).AddTicks(3136) });

            migrationBuilder.UpdateData(
                table: "ModuleRoles",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 6, 16, 15, 36, 32, 263, DateTimeKind.Local).AddTicks(3136), new DateTime(2026, 6, 16, 15, 36, 32, 263, DateTimeKind.Local).AddTicks(3137) });

            migrationBuilder.UpdateData(
                table: "ModuleRoles",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 6, 16, 15, 36, 32, 263, DateTimeKind.Local).AddTicks(3140), new DateTime(2026, 6, 16, 15, 36, 32, 263, DateTimeKind.Local).AddTicks(3140) });

            migrationBuilder.UpdateData(
                table: "ModuleRoles",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 6, 16, 15, 36, 32, 263, DateTimeKind.Local).AddTicks(3141), new DateTime(2026, 6, 16, 15, 36, 32, 263, DateTimeKind.Local).AddTicks(3141) });

            migrationBuilder.UpdateData(
                table: "ModuleRoles",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 6, 16, 15, 36, 32, 263, DateTimeKind.Local).AddTicks(3142), new DateTime(2026, 6, 16, 15, 36, 32, 263, DateTimeKind.Local).AddTicks(3143) });

            migrationBuilder.UpdateData(
                table: "ModuleRoles",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 6, 16, 15, 36, 32, 263, DateTimeKind.Local).AddTicks(3143), new DateTime(2026, 6, 16, 15, 36, 32, 263, DateTimeKind.Local).AddTicks(3144) });

            migrationBuilder.UpdateData(
                table: "ModuleRoles",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 6, 16, 15, 36, 32, 263, DateTimeKind.Local).AddTicks(3144), new DateTime(2026, 6, 16, 15, 36, 32, 263, DateTimeKind.Local).AddTicks(3145) });

            migrationBuilder.UpdateData(
                table: "ModuleRoles",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 6, 16, 15, 36, 32, 263, DateTimeKind.Local).AddTicks(3146), new DateTime(2026, 6, 16, 15, 36, 32, 263, DateTimeKind.Local).AddTicks(3146) });

            migrationBuilder.UpdateData(
                table: "ModuleRoles",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 6, 16, 15, 36, 32, 263, DateTimeKind.Local).AddTicks(3147), new DateTime(2026, 6, 16, 15, 36, 32, 263, DateTimeKind.Local).AddTicks(3147) });

            migrationBuilder.UpdateData(
                table: "ModuleRoles",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 6, 16, 15, 36, 32, 263, DateTimeKind.Local).AddTicks(3148), new DateTime(2026, 6, 16, 15, 36, 32, 263, DateTimeKind.Local).AddTicks(3148) });

            migrationBuilder.UpdateData(
                table: "ModuleRoles",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 6, 16, 15, 36, 32, 263, DateTimeKind.Local).AddTicks(3149), new DateTime(2026, 6, 16, 15, 36, 32, 263, DateTimeKind.Local).AddTicks(3150) });

            migrationBuilder.UpdateData(
                table: "ModuleRoles",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 6, 16, 15, 36, 32, 263, DateTimeKind.Local).AddTicks(3150), new DateTime(2026, 6, 16, 15, 36, 32, 263, DateTimeKind.Local).AddTicks(3151) });

            migrationBuilder.UpdateData(
                table: "ModuleRoles",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 6, 16, 15, 36, 32, 263, DateTimeKind.Local).AddTicks(3152), new DateTime(2026, 6, 16, 15, 36, 32, 263, DateTimeKind.Local).AddTicks(3153) });

            migrationBuilder.UpdateData(
                table: "ModuleRoles",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 6, 16, 15, 36, 32, 263, DateTimeKind.Local).AddTicks(3153), new DateTime(2026, 6, 16, 15, 36, 32, 263, DateTimeKind.Local).AddTicks(3154) });

            migrationBuilder.UpdateData(
                table: "ModuleRoles",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 6, 16, 15, 36, 32, 263, DateTimeKind.Local).AddTicks(3155), new DateTime(2026, 6, 16, 15, 36, 32, 263, DateTimeKind.Local).AddTicks(3155) });

            migrationBuilder.UpdateData(
                table: "ModuleRoles",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 6, 16, 15, 36, 32, 263, DateTimeKind.Local).AddTicks(3156), new DateTime(2026, 6, 16, 15, 36, 32, 263, DateTimeKind.Local).AddTicks(3156) });

            migrationBuilder.UpdateData(
                table: "ModuleRoles",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 6, 16, 15, 36, 32, 263, DateTimeKind.Local).AddTicks(3157), new DateTime(2026, 6, 16, 15, 36, 32, 263, DateTimeKind.Local).AddTicks(3157) });

            migrationBuilder.UpdateData(
                table: "ModuleRoles",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 6, 16, 15, 36, 32, 263, DateTimeKind.Local).AddTicks(3158), new DateTime(2026, 6, 16, 15, 36, 32, 263, DateTimeKind.Local).AddTicks(3159) });

            migrationBuilder.UpdateData(
                table: "ModuleRoles",
                keyColumn: "Id",
                keyValue: 21,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 6, 16, 15, 36, 32, 263, DateTimeKind.Local).AddTicks(3159), new DateTime(2026, 6, 16, 15, 36, 32, 263, DateTimeKind.Local).AddTicks(3160) });

            migrationBuilder.UpdateData(
                table: "ModuleRoles",
                keyColumn: "Id",
                keyValue: 22,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 6, 16, 15, 36, 32, 263, DateTimeKind.Local).AddTicks(3161), new DateTime(2026, 6, 16, 15, 36, 32, 263, DateTimeKind.Local).AddTicks(3161) });

            migrationBuilder.UpdateData(
                table: "ModuleRoles",
                keyColumn: "Id",
                keyValue: 23,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 6, 16, 15, 36, 32, 263, DateTimeKind.Local).AddTicks(3162), new DateTime(2026, 6, 16, 15, 36, 32, 263, DateTimeKind.Local).AddTicks(3162) });

            migrationBuilder.UpdateData(
                table: "ModuleRoles",
                keyColumn: "Id",
                keyValue: 24,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 6, 16, 15, 36, 32, 263, DateTimeKind.Local).AddTicks(3163), new DateTime(2026, 6, 16, 15, 36, 32, 263, DateTimeKind.Local).AddTicks(3163) });

            migrationBuilder.UpdateData(
                table: "ModuleRoles",
                keyColumn: "Id",
                keyValue: 25,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 6, 16, 15, 36, 32, 263, DateTimeKind.Local).AddTicks(3164), new DateTime(2026, 6, 16, 15, 36, 32, 263, DateTimeKind.Local).AddTicks(3164) });

            migrationBuilder.UpdateData(
                table: "ModuleRoles",
                keyColumn: "Id",
                keyValue: 26,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 6, 16, 15, 36, 32, 263, DateTimeKind.Local).AddTicks(3165), new DateTime(2026, 6, 16, 15, 36, 32, 263, DateTimeKind.Local).AddTicks(3166) });

            migrationBuilder.UpdateData(
                table: "ModuleRoles",
                keyColumn: "Id",
                keyValue: 27,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 6, 16, 15, 36, 32, 263, DateTimeKind.Local).AddTicks(3166), new DateTime(2026, 6, 16, 15, 36, 32, 263, DateTimeKind.Local).AddTicks(3167) });

            migrationBuilder.UpdateData(
                table: "ModuleRoles",
                keyColumn: "Id",
                keyValue: 28,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 6, 16, 15, 36, 32, 263, DateTimeKind.Local).AddTicks(3168), new DateTime(2026, 6, 16, 15, 36, 32, 263, DateTimeKind.Local).AddTicks(3168) });

            migrationBuilder.UpdateData(
                table: "Modules",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 6, 16, 15, 36, 32, 263, DateTimeKind.Local).AddTicks(2957), new DateTime(2026, 6, 16, 15, 36, 32, 263, DateTimeKind.Local).AddTicks(2959) });

            migrationBuilder.UpdateData(
                table: "Modules",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 6, 16, 15, 36, 32, 263, DateTimeKind.Local).AddTicks(2960), new DateTime(2026, 6, 16, 15, 36, 32, 263, DateTimeKind.Local).AddTicks(2961) });

            migrationBuilder.UpdateData(
                table: "Modules",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 6, 16, 15, 36, 32, 263, DateTimeKind.Local).AddTicks(2963), new DateTime(2026, 6, 16, 15, 36, 32, 263, DateTimeKind.Local).AddTicks(2964) });

            migrationBuilder.UpdateData(
                table: "Modules",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 6, 16, 15, 36, 32, 263, DateTimeKind.Local).AddTicks(2965), new DateTime(2026, 6, 16, 15, 36, 32, 263, DateTimeKind.Local).AddTicks(2965) });

            migrationBuilder.UpdateData(
                table: "Modules",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 6, 16, 15, 36, 32, 263, DateTimeKind.Local).AddTicks(2966), new DateTime(2026, 6, 16, 15, 36, 32, 263, DateTimeKind.Local).AddTicks(2967) });

            migrationBuilder.UpdateData(
                table: "Modules",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 6, 16, 15, 36, 32, 263, DateTimeKind.Local).AddTicks(2968), new DateTime(2026, 6, 16, 15, 36, 32, 263, DateTimeKind.Local).AddTicks(2968) });

            migrationBuilder.UpdateData(
                table: "Modules",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 6, 16, 15, 36, 32, 263, DateTimeKind.Local).AddTicks(2969), new DateTime(2026, 6, 16, 15, 36, 32, 263, DateTimeKind.Local).AddTicks(2970) });

            migrationBuilder.UpdateData(
                table: "Modules",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 6, 16, 15, 36, 32, 263, DateTimeKind.Local).AddTicks(2971), new DateTime(2026, 6, 16, 15, 36, 32, 263, DateTimeKind.Local).AddTicks(2971) });

            migrationBuilder.UpdateData(
                table: "Modules",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 6, 16, 15, 36, 32, 263, DateTimeKind.Local).AddTicks(2972), new DateTime(2026, 6, 16, 15, 36, 32, 263, DateTimeKind.Local).AddTicks(2972) });

            migrationBuilder.UpdateData(
                table: "Modules",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 6, 16, 15, 36, 32, 263, DateTimeKind.Local).AddTicks(3072), new DateTime(2026, 6, 16, 15, 36, 32, 263, DateTimeKind.Local).AddTicks(3072) });

            migrationBuilder.UpdateData(
                table: "Modules",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 6, 16, 15, 36, 32, 263, DateTimeKind.Local).AddTicks(3074), new DateTime(2026, 6, 16, 15, 36, 32, 263, DateTimeKind.Local).AddTicks(3074) });

            migrationBuilder.UpdateData(
                table: "Modules",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 6, 16, 15, 36, 32, 263, DateTimeKind.Local).AddTicks(3075), new DateTime(2026, 6, 16, 15, 36, 32, 263, DateTimeKind.Local).AddTicks(3076) });

            migrationBuilder.UpdateData(
                table: "Modules",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 6, 16, 15, 36, 32, 263, DateTimeKind.Local).AddTicks(3078), new DateTime(2026, 6, 16, 15, 36, 32, 263, DateTimeKind.Local).AddTicks(3078) });

            migrationBuilder.UpdateData(
                table: "Modules",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 6, 16, 15, 36, 32, 263, DateTimeKind.Local).AddTicks(3079), new DateTime(2026, 6, 16, 15, 36, 32, 263, DateTimeKind.Local).AddTicks(3080) });

            migrationBuilder.UpdateData(
                table: "Modules",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 6, 16, 15, 36, 32, 263, DateTimeKind.Local).AddTicks(3081), new DateTime(2026, 6, 16, 15, 36, 32, 263, DateTimeKind.Local).AddTicks(3081) });

            migrationBuilder.UpdateData(
                table: "Modules",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 6, 16, 15, 36, 32, 263, DateTimeKind.Local).AddTicks(3082), new DateTime(2026, 6, 16, 15, 36, 32, 263, DateTimeKind.Local).AddTicks(3083) });

            migrationBuilder.UpdateData(
                table: "Modules",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 6, 16, 15, 36, 32, 263, DateTimeKind.Local).AddTicks(3084), new DateTime(2026, 6, 16, 15, 36, 32, 263, DateTimeKind.Local).AddTicks(3084) });

            migrationBuilder.UpdateData(
                table: "Modules",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 6, 16, 15, 36, 32, 263, DateTimeKind.Local).AddTicks(3086), new DateTime(2026, 6, 16, 15, 36, 32, 263, DateTimeKind.Local).AddTicks(3086) });

            migrationBuilder.UpdateData(
                table: "Modules",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 6, 16, 15, 36, 32, 263, DateTimeKind.Local).AddTicks(3087), new DateTime(2026, 6, 16, 15, 36, 32, 263, DateTimeKind.Local).AddTicks(3088) });

            migrationBuilder.UpdateData(
                table: "Modules",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 6, 16, 15, 36, 32, 263, DateTimeKind.Local).AddTicks(3089), new DateTime(2026, 6, 16, 15, 36, 32, 263, DateTimeKind.Local).AddTicks(3089) });

            migrationBuilder.UpdateData(
                table: "Modules",
                keyColumn: "Id",
                keyValue: 21,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 6, 16, 15, 36, 32, 263, DateTimeKind.Local).AddTicks(3090), new DateTime(2026, 6, 16, 15, 36, 32, 263, DateTimeKind.Local).AddTicks(3091) });

            migrationBuilder.UpdateData(
                table: "Modules",
                keyColumn: "Id",
                keyValue: 22,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 6, 16, 15, 36, 32, 263, DateTimeKind.Local).AddTicks(3092), new DateTime(2026, 6, 16, 15, 36, 32, 263, DateTimeKind.Local).AddTicks(3093) });

            migrationBuilder.UpdateData(
                table: "Modules",
                keyColumn: "Id",
                keyValue: 23,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 6, 16, 15, 36, 32, 263, DateTimeKind.Local).AddTicks(3094), new DateTime(2026, 6, 16, 15, 36, 32, 263, DateTimeKind.Local).AddTicks(3094) });

            migrationBuilder.UpdateData(
                table: "Modules",
                keyColumn: "Id",
                keyValue: 24,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 6, 16, 15, 36, 32, 263, DateTimeKind.Local).AddTicks(3096), new DateTime(2026, 6, 16, 15, 36, 32, 263, DateTimeKind.Local).AddTicks(3096) });

            migrationBuilder.UpdateData(
                table: "Modules",
                keyColumn: "Id",
                keyValue: 25,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 6, 16, 15, 36, 32, 263, DateTimeKind.Local).AddTicks(3097), new DateTime(2026, 6, 16, 15, 36, 32, 263, DateTimeKind.Local).AddTicks(3097) });

            migrationBuilder.UpdateData(
                table: "Modules",
                keyColumn: "Id",
                keyValue: 26,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 6, 16, 15, 36, 32, 263, DateTimeKind.Local).AddTicks(3098), new DateTime(2026, 6, 16, 15, 36, 32, 263, DateTimeKind.Local).AddTicks(3099) });

            migrationBuilder.UpdateData(
                table: "Modules",
                keyColumn: "Id",
                keyValue: 27,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 6, 16, 15, 36, 32, 263, DateTimeKind.Local).AddTicks(3100), new DateTime(2026, 6, 16, 15, 36, 32, 263, DateTimeKind.Local).AddTicks(3100) });

            migrationBuilder.UpdateData(
                table: "Modules",
                keyColumn: "Id",
                keyValue: 28,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 6, 16, 15, 36, 32, 263, DateTimeKind.Local).AddTicks(3101), new DateTime(2026, 6, 16, 15, 36, 32, 263, DateTimeKind.Local).AddTicks(3102) });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 6, 16, 15, 36, 32, 263, DateTimeKind.Local).AddTicks(2094), new DateTime(2026, 6, 16, 15, 36, 32, 263, DateTimeKind.Local).AddTicks(2108) });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 6, 16, 15, 36, 32, 263, DateTimeKind.Local).AddTicks(2109), new DateTime(2026, 6, 16, 15, 36, 32, 263, DateTimeKind.Local).AddTicks(2110) });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 6, 16, 15, 36, 32, 263, DateTimeKind.Local).AddTicks(2111), new DateTime(2026, 6, 16, 15, 36, 32, 263, DateTimeKind.Local).AddTicks(2111) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "PasswordHash", "PasswordSalt" },
                values: new object[] { new byte[] { 108, 248, 228, 138, 107, 229, 30, 166, 18, 217, 16, 112, 5, 208, 235, 46, 68, 115, 53, 105, 231, 243, 90, 84, 226, 100, 245, 78, 133, 125, 91, 101, 235, 112, 40, 1, 175, 168, 91, 88, 236, 157, 123, 23, 48, 158, 127, 100, 100, 202, 231, 20, 12, 8, 169, 3, 92, 135, 48, 104, 228, 111, 232, 172 }, new byte[] { 146, 84, 180, 242, 4, 119, 254, 250, 184, 184, 80, 176, 94, 44, 10, 94, 196, 77, 43, 160, 28, 37, 251, 215, 207, 245, 84, 43, 152, 98, 71, 225, 173, 89, 65, 42, 109, 197, 71, 252, 175, 30, 108, 139, 157, 40, 192, 156, 81, 63, 22, 159, 18, 176, 42, 121, 47, 227, 115, 194, 103, 55, 170, 116, 229, 130, 114, 242, 161, 57, 143, 210, 29, 210, 44, 74, 165, 186, 111, 54, 238, 195, 181, 141, 51, 88, 153, 118, 252, 37, 0, 96, 133, 93, 66, 149, 191, 175, 231, 250, 13, 227, 230, 232, 125, 159, 10, 90, 146, 101, 120, 195, 25, 240, 186, 251, 1, 243, 204, 6, 149, 177, 129, 174, 68, 31, 69, 3 } });
        }
    }
}
