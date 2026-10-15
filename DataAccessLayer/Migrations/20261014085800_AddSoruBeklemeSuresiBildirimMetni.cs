using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DataAccessLayer.Migrations
{
    /// <inheritdoc />
    public partial class AddSoruBeklemeSuresiBildirimMetni : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "BeklemeSuresi",
                table: "Sorus",
                type: "integer",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "BildirimMetni",
                table: "Sorus",
                type: "text",
                nullable: true);

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

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "BeklemeSuresi",
                table: "Sorus");

            migrationBuilder.DropColumn(
                name: "BildirimMetni",
                table: "Sorus");

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
    }
}
