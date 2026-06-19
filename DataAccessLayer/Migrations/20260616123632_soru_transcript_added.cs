using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DataAccessLayer.Migrations
{
    /// <inheritdoc />
    public partial class soru_transcript_added : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "VideoTranscript",
                table: "Sorus",
                type: "text",
                nullable: true);

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

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "VideoTranscript",
                table: "Sorus");

            migrationBuilder.UpdateData(
                table: "ModuleRoles",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 6, 5, 13, 19, 45, 921, DateTimeKind.Local).AddTicks(2819), new DateTime(2026, 6, 5, 13, 19, 45, 921, DateTimeKind.Local).AddTicks(2820) });

            migrationBuilder.UpdateData(
                table: "ModuleRoles",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 6, 5, 13, 19, 45, 921, DateTimeKind.Local).AddTicks(2821), new DateTime(2026, 6, 5, 13, 19, 45, 921, DateTimeKind.Local).AddTicks(2821) });

            migrationBuilder.UpdateData(
                table: "ModuleRoles",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 6, 5, 13, 19, 45, 921, DateTimeKind.Local).AddTicks(2822), new DateTime(2026, 6, 5, 13, 19, 45, 921, DateTimeKind.Local).AddTicks(2823) });

            migrationBuilder.UpdateData(
                table: "ModuleRoles",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 6, 5, 13, 19, 45, 921, DateTimeKind.Local).AddTicks(2824), new DateTime(2026, 6, 5, 13, 19, 45, 921, DateTimeKind.Local).AddTicks(2824) });

            migrationBuilder.UpdateData(
                table: "ModuleRoles",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 6, 5, 13, 19, 45, 921, DateTimeKind.Local).AddTicks(2825), new DateTime(2026, 6, 5, 13, 19, 45, 921, DateTimeKind.Local).AddTicks(2826) });

            migrationBuilder.UpdateData(
                table: "ModuleRoles",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 6, 5, 13, 19, 45, 921, DateTimeKind.Local).AddTicks(2826), new DateTime(2026, 6, 5, 13, 19, 45, 921, DateTimeKind.Local).AddTicks(2827) });

            migrationBuilder.UpdateData(
                table: "ModuleRoles",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 6, 5, 13, 19, 45, 921, DateTimeKind.Local).AddTicks(2828), new DateTime(2026, 6, 5, 13, 19, 45, 921, DateTimeKind.Local).AddTicks(2828) });

            migrationBuilder.UpdateData(
                table: "ModuleRoles",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 6, 5, 13, 19, 45, 921, DateTimeKind.Local).AddTicks(2829), new DateTime(2026, 6, 5, 13, 19, 45, 921, DateTimeKind.Local).AddTicks(2830) });

            migrationBuilder.UpdateData(
                table: "ModuleRoles",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 6, 5, 13, 19, 45, 921, DateTimeKind.Local).AddTicks(2831), new DateTime(2026, 6, 5, 13, 19, 45, 921, DateTimeKind.Local).AddTicks(2831) });

            migrationBuilder.UpdateData(
                table: "ModuleRoles",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 6, 5, 13, 19, 45, 921, DateTimeKind.Local).AddTicks(2832), new DateTime(2026, 6, 5, 13, 19, 45, 921, DateTimeKind.Local).AddTicks(2832) });

            migrationBuilder.UpdateData(
                table: "ModuleRoles",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 6, 5, 13, 19, 45, 921, DateTimeKind.Local).AddTicks(2833), new DateTime(2026, 6, 5, 13, 19, 45, 921, DateTimeKind.Local).AddTicks(2834) });

            migrationBuilder.UpdateData(
                table: "ModuleRoles",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 6, 5, 13, 19, 45, 921, DateTimeKind.Local).AddTicks(2835), new DateTime(2026, 6, 5, 13, 19, 45, 921, DateTimeKind.Local).AddTicks(2835) });

            migrationBuilder.UpdateData(
                table: "ModuleRoles",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 6, 5, 13, 19, 45, 921, DateTimeKind.Local).AddTicks(2837), new DateTime(2026, 6, 5, 13, 19, 45, 921, DateTimeKind.Local).AddTicks(2837) });

            migrationBuilder.UpdateData(
                table: "ModuleRoles",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 6, 5, 13, 19, 45, 921, DateTimeKind.Local).AddTicks(2838), new DateTime(2026, 6, 5, 13, 19, 45, 921, DateTimeKind.Local).AddTicks(2839) });

            migrationBuilder.UpdateData(
                table: "ModuleRoles",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 6, 5, 13, 19, 45, 921, DateTimeKind.Local).AddTicks(2840), new DateTime(2026, 6, 5, 13, 19, 45, 921, DateTimeKind.Local).AddTicks(2840) });

            migrationBuilder.UpdateData(
                table: "ModuleRoles",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 6, 5, 13, 19, 45, 921, DateTimeKind.Local).AddTicks(2841), new DateTime(2026, 6, 5, 13, 19, 45, 921, DateTimeKind.Local).AddTicks(2842) });

            migrationBuilder.UpdateData(
                table: "ModuleRoles",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 6, 5, 13, 19, 45, 921, DateTimeKind.Local).AddTicks(2844), new DateTime(2026, 6, 5, 13, 19, 45, 921, DateTimeKind.Local).AddTicks(2844) });

            migrationBuilder.UpdateData(
                table: "ModuleRoles",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 6, 5, 13, 19, 45, 921, DateTimeKind.Local).AddTicks(2845), new DateTime(2026, 6, 5, 13, 19, 45, 921, DateTimeKind.Local).AddTicks(2846) });

            migrationBuilder.UpdateData(
                table: "ModuleRoles",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 6, 5, 13, 19, 45, 921, DateTimeKind.Local).AddTicks(2847), new DateTime(2026, 6, 5, 13, 19, 45, 921, DateTimeKind.Local).AddTicks(2847) });

            migrationBuilder.UpdateData(
                table: "ModuleRoles",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 6, 5, 13, 19, 45, 921, DateTimeKind.Local).AddTicks(2848), new DateTime(2026, 6, 5, 13, 19, 45, 921, DateTimeKind.Local).AddTicks(2848) });

            migrationBuilder.UpdateData(
                table: "ModuleRoles",
                keyColumn: "Id",
                keyValue: 21,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 6, 5, 13, 19, 45, 921, DateTimeKind.Local).AddTicks(2849), new DateTime(2026, 6, 5, 13, 19, 45, 921, DateTimeKind.Local).AddTicks(2850) });

            migrationBuilder.UpdateData(
                table: "ModuleRoles",
                keyColumn: "Id",
                keyValue: 22,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 6, 5, 13, 19, 45, 921, DateTimeKind.Local).AddTicks(2851), new DateTime(2026, 6, 5, 13, 19, 45, 921, DateTimeKind.Local).AddTicks(2851) });

            migrationBuilder.UpdateData(
                table: "ModuleRoles",
                keyColumn: "Id",
                keyValue: 23,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 6, 5, 13, 19, 45, 921, DateTimeKind.Local).AddTicks(2852), new DateTime(2026, 6, 5, 13, 19, 45, 921, DateTimeKind.Local).AddTicks(2852) });

            migrationBuilder.UpdateData(
                table: "ModuleRoles",
                keyColumn: "Id",
                keyValue: 24,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 6, 5, 13, 19, 45, 921, DateTimeKind.Local).AddTicks(2853), new DateTime(2026, 6, 5, 13, 19, 45, 921, DateTimeKind.Local).AddTicks(2854) });

            migrationBuilder.UpdateData(
                table: "ModuleRoles",
                keyColumn: "Id",
                keyValue: 25,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 6, 5, 13, 19, 45, 921, DateTimeKind.Local).AddTicks(2855), new DateTime(2026, 6, 5, 13, 19, 45, 921, DateTimeKind.Local).AddTicks(2855) });

            migrationBuilder.UpdateData(
                table: "ModuleRoles",
                keyColumn: "Id",
                keyValue: 26,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 6, 5, 13, 19, 45, 921, DateTimeKind.Local).AddTicks(3018), new DateTime(2026, 6, 5, 13, 19, 45, 921, DateTimeKind.Local).AddTicks(3019) });

            migrationBuilder.UpdateData(
                table: "ModuleRoles",
                keyColumn: "Id",
                keyValue: 27,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 6, 5, 13, 19, 45, 921, DateTimeKind.Local).AddTicks(3020), new DateTime(2026, 6, 5, 13, 19, 45, 921, DateTimeKind.Local).AddTicks(3021) });

            migrationBuilder.UpdateData(
                table: "ModuleRoles",
                keyColumn: "Id",
                keyValue: 28,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 6, 5, 13, 19, 45, 921, DateTimeKind.Local).AddTicks(3022), new DateTime(2026, 6, 5, 13, 19, 45, 921, DateTimeKind.Local).AddTicks(3022) });

            migrationBuilder.UpdateData(
                table: "Modules",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 6, 5, 13, 19, 45, 921, DateTimeKind.Local).AddTicks(2738), new DateTime(2026, 6, 5, 13, 19, 45, 921, DateTimeKind.Local).AddTicks(2740) });

            migrationBuilder.UpdateData(
                table: "Modules",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 6, 5, 13, 19, 45, 921, DateTimeKind.Local).AddTicks(2743), new DateTime(2026, 6, 5, 13, 19, 45, 921, DateTimeKind.Local).AddTicks(2744) });

            migrationBuilder.UpdateData(
                table: "Modules",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 6, 5, 13, 19, 45, 921, DateTimeKind.Local).AddTicks(2746), new DateTime(2026, 6, 5, 13, 19, 45, 921, DateTimeKind.Local).AddTicks(2746) });

            migrationBuilder.UpdateData(
                table: "Modules",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 6, 5, 13, 19, 45, 921, DateTimeKind.Local).AddTicks(2748), new DateTime(2026, 6, 5, 13, 19, 45, 921, DateTimeKind.Local).AddTicks(2748) });

            migrationBuilder.UpdateData(
                table: "Modules",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 6, 5, 13, 19, 45, 921, DateTimeKind.Local).AddTicks(2750), new DateTime(2026, 6, 5, 13, 19, 45, 921, DateTimeKind.Local).AddTicks(2750) });

            migrationBuilder.UpdateData(
                table: "Modules",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 6, 5, 13, 19, 45, 921, DateTimeKind.Local).AddTicks(2751), new DateTime(2026, 6, 5, 13, 19, 45, 921, DateTimeKind.Local).AddTicks(2752) });

            migrationBuilder.UpdateData(
                table: "Modules",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 6, 5, 13, 19, 45, 921, DateTimeKind.Local).AddTicks(2753), new DateTime(2026, 6, 5, 13, 19, 45, 921, DateTimeKind.Local).AddTicks(2754) });

            migrationBuilder.UpdateData(
                table: "Modules",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 6, 5, 13, 19, 45, 921, DateTimeKind.Local).AddTicks(2755), new DateTime(2026, 6, 5, 13, 19, 45, 921, DateTimeKind.Local).AddTicks(2755) });

            migrationBuilder.UpdateData(
                table: "Modules",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 6, 5, 13, 19, 45, 921, DateTimeKind.Local).AddTicks(2757), new DateTime(2026, 6, 5, 13, 19, 45, 921, DateTimeKind.Local).AddTicks(2757) });

            migrationBuilder.UpdateData(
                table: "Modules",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 6, 5, 13, 19, 45, 921, DateTimeKind.Local).AddTicks(2758), new DateTime(2026, 6, 5, 13, 19, 45, 921, DateTimeKind.Local).AddTicks(2759) });

            migrationBuilder.UpdateData(
                table: "Modules",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 6, 5, 13, 19, 45, 921, DateTimeKind.Local).AddTicks(2760), new DateTime(2026, 6, 5, 13, 19, 45, 921, DateTimeKind.Local).AddTicks(2761) });

            migrationBuilder.UpdateData(
                table: "Modules",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 6, 5, 13, 19, 45, 921, DateTimeKind.Local).AddTicks(2762), new DateTime(2026, 6, 5, 13, 19, 45, 921, DateTimeKind.Local).AddTicks(2765) });

            migrationBuilder.UpdateData(
                table: "Modules",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 6, 5, 13, 19, 45, 921, DateTimeKind.Local).AddTicks(2767), new DateTime(2026, 6, 5, 13, 19, 45, 921, DateTimeKind.Local).AddTicks(2767) });

            migrationBuilder.UpdateData(
                table: "Modules",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 6, 5, 13, 19, 45, 921, DateTimeKind.Local).AddTicks(2768), new DateTime(2026, 6, 5, 13, 19, 45, 921, DateTimeKind.Local).AddTicks(2769) });

            migrationBuilder.UpdateData(
                table: "Modules",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 6, 5, 13, 19, 45, 921, DateTimeKind.Local).AddTicks(2770), new DateTime(2026, 6, 5, 13, 19, 45, 921, DateTimeKind.Local).AddTicks(2771) });

            migrationBuilder.UpdateData(
                table: "Modules",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 6, 5, 13, 19, 45, 921, DateTimeKind.Local).AddTicks(2772), new DateTime(2026, 6, 5, 13, 19, 45, 921, DateTimeKind.Local).AddTicks(2772) });

            migrationBuilder.UpdateData(
                table: "Modules",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 6, 5, 13, 19, 45, 921, DateTimeKind.Local).AddTicks(2774), new DateTime(2026, 6, 5, 13, 19, 45, 921, DateTimeKind.Local).AddTicks(2774) });

            migrationBuilder.UpdateData(
                table: "Modules",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 6, 5, 13, 19, 45, 921, DateTimeKind.Local).AddTicks(2775), new DateTime(2026, 6, 5, 13, 19, 45, 921, DateTimeKind.Local).AddTicks(2776) });

            migrationBuilder.UpdateData(
                table: "Modules",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 6, 5, 13, 19, 45, 921, DateTimeKind.Local).AddTicks(2777), new DateTime(2026, 6, 5, 13, 19, 45, 921, DateTimeKind.Local).AddTicks(2777) });

            migrationBuilder.UpdateData(
                table: "Modules",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 6, 5, 13, 19, 45, 921, DateTimeKind.Local).AddTicks(2779), new DateTime(2026, 6, 5, 13, 19, 45, 921, DateTimeKind.Local).AddTicks(2779) });

            migrationBuilder.UpdateData(
                table: "Modules",
                keyColumn: "Id",
                keyValue: 21,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 6, 5, 13, 19, 45, 921, DateTimeKind.Local).AddTicks(2781), new DateTime(2026, 6, 5, 13, 19, 45, 921, DateTimeKind.Local).AddTicks(2782) });

            migrationBuilder.UpdateData(
                table: "Modules",
                keyColumn: "Id",
                keyValue: 22,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 6, 5, 13, 19, 45, 921, DateTimeKind.Local).AddTicks(2783), new DateTime(2026, 6, 5, 13, 19, 45, 921, DateTimeKind.Local).AddTicks(2783) });

            migrationBuilder.UpdateData(
                table: "Modules",
                keyColumn: "Id",
                keyValue: 23,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 6, 5, 13, 19, 45, 921, DateTimeKind.Local).AddTicks(2785), new DateTime(2026, 6, 5, 13, 19, 45, 921, DateTimeKind.Local).AddTicks(2785) });

            migrationBuilder.UpdateData(
                table: "Modules",
                keyColumn: "Id",
                keyValue: 24,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 6, 5, 13, 19, 45, 921, DateTimeKind.Local).AddTicks(2786), new DateTime(2026, 6, 5, 13, 19, 45, 921, DateTimeKind.Local).AddTicks(2787) });

            migrationBuilder.UpdateData(
                table: "Modules",
                keyColumn: "Id",
                keyValue: 25,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 6, 5, 13, 19, 45, 921, DateTimeKind.Local).AddTicks(2788), new DateTime(2026, 6, 5, 13, 19, 45, 921, DateTimeKind.Local).AddTicks(2789) });

            migrationBuilder.UpdateData(
                table: "Modules",
                keyColumn: "Id",
                keyValue: 26,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 6, 5, 13, 19, 45, 921, DateTimeKind.Local).AddTicks(2790), new DateTime(2026, 6, 5, 13, 19, 45, 921, DateTimeKind.Local).AddTicks(2790) });

            migrationBuilder.UpdateData(
                table: "Modules",
                keyColumn: "Id",
                keyValue: 27,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 6, 5, 13, 19, 45, 921, DateTimeKind.Local).AddTicks(2792), new DateTime(2026, 6, 5, 13, 19, 45, 921, DateTimeKind.Local).AddTicks(2792) });

            migrationBuilder.UpdateData(
                table: "Modules",
                keyColumn: "Id",
                keyValue: 28,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 6, 5, 13, 19, 45, 921, DateTimeKind.Local).AddTicks(2793), new DateTime(2026, 6, 5, 13, 19, 45, 921, DateTimeKind.Local).AddTicks(2794) });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 6, 5, 13, 19, 45, 921, DateTimeKind.Local).AddTicks(1672), new DateTime(2026, 6, 5, 13, 19, 45, 921, DateTimeKind.Local).AddTicks(1685) });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 6, 5, 13, 19, 45, 921, DateTimeKind.Local).AddTicks(1687), new DateTime(2026, 6, 5, 13, 19, 45, 921, DateTimeKind.Local).AddTicks(1687) });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 6, 5, 13, 19, 45, 921, DateTimeKind.Local).AddTicks(1688), new DateTime(2026, 6, 5, 13, 19, 45, 921, DateTimeKind.Local).AddTicks(1689) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "PasswordHash", "PasswordSalt" },
                values: new object[] { new byte[] { 43, 142, 144, 18, 187, 111, 10, 75, 252, 141, 0, 112, 140, 177, 217, 68, 232, 82, 60, 172, 149, 8, 244, 88, 40, 105, 134, 152, 19, 237, 158, 250, 134, 224, 237, 94, 243, 26, 220, 95, 3, 46, 216, 178, 77, 109, 166, 242, 152, 73, 18, 13, 146, 103, 248, 9, 69, 61, 216, 30, 82, 92, 102, 105 }, new byte[] { 21, 59, 203, 84, 204, 11, 65, 99, 179, 118, 220, 170, 161, 23, 99, 240, 119, 242, 4, 72, 103, 231, 19, 174, 225, 59, 161, 75, 163, 5, 102, 34, 49, 255, 166, 192, 225, 230, 82, 120, 87, 134, 255, 231, 138, 28, 61, 161, 152, 199, 243, 214, 97, 176, 159, 241, 53, 244, 222, 102, 142, 64, 159, 101, 62, 241, 208, 175, 215, 7, 42, 36, 115, 189, 62, 106, 245, 102, 174, 249, 237, 233, 169, 30, 0, 78, 224, 24, 89, 80, 21, 203, 18, 242, 125, 160, 119, 177, 241, 180, 34, 206, 241, 3, 113, 148, 182, 99, 107, 50, 170, 223, 161, 196, 172, 215, 47, 20, 48, 229, 204, 4, 222, 75, 142, 117, 66, 140 } });
        }
    }
}
