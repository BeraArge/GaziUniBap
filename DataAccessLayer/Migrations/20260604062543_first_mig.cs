using System;
using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace DataAccessLayer.Migrations
{
    /// <inheritdoc />
    public partial class first_mig : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Modules",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Name = table.Column<string>(type: "text", nullable: true),
                    Controller = table.Column<string>(type: "text", nullable: true),
                    Action = table.Column<string>(type: "text", nullable: true),
                    Address = table.Column<string>(type: "text", nullable: true),
                    Icon = table.Column<string>(type: "text", nullable: true),
                    Menu = table.Column<int>(type: "integer", nullable: false),
                    ParentId = table.Column<int>(type: "integer", nullable: false),
                    Type = table.Column<string>(type: "text", nullable: true),
                    CreatedAt = table.Column<DateTime>(type: "timestamp without time zone", nullable: true),
                    UpdatedAt = table.Column<DateTime>(type: "timestamp without time zone", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Modules", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Notifications",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Message = table.Column<string>(type: "text", nullable: true),
                    CreatedAt = table.Column<DateTime>(type: "timestamp without time zone", nullable: true),
                    UpdatedAt = table.Column<DateTime>(type: "timestamp without time zone", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Notifications", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Roles",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Name = table.Column<string>(type: "text", nullable: true),
                    CreatedAt = table.Column<DateTime>(type: "timestamp without time zone", nullable: true),
                    UpdatedAt = table.Column<DateTime>(type: "timestamp without time zone", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Roles", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Users",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    FullName = table.Column<string>(type: "text", nullable: true),
                    BirthDate = table.Column<string>(type: "text", nullable: true),
                    Phone = table.Column<string>(type: "text", nullable: true),
                    PasswordHash = table.Column<byte[]>(type: "bytea", nullable: true),
                    PasswordSalt = table.Column<byte[]>(type: "bytea", nullable: true),
                    RoleId = table.Column<int>(type: "integer", nullable: false),
                    KvkkApproved = table.Column<bool>(type: "boolean", nullable: false, defaultValue: false),
                    OnamApproved = table.Column<bool>(type: "boolean", nullable: false, defaultValue: false),
                    IlkGiris = table.Column<bool>(type: "boolean", nullable: false, defaultValue: false),
                    DeviceToken = table.Column<string>(type: "text", nullable: true),
                    CreatedAt = table.Column<DateTime>(type: "timestamp without time zone", nullable: true),
                    UpdatedAt = table.Column<DateTime>(type: "timestamp without time zone", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Users", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Users_Roles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "Roles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ModuleRoles",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    ModuleId = table.Column<int>(type: "integer", nullable: false),
                    RolId = table.Column<int>(type: "integer", nullable: false),
                    UserId = table.Column<int>(type: "integer", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "timestamp without time zone", nullable: true),
                    UpdatedAt = table.Column<DateTime>(type: "timestamp without time zone", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ModuleRoles", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ModuleRoles_Modules_ModuleId",
                        column: x => x.ModuleId,
                        principalTable: "Modules",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ModuleRoles_Roles_RolId",
                        column: x => x.RolId,
                        principalTable: "Roles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ModuleRoles_Users_UserId",
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

            migrationBuilder.InsertData(
                table: "Roles",
                columns: new[] { "Id", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[,]
                {
                    { 1, new DateTime(2026, 6, 4, 9, 25, 43, 643, DateTimeKind.Local).AddTicks(8718), "Süper Admin", new DateTime(2026, 6, 4, 9, 25, 43, 643, DateTimeKind.Local).AddTicks(8730) },
                    { 2, new DateTime(2026, 6, 4, 9, 25, 43, 643, DateTimeKind.Local).AddTicks(8733), "Kullanıcı", new DateTime(2026, 6, 4, 9, 25, 43, 643, DateTimeKind.Local).AddTicks(8734) },
                    { 3, new DateTime(2026, 6, 4, 9, 25, 43, 643, DateTimeKind.Local).AddTicks(8735), "Demo", new DateTime(2026, 6, 4, 9, 25, 43, 643, DateTimeKind.Local).AddTicks(8735) }
                });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "BirthDate", "CreatedAt", "DeviceToken", "FullName", "PasswordHash", "PasswordSalt", "Phone", "RoleId", "UpdatedAt" },
                values: new object[] { 1, null, null, null, null, new byte[] { 243, 140, 44, 28, 19, 46, 225, 236, 163, 104, 164, 39, 122, 228, 47, 168, 165, 143, 110, 187, 149, 120, 165, 114, 52, 159, 240, 221, 57, 76, 37, 216, 109, 24, 231, 153, 18, 166, 77, 63, 33, 126, 127, 26, 120, 39, 147, 85, 229, 83, 72, 188, 40, 7, 178, 71, 39, 246, 9, 193, 18, 247, 139, 217 }, new byte[] { 216, 93, 211, 214, 24, 81, 233, 149, 40, 41, 131, 51, 228, 206, 105, 205, 147, 142, 216, 151, 85, 54, 111, 117, 41, 248, 121, 244, 155, 159, 208, 190, 150, 127, 50, 2, 69, 221, 135, 13, 148, 174, 148, 194, 116, 170, 28, 241, 251, 47, 33, 214, 25, 131, 24, 199, 167, 241, 138, 54, 237, 183, 250, 42, 36, 3, 251, 223, 113, 54, 215, 31, 245, 232, 223, 131, 203, 135, 57, 33, 93, 82, 4, 245, 144, 221, 5, 128, 151, 79, 31, 3, 97, 184, 239, 233, 84, 180, 51, 63, 44, 150, 202, 139, 14, 20, 30, 215, 9, 119, 161, 246, 115, 24, 8, 132, 194, 33, 186, 228, 140, 0, 235, 203, 192, 37, 110, 50 }, "00000000000", 1, null });

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

            migrationBuilder.CreateIndex(
                name: "IX_ModuleRoles_ModuleId",
                table: "ModuleRoles",
                column: "ModuleId");

            migrationBuilder.CreateIndex(
                name: "IX_ModuleRoles_RolId",
                table: "ModuleRoles",
                column: "RolId");

            migrationBuilder.CreateIndex(
                name: "IX_ModuleRoles_UserId",
                table: "ModuleRoles",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_Users_RoleId",
                table: "Users",
                column: "RoleId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ModuleRoles");

            migrationBuilder.DropTable(
                name: "Notifications");

            migrationBuilder.DropTable(
                name: "Modules");

            migrationBuilder.DropTable(
                name: "Users");

            migrationBuilder.DropTable(
                name: "Roles");
        }
    }
}
