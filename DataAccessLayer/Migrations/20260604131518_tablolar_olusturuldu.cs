using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace DataAccessLayer.Migrations
{
    /// <inheritdoc />
    public partial class tablolar_olusturuldu : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "ModuleRoles",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "ModuleRoles",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "ModuleRoles",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "ModuleRoles",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "ModuleRoles",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "ModuleRoles",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "ModuleRoles",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "ModuleRoles",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "ModuleRoles",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "ModuleRoles",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "ModuleRoles",
                keyColumn: "Id",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "ModuleRoles",
                keyColumn: "Id",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "ModuleRoles",
                keyColumn: "Id",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "ModuleRoles",
                keyColumn: "Id",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "ModuleRoles",
                keyColumn: "Id",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "ModuleRoles",
                keyColumn: "Id",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "ModuleRoles",
                keyColumn: "Id",
                keyValue: 17);

            migrationBuilder.DeleteData(
                table: "ModuleRoles",
                keyColumn: "Id",
                keyValue: 18);

            migrationBuilder.DeleteData(
                table: "Modules",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Modules",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Modules",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Modules",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Modules",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Modules",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Modules",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Modules",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Modules",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Modules",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Modules",
                keyColumn: "Id",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "Modules",
                keyColumn: "Id",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "Modules",
                keyColumn: "Id",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "Modules",
                keyColumn: "Id",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "Modules",
                keyColumn: "Id",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "Modules",
                keyColumn: "Id",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "Modules",
                keyColumn: "Id",
                keyValue: 17);

            migrationBuilder.DeleteData(
                table: "Modules",
                keyColumn: "Id",
                keyValue: 18);

            migrationBuilder.RenameColumn(
                name: "BirthDate",
                table: "Users",
                newName: "UserName");

            migrationBuilder.AddColumn<bool>(
                name: "CozumlemeTamamlandiMi",
                table: "Users",
                type: "boolean",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<string>(
                name: "Name",
                table: "Users",
                type: "text",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "OgrenciNo",
                table: "Users",
                type: "text",
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "SimulasyonTamamlandiMi",
                table: "Users",
                type: "boolean",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<string>(
                name: "Surname",
                table: "Users",
                type: "text",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "ToplamPuan",
                table: "Users",
                type: "integer",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "CozumlemeSoruUsers",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    UserId = table.Column<int>(type: "integer", nullable: false),
                    Asama = table.Column<string>(type: "text", nullable: true),
                    SoruCevap = table.Column<List<Dictionary<string, string>>>(type: "jsonb", nullable: true),
                    CreatedAt = table.Column<DateTime>(type: "timestamp without time zone", nullable: true),
                    UpdatedAt = table.Column<DateTime>(type: "timestamp without time zone", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CozumlemeSoruUsers", x => x.Id);
                    table.ForeignKey(
                        name: "FK_CozumlemeSoruUsers_Users_UserId",
                        column: x => x.UserId,
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Sorus",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    VideoPath = table.Column<string>(type: "text", nullable: true),
                    Hedef = table.Column<string>(type: "text", nullable: true),
                    OlcekMaddesi = table.Column<string>(type: "text", nullable: true),
                    SoruMetni = table.Column<string>(type: "text", nullable: true),
                    Cevaplar = table.Column<List<Dictionary<string, string>>>(type: "jsonb", nullable: true),
                    DogruCevap = table.Column<Dictionary<string, string>>(type: "jsonb", nullable: true),
                    CreatedAt = table.Column<DateTime>(type: "timestamp without time zone", nullable: true),
                    UpdatedAt = table.Column<DateTime>(type: "timestamp without time zone", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Sorus", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "SoruUsers",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    SoruId = table.Column<int>(type: "integer", nullable: false),
                    UserId = table.Column<int>(type: "integer", nullable: false),
                    VerilenCevap = table.Column<string>(type: "text", nullable: true),
                    Puan = table.Column<int>(type: "integer", nullable: true),
                    CreatedAt = table.Column<DateTime>(type: "timestamp without time zone", nullable: true),
                    UpdatedAt = table.Column<DateTime>(type: "timestamp without time zone", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SoruUsers", x => x.Id);
                    table.ForeignKey(
                        name: "FK_SoruUsers_Sorus_SoruId",
                        column: x => x.SoruId,
                        principalTable: "Sorus",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_SoruUsers_Users_UserId",
                        column: x => x.UserId,
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Modules",
                columns: new[] { "Id", "Action", "Address", "Controller", "CreatedAt", "Icon", "Menu", "Name", "ParentId", "Type", "UpdatedAt" },
                values: new object[,]
                {
                    { 21, "/kullanici_detay", "/User/Detail", "User", new DateTime(2026, 6, 4, 16, 15, 18, 249, DateTimeKind.Local).AddTicks(7198), "", 0, "Kullanıcı Detay", 16, "Feature", new DateTime(2026, 6, 4, 16, 15, 18, 249, DateTimeKind.Local).AddTicks(7200) },
                    { 22, "Detail", "/User/Detail", "User", new DateTime(2026, 6, 4, 16, 15, 18, 249, DateTimeKind.Local).AddTicks(7202), "", 0, "User Detail", 16, "Feature", new DateTime(2026, 6, 4, 16, 15, 18, 249, DateTimeKind.Local).AddTicks(7202) },
                    { 23, "GetUsers", "/User/GetUsers", "User", new DateTime(2026, 6, 4, 16, 15, 18, 249, DateTimeKind.Local).AddTicks(7203), "", 0, "User GetUsers", 16, "Feature", new DateTime(2026, 6, 4, 16, 15, 18, 249, DateTimeKind.Local).AddTicks(7204) },
                    { 24, "GetUserById", "/User/GetUserById", "User", new DateTime(2026, 6, 4, 16, 15, 18, 249, DateTimeKind.Local).AddTicks(7205), "", 0, "User GetById", 16, "Feature", new DateTime(2026, 6, 4, 16, 15, 18, 249, DateTimeKind.Local).AddTicks(7206) },
                    { 25, "CreateUser", "/User/CreateUser", "User", new DateTime(2026, 6, 4, 16, 15, 18, 249, DateTimeKind.Local).AddTicks(7207), "", 0, "User CreateUser", 16, "Feature", new DateTime(2026, 6, 4, 16, 15, 18, 249, DateTimeKind.Local).AddTicks(7207) },
                    { 26, "UpdateUser", "/User/UpdateUser", "User", new DateTime(2026, 6, 4, 16, 15, 18, 249, DateTimeKind.Local).AddTicks(7208), "", 0, "User UpdateUser", 16, "Feature", new DateTime(2026, 6, 4, 16, 15, 18, 249, DateTimeKind.Local).AddTicks(7209) },
                    { 27, "DeleteUser", "/User/DeleteUser", "User", new DateTime(2026, 6, 4, 16, 15, 18, 249, DateTimeKind.Local).AddTicks(7210), "", 0, "User DeleteUser", 16, "Feature", new DateTime(2026, 6, 4, 16, 15, 18, 249, DateTimeKind.Local).AddTicks(7211) },
                    { 28, "ResetPassword", "/User/ResetPassword", "User", new DateTime(2026, 6, 4, 16, 15, 18, 249, DateTimeKind.Local).AddTicks(7212), "", 0, "User ResetPassword", 16, "Feature", new DateTime(2026, 6, 4, 16, 15, 18, 249, DateTimeKind.Local).AddTicks(7212) }
                });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 6, 4, 16, 15, 18, 249, DateTimeKind.Local).AddTicks(6352), new DateTime(2026, 6, 4, 16, 15, 18, 249, DateTimeKind.Local).AddTicks(6362) });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 6, 4, 16, 15, 18, 249, DateTimeKind.Local).AddTicks(6364), new DateTime(2026, 6, 4, 16, 15, 18, 249, DateTimeKind.Local).AddTicks(6364) });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 6, 4, 16, 15, 18, 249, DateTimeKind.Local).AddTicks(6365), new DateTime(2026, 6, 4, 16, 15, 18, 249, DateTimeKind.Local).AddTicks(6366) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Name", "OgrenciNo", "PasswordHash", "PasswordSalt", "Surname", "ToplamPuan" },
                values: new object[] { null, null, new byte[] { 81, 242, 69, 158, 245, 48, 179, 239, 24, 65, 37, 17, 119, 102, 34, 103, 248, 10, 31, 225, 148, 147, 32, 149, 235, 20, 172, 1, 127, 9, 48, 212, 219, 173, 162, 67, 179, 210, 198, 155, 230, 242, 106, 88, 209, 185, 119, 34, 5, 44, 202, 211, 177, 217, 158, 61, 180, 185, 106, 188, 31, 144, 2, 50 }, new byte[] { 115, 150, 60, 162, 20, 173, 36, 117, 31, 201, 163, 222, 228, 41, 140, 34, 68, 104, 157, 14, 177, 219, 225, 99, 22, 89, 188, 9, 56, 42, 25, 65, 42, 200, 201, 42, 59, 1, 186, 56, 245, 144, 41, 221, 122, 96, 179, 155, 245, 191, 115, 106, 171, 242, 194, 16, 27, 17, 140, 205, 180, 14, 72, 100, 68, 244, 193, 139, 206, 197, 81, 106, 242, 151, 23, 54, 67, 25, 109, 7, 153, 152, 201, 27, 58, 219, 14, 4, 75, 94, 196, 235, 159, 232, 229, 30, 25, 189, 14, 229, 183, 251, 27, 161, 87, 252, 52, 242, 146, 242, 204, 213, 220, 209, 179, 244, 145, 254, 151, 45, 25, 65, 166, 113, 48, 10, 245, 200 }, null, null });

            migrationBuilder.InsertData(
                table: "ModuleRoles",
                columns: new[] { "Id", "CreatedAt", "ModuleId", "RolId", "UpdatedAt", "UserId" },
                values: new object[,]
                {
                    { 21, new DateTime(2026, 6, 4, 16, 15, 18, 249, DateTimeKind.Local).AddTicks(7230), 21, 1, new DateTime(2026, 6, 4, 16, 15, 18, 249, DateTimeKind.Local).AddTicks(7230), 1 },
                    { 22, new DateTime(2026, 6, 4, 16, 15, 18, 249, DateTimeKind.Local).AddTicks(7231), 22, 1, new DateTime(2026, 6, 4, 16, 15, 18, 249, DateTimeKind.Local).AddTicks(7232), 1 },
                    { 23, new DateTime(2026, 6, 4, 16, 15, 18, 249, DateTimeKind.Local).AddTicks(7232), 23, 1, new DateTime(2026, 6, 4, 16, 15, 18, 249, DateTimeKind.Local).AddTicks(7233), 1 },
                    { 24, new DateTime(2026, 6, 4, 16, 15, 18, 249, DateTimeKind.Local).AddTicks(7234), 24, 1, new DateTime(2026, 6, 4, 16, 15, 18, 249, DateTimeKind.Local).AddTicks(7234), 1 },
                    { 25, new DateTime(2026, 6, 4, 16, 15, 18, 249, DateTimeKind.Local).AddTicks(7235), 25, 1, new DateTime(2026, 6, 4, 16, 15, 18, 249, DateTimeKind.Local).AddTicks(7235), 1 },
                    { 26, new DateTime(2026, 6, 4, 16, 15, 18, 249, DateTimeKind.Local).AddTicks(7236), 26, 1, new DateTime(2026, 6, 4, 16, 15, 18, 249, DateTimeKind.Local).AddTicks(7236), 1 },
                    { 27, new DateTime(2026, 6, 4, 16, 15, 18, 249, DateTimeKind.Local).AddTicks(7237), 27, 1, new DateTime(2026, 6, 4, 16, 15, 18, 249, DateTimeKind.Local).AddTicks(7238), 1 },
                    { 28, new DateTime(2026, 6, 4, 16, 15, 18, 249, DateTimeKind.Local).AddTicks(7238), 28, 1, new DateTime(2026, 6, 4, 16, 15, 18, 249, DateTimeKind.Local).AddTicks(7239), 1 }
                });

            migrationBuilder.CreateIndex(
                name: "IX_CozumlemeSoruUsers_UserId",
                table: "CozumlemeSoruUsers",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_SoruUsers_SoruId",
                table: "SoruUsers",
                column: "SoruId");

            migrationBuilder.CreateIndex(
                name: "IX_SoruUsers_UserId",
                table: "SoruUsers",
                column: "UserId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "CozumlemeSoruUsers");

            migrationBuilder.DropTable(
                name: "SoruUsers");

            migrationBuilder.DropTable(
                name: "Sorus");

            migrationBuilder.DeleteData(
                table: "ModuleRoles",
                keyColumn: "Id",
                keyValue: 21);

            migrationBuilder.DeleteData(
                table: "ModuleRoles",
                keyColumn: "Id",
                keyValue: 22);

            migrationBuilder.DeleteData(
                table: "ModuleRoles",
                keyColumn: "Id",
                keyValue: 23);

            migrationBuilder.DeleteData(
                table: "ModuleRoles",
                keyColumn: "Id",
                keyValue: 24);

            migrationBuilder.DeleteData(
                table: "ModuleRoles",
                keyColumn: "Id",
                keyValue: 25);

            migrationBuilder.DeleteData(
                table: "ModuleRoles",
                keyColumn: "Id",
                keyValue: 26);

            migrationBuilder.DeleteData(
                table: "ModuleRoles",
                keyColumn: "Id",
                keyValue: 27);

            migrationBuilder.DeleteData(
                table: "ModuleRoles",
                keyColumn: "Id",
                keyValue: 28);

            migrationBuilder.DeleteData(
                table: "Modules",
                keyColumn: "Id",
                keyValue: 21);

            migrationBuilder.DeleteData(
                table: "Modules",
                keyColumn: "Id",
                keyValue: 22);

            migrationBuilder.DeleteData(
                table: "Modules",
                keyColumn: "Id",
                keyValue: 23);

            migrationBuilder.DeleteData(
                table: "Modules",
                keyColumn: "Id",
                keyValue: 24);

            migrationBuilder.DeleteData(
                table: "Modules",
                keyColumn: "Id",
                keyValue: 25);

            migrationBuilder.DeleteData(
                table: "Modules",
                keyColumn: "Id",
                keyValue: 26);

            migrationBuilder.DeleteData(
                table: "Modules",
                keyColumn: "Id",
                keyValue: 27);

            migrationBuilder.DeleteData(
                table: "Modules",
                keyColumn: "Id",
                keyValue: 28);

            migrationBuilder.DropColumn(
                name: "CozumlemeTamamlandiMi",
                table: "Users");

            migrationBuilder.DropColumn(
                name: "Name",
                table: "Users");

            migrationBuilder.DropColumn(
                name: "OgrenciNo",
                table: "Users");

            migrationBuilder.DropColumn(
                name: "SimulasyonTamamlandiMi",
                table: "Users");

            migrationBuilder.DropColumn(
                name: "Surname",
                table: "Users");

            migrationBuilder.DropColumn(
                name: "ToplamPuan",
                table: "Users");

            migrationBuilder.RenameColumn(
                name: "UserName",
                table: "Users",
                newName: "BirthDate");

            migrationBuilder.InsertData(
                table: "Modules",
                columns: new[] { "Id", "Action", "Address", "Controller", "CreatedAt", "Icon", "Menu", "Name", "ParentId", "Type", "UpdatedAt" },
                values: new object[,]
                {
                    { 1, "Index", "/Home/Index", "Home", new DateTime(2026, 6, 4, 9, 25, 43, 644, DateTimeKind.Local).AddTicks(89), "fas fa-home", 1, "Ana Sayfa", 0, "Page", new DateTime(2026, 6, 4, 9, 25, 43, 644, DateTimeKind.Local).AddTicks(93) },
                    { 2, "Index", "/Role/Index", "Role", new DateTime(2026, 6, 4, 9, 25, 43, 644, DateTimeKind.Local).AddTicks(96), "icon-user-lock", 1, "Rol Yönetimi", 0, "Category", new DateTime(2026, 6, 4, 9, 25, 43, 644, DateTimeKind.Local).AddTicks(97) },
                    { 3, "Create", "/Role/Create", "Role", new DateTime(2026, 6, 4, 9, 25, 43, 644, DateTimeKind.Local).AddTicks(99), "", 1, "Rol Ekle", 2, "Page", new DateTime(2026, 6, 4, 9, 25, 43, 644, DateTimeKind.Local).AddTicks(100) },
                    { 4, "Edit", "/Role/Edit", "Role", new DateTime(2026, 6, 4, 9, 25, 43, 644, DateTimeKind.Local).AddTicks(102), "", 0, "Rol Düzenleme", 2, "Feature", new DateTime(2026, 6, 4, 9, 25, 43, 644, DateTimeKind.Local).AddTicks(102) },
                    { 5, "Delete", "/Role/Delete", "Role", new DateTime(2026, 6, 4, 9, 25, 43, 644, DateTimeKind.Local).AddTicks(104), "", 0, "Rol Silme", 2, "Feature", new DateTime(2026, 6, 4, 9, 25, 43, 644, DateTimeKind.Local).AddTicks(105) },
                    { 6, "GetById", "/Role/GetById", "Role", new DateTime(2026, 6, 4, 9, 25, 43, 644, DateTimeKind.Local).AddTicks(107), "", 0, "Id Bazlı Rol Getirme", 2, "Feature", new DateTime(2026, 6, 4, 9, 25, 43, 644, DateTimeKind.Local).AddTicks(107) },
                    { 7, "Index", "/Role/Index", "Role", new DateTime(2026, 6, 4, 9, 25, 43, 644, DateTimeKind.Local).AddTicks(109), "", 1, "Rol Listesi", 2, "Page", new DateTime(2026, 6, 4, 9, 25, 43, 644, DateTimeKind.Local).AddTicks(109) },
                    { 8, "GetList", "/Role/GetList", "Role", new DateTime(2026, 6, 4, 9, 25, 43, 644, DateTimeKind.Local).AddTicks(111), "", 0, "Rol Listesi", 2, "Page", new DateTime(2026, 6, 4, 9, 25, 43, 644, DateTimeKind.Local).AddTicks(112) },
                    { 9, "Authentication", "/Role/Authentication", "Role", new DateTime(2026, 6, 4, 9, 25, 43, 644, DateTimeKind.Local).AddTicks(191), "", 0, "Rol Yetkilendirme", 2, "Page", new DateTime(2026, 6, 4, 9, 25, 43, 644, DateTimeKind.Local).AddTicks(192) },
                    { 10, "Index", "/Module/Index", "Module", new DateTime(2026, 6, 4, 9, 25, 43, 644, DateTimeKind.Local).AddTicks(194), "fas fa-align-justify", 1, "Modül Yönetimi", 0, "Category", new DateTime(2026, 6, 4, 9, 25, 43, 644, DateTimeKind.Local).AddTicks(195) },
                    { 11, "Index", "/Module/Index", "Module", new DateTime(2026, 6, 4, 9, 25, 43, 644, DateTimeKind.Local).AddTicks(197), "", 1, "Modül Listesi", 10, "Page", new DateTime(2026, 6, 4, 9, 25, 43, 644, DateTimeKind.Local).AddTicks(198) },
                    { 12, "GetList", "/Module/GetList", "Module", new DateTime(2026, 6, 4, 9, 25, 43, 644, DateTimeKind.Local).AddTicks(199), "", 0, "Modül Listesi", 10, "Feature", new DateTime(2026, 6, 4, 9, 25, 43, 644, DateTimeKind.Local).AddTicks(200) },
                    { 13, "Delete", "/Module/Delete", "Module", new DateTime(2026, 6, 4, 9, 25, 43, 644, DateTimeKind.Local).AddTicks(202), "", 0, "Modül Silme", 10, "Feature", new DateTime(2026, 6, 4, 9, 25, 43, 644, DateTimeKind.Local).AddTicks(202) },
                    { 14, "GetById", "/Module/GetById", "Module", new DateTime(2026, 6, 4, 9, 25, 43, 644, DateTimeKind.Local).AddTicks(204), "", 10, "Id Bazlı Rol Getirmea", 3, "Feature", new DateTime(2026, 6, 4, 9, 25, 43, 644, DateTimeKind.Local).AddTicks(204) },
                    { 15, "Create", "/Module/Create", "Module", new DateTime(2026, 6, 4, 9, 25, 43, 644, DateTimeKind.Local).AddTicks(206), "", 1, "Modül Ekle", 10, "Page", new DateTime(2026, 6, 4, 9, 25, 43, 644, DateTimeKind.Local).AddTicks(207) },
                    { 16, "Index", "/Mail/Index", "Mail", new DateTime(2026, 6, 4, 9, 25, 43, 644, DateTimeKind.Local).AddTicks(208), "icon-mail5 mr-3", 1, "E-Posta Yönetimi", 16, "Category", new DateTime(2026, 6, 4, 9, 25, 43, 644, DateTimeKind.Local).AddTicks(209) },
                    { 17, "Index", "/Mail/Index", "Mail", new DateTime(2026, 6, 4, 9, 25, 43, 644, DateTimeKind.Local).AddTicks(210), "", 1, "E-Posta Listesi", 16, "Page", new DateTime(2026, 6, 4, 9, 25, 43, 644, DateTimeKind.Local).AddTicks(211) },
                    { 18, "GetList", "/Mail/GetList", "Mail", new DateTime(2026, 6, 4, 9, 25, 43, 644, DateTimeKind.Local).AddTicks(212), "", 0, "E-Posta Listesi", 16, "Feature", new DateTime(2026, 6, 4, 9, 25, 43, 644, DateTimeKind.Local).AddTicks(213) }
                });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 6, 4, 9, 25, 43, 643, DateTimeKind.Local).AddTicks(8718), new DateTime(2026, 6, 4, 9, 25, 43, 643, DateTimeKind.Local).AddTicks(8730) });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 6, 4, 9, 25, 43, 643, DateTimeKind.Local).AddTicks(8733), new DateTime(2026, 6, 4, 9, 25, 43, 643, DateTimeKind.Local).AddTicks(8734) });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 6, 4, 9, 25, 43, 643, DateTimeKind.Local).AddTicks(8735), new DateTime(2026, 6, 4, 9, 25, 43, 643, DateTimeKind.Local).AddTicks(8735) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "PasswordHash", "PasswordSalt" },
                values: new object[] { new byte[] { 243, 140, 44, 28, 19, 46, 225, 236, 163, 104, 164, 39, 122, 228, 47, 168, 165, 143, 110, 187, 149, 120, 165, 114, 52, 159, 240, 221, 57, 76, 37, 216, 109, 24, 231, 153, 18, 166, 77, 63, 33, 126, 127, 26, 120, 39, 147, 85, 229, 83, 72, 188, 40, 7, 178, 71, 39, 246, 9, 193, 18, 247, 139, 217 }, new byte[] { 216, 93, 211, 214, 24, 81, 233, 149, 40, 41, 131, 51, 228, 206, 105, 205, 147, 142, 216, 151, 85, 54, 111, 117, 41, 248, 121, 244, 155, 159, 208, 190, 150, 127, 50, 2, 69, 221, 135, 13, 148, 174, 148, 194, 116, 170, 28, 241, 251, 47, 33, 214, 25, 131, 24, 199, 167, 241, 138, 54, 237, 183, 250, 42, 36, 3, 251, 223, 113, 54, 215, 31, 245, 232, 223, 131, 203, 135, 57, 33, 93, 82, 4, 245, 144, 221, 5, 128, 151, 79, 31, 3, 97, 184, 239, 233, 84, 180, 51, 63, 44, 150, 202, 139, 14, 20, 30, 215, 9, 119, 161, 246, 115, 24, 8, 132, 194, 33, 186, 228, 140, 0, 235, 203, 192, 37, 110, 50 } });

            migrationBuilder.InsertData(
                table: "ModuleRoles",
                columns: new[] { "Id", "CreatedAt", "ModuleId", "RolId", "UpdatedAt", "UserId" },
                values: new object[,]
                {
                    { 1, new DateTime(2026, 6, 4, 9, 25, 43, 644, DateTimeKind.Local).AddTicks(261), 1, 1, new DateTime(2026, 6, 4, 9, 25, 43, 644, DateTimeKind.Local).AddTicks(263), 1 },
                    { 2, new DateTime(2026, 6, 4, 9, 25, 43, 644, DateTimeKind.Local).AddTicks(265), 2, 1, new DateTime(2026, 6, 4, 9, 25, 43, 644, DateTimeKind.Local).AddTicks(265), 1 },
                    { 3, new DateTime(2026, 6, 4, 9, 25, 43, 644, DateTimeKind.Local).AddTicks(267), 3, 1, new DateTime(2026, 6, 4, 9, 25, 43, 644, DateTimeKind.Local).AddTicks(267), 1 },
                    { 4, new DateTime(2026, 6, 4, 9, 25, 43, 644, DateTimeKind.Local).AddTicks(269), 4, 1, new DateTime(2026, 6, 4, 9, 25, 43, 644, DateTimeKind.Local).AddTicks(270), 1 },
                    { 5, new DateTime(2026, 6, 4, 9, 25, 43, 644, DateTimeKind.Local).AddTicks(271), 5, 1, new DateTime(2026, 6, 4, 9, 25, 43, 644, DateTimeKind.Local).AddTicks(272), 1 },
                    { 6, new DateTime(2026, 6, 4, 9, 25, 43, 644, DateTimeKind.Local).AddTicks(273), 6, 1, new DateTime(2026, 6, 4, 9, 25, 43, 644, DateTimeKind.Local).AddTicks(274), 1 },
                    { 7, new DateTime(2026, 6, 4, 9, 25, 43, 644, DateTimeKind.Local).AddTicks(275), 7, 1, new DateTime(2026, 6, 4, 9, 25, 43, 644, DateTimeKind.Local).AddTicks(276), 1 },
                    { 8, new DateTime(2026, 6, 4, 9, 25, 43, 644, DateTimeKind.Local).AddTicks(277), 8, 1, new DateTime(2026, 6, 4, 9, 25, 43, 644, DateTimeKind.Local).AddTicks(278), 1 },
                    { 9, new DateTime(2026, 6, 4, 9, 25, 43, 644, DateTimeKind.Local).AddTicks(279), 9, 1, new DateTime(2026, 6, 4, 9, 25, 43, 644, DateTimeKind.Local).AddTicks(280), 1 },
                    { 10, new DateTime(2026, 6, 4, 9, 25, 43, 644, DateTimeKind.Local).AddTicks(281), 10, 1, new DateTime(2026, 6, 4, 9, 25, 43, 644, DateTimeKind.Local).AddTicks(282), 1 },
                    { 11, new DateTime(2026, 6, 4, 9, 25, 43, 644, DateTimeKind.Local).AddTicks(283), 11, 1, new DateTime(2026, 6, 4, 9, 25, 43, 644, DateTimeKind.Local).AddTicks(284), 1 },
                    { 12, new DateTime(2026, 6, 4, 9, 25, 43, 644, DateTimeKind.Local).AddTicks(285), 12, 1, new DateTime(2026, 6, 4, 9, 25, 43, 644, DateTimeKind.Local).AddTicks(286), 1 },
                    { 13, new DateTime(2026, 6, 4, 9, 25, 43, 644, DateTimeKind.Local).AddTicks(287), 13, 1, new DateTime(2026, 6, 4, 9, 25, 43, 644, DateTimeKind.Local).AddTicks(287), 1 },
                    { 14, new DateTime(2026, 6, 4, 9, 25, 43, 644, DateTimeKind.Local).AddTicks(289), 14, 1, new DateTime(2026, 6, 4, 9, 25, 43, 644, DateTimeKind.Local).AddTicks(289), 1 },
                    { 15, new DateTime(2026, 6, 4, 9, 25, 43, 644, DateTimeKind.Local).AddTicks(291), 15, 1, new DateTime(2026, 6, 4, 9, 25, 43, 644, DateTimeKind.Local).AddTicks(291), 1 },
                    { 16, new DateTime(2026, 6, 4, 9, 25, 43, 644, DateTimeKind.Local).AddTicks(293), 16, 1, new DateTime(2026, 6, 4, 9, 25, 43, 644, DateTimeKind.Local).AddTicks(293), 1 },
                    { 17, new DateTime(2026, 6, 4, 9, 25, 43, 644, DateTimeKind.Local).AddTicks(295), 17, 1, new DateTime(2026, 6, 4, 9, 25, 43, 644, DateTimeKind.Local).AddTicks(295), 1 },
                    { 18, new DateTime(2026, 6, 4, 9, 25, 43, 644, DateTimeKind.Local).AddTicks(296), 18, 1, new DateTime(2026, 6, 4, 9, 25, 43, 644, DateTimeKind.Local).AddTicks(297), 1 }
                });
        }
    }
}
