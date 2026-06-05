using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace DataAccessLayer.Migrations
{
    /// <inheritdoc />
    public partial class seeddata : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Modules",
                columns: new[] { "Id", "Action", "Address", "Controller", "CreatedAt", "Icon", "Menu", "Name", "ParentId", "Type", "UpdatedAt" },
                values: new object[,]
                {
                    { 1, "Index", "/Home/Index", "Home", new DateTime(2026, 6, 5, 13, 19, 45, 921, DateTimeKind.Local).AddTicks(2738), "fas fa-home", 1, "Ana Sayfa", 0, "Page", new DateTime(2026, 6, 5, 13, 19, 45, 921, DateTimeKind.Local).AddTicks(2740) },
                    { 2, "Index", "Index", "Role", new DateTime(2026, 6, 5, 13, 19, 45, 921, DateTimeKind.Local).AddTicks(2743), "icon-user-lock", 1, "Rol Yönetimi", 0, "Category", new DateTime(2026, 6, 5, 13, 19, 45, 921, DateTimeKind.Local).AddTicks(2744) },
                    { 3, "Create", "/Role/Create", "Role", new DateTime(2026, 6, 5, 13, 19, 45, 921, DateTimeKind.Local).AddTicks(2746), "", 1, "Rol Ekle", 2, "Page", new DateTime(2026, 6, 5, 13, 19, 45, 921, DateTimeKind.Local).AddTicks(2746) },
                    { 4, "Edit", "/Role/Edit", "Role", new DateTime(2026, 6, 5, 13, 19, 45, 921, DateTimeKind.Local).AddTicks(2748), "", 0, "Rol Düzenleme", 2, "Feature", new DateTime(2026, 6, 5, 13, 19, 45, 921, DateTimeKind.Local).AddTicks(2748) },
                    { 5, "Delete", "/Role/Delete", "Role", new DateTime(2026, 6, 5, 13, 19, 45, 921, DateTimeKind.Local).AddTicks(2750), "", 0, "Rol Silme", 2, "Feature", new DateTime(2026, 6, 5, 13, 19, 45, 921, DateTimeKind.Local).AddTicks(2750) },
                    { 6, "GetById", "/Role/GetById", "Role", new DateTime(2026, 6, 5, 13, 19, 45, 921, DateTimeKind.Local).AddTicks(2751), "", 0, "Id Bazlı Rol Getirme", 2, "Feature", new DateTime(2026, 6, 5, 13, 19, 45, 921, DateTimeKind.Local).AddTicks(2752) },
                    { 7, "/Role/Index", "/Role/Index", "Role", new DateTime(2026, 6, 5, 13, 19, 45, 921, DateTimeKind.Local).AddTicks(2753), "", 1, "Rol Listesi", 2, "Page", new DateTime(2026, 6, 5, 13, 19, 45, 921, DateTimeKind.Local).AddTicks(2754) },
                    { 8, "GetList", "/Role/GetList", "Role", new DateTime(2026, 6, 5, 13, 19, 45, 921, DateTimeKind.Local).AddTicks(2755), "", 0, "Rol Listesi", 2, "Page", new DateTime(2026, 6, 5, 13, 19, 45, 921, DateTimeKind.Local).AddTicks(2755) },
                    { 9, "Authentication", "/Role/Authentication", "Role", new DateTime(2026, 6, 5, 13, 19, 45, 921, DateTimeKind.Local).AddTicks(2757), "", 0, "Rol Yetkilendirme", 2, "Page", new DateTime(2026, 6, 5, 13, 19, 45, 921, DateTimeKind.Local).AddTicks(2757) },
                    { 10, "Index", "/Module/Index", "Module", new DateTime(2026, 6, 5, 13, 19, 45, 921, DateTimeKind.Local).AddTicks(2758), "fas fa-align-justify", 1, "Modül Yönetimi", 0, "Category", new DateTime(2026, 6, 5, 13, 19, 45, 921, DateTimeKind.Local).AddTicks(2759) },
                    { 11, "/Module/Index", "/Module/Index", "Module", new DateTime(2026, 6, 5, 13, 19, 45, 921, DateTimeKind.Local).AddTicks(2760), "", 1, "Modül Listesi", 10, "Page", new DateTime(2026, 6, 5, 13, 19, 45, 921, DateTimeKind.Local).AddTicks(2761) },
                    { 12, "GetList", "/Module/GetList", "Module", new DateTime(2026, 6, 5, 13, 19, 45, 921, DateTimeKind.Local).AddTicks(2762), "", 0, "Modül Listesi", 10, "Feature", new DateTime(2026, 6, 5, 13, 19, 45, 921, DateTimeKind.Local).AddTicks(2765) },
                    { 13, "Delete", "/Module/Delete", "Module", new DateTime(2026, 6, 5, 13, 19, 45, 921, DateTimeKind.Local).AddTicks(2767), "", 0, "Modül Silme", 10, "Feature", new DateTime(2026, 6, 5, 13, 19, 45, 921, DateTimeKind.Local).AddTicks(2767) },
                    { 14, "GetById", "/Module/GetById", "Module", new DateTime(2026, 6, 5, 13, 19, 45, 921, DateTimeKind.Local).AddTicks(2768), "", 10, "Id Bazlı Rol Getirmea", 3, "Feature", new DateTime(2026, 6, 5, 13, 19, 45, 921, DateTimeKind.Local).AddTicks(2769) },
                    { 15, "/Module/Create", "/Module/Create", "Module", new DateTime(2026, 6, 5, 13, 19, 45, 921, DateTimeKind.Local).AddTicks(2770), "", 1, "Modül Ekle", 10, "Page", new DateTime(2026, 6, 5, 13, 19, 45, 921, DateTimeKind.Local).AddTicks(2771) },
                    { 16, "Index", "/Mail/Index", "Mail", new DateTime(2026, 6, 5, 13, 19, 45, 921, DateTimeKind.Local).AddTicks(2772), "icon-mail5 mr-3", 1, "E-Posta Yönetimi", 16, "Category", new DateTime(2026, 6, 5, 13, 19, 45, 921, DateTimeKind.Local).AddTicks(2772) },
                    { 17, "Index", "/Mail/Index", "Mail", new DateTime(2026, 6, 5, 13, 19, 45, 921, DateTimeKind.Local).AddTicks(2774), "", 1, "E-Posta Listesi", 16, "Page", new DateTime(2026, 6, 5, 13, 19, 45, 921, DateTimeKind.Local).AddTicks(2774) },
                    { 18, "GetList", "/Mail/GetList", "Mail", new DateTime(2026, 6, 5, 13, 19, 45, 921, DateTimeKind.Local).AddTicks(2775), "", 0, "E-Posta Listesi", 16, "Feature", new DateTime(2026, 6, 5, 13, 19, 45, 921, DateTimeKind.Local).AddTicks(2776) },
                    { 19, "/kullanici_islemleri", "/User/KullaniciIslemleri", "User", new DateTime(2026, 6, 5, 13, 19, 45, 921, DateTimeKind.Local).AddTicks(2777), "", 0, "Kullanıcı İşlemleri", 16, "Feature", new DateTime(2026, 6, 5, 13, 19, 45, 921, DateTimeKind.Local).AddTicks(2777) },
                    { 20, "Api", "Api", "Api", new DateTime(2026, 6, 5, 13, 19, 45, 921, DateTimeKind.Local).AddTicks(2779), "", 0, "Api Modules", 16, "Feature", new DateTime(2026, 6, 5, 13, 19, 45, 921, DateTimeKind.Local).AddTicks(2779) },
                    { 21, "/kullanici_detay", "/User/Detail", "User", new DateTime(2026, 6, 5, 13, 19, 45, 921, DateTimeKind.Local).AddTicks(2781), "", 0, "Kullanıcı Detay", 16, "Feature", new DateTime(2026, 6, 5, 13, 19, 45, 921, DateTimeKind.Local).AddTicks(2782) },
                    { 22, "Detail", "/User/Detail", "User", new DateTime(2026, 6, 5, 13, 19, 45, 921, DateTimeKind.Local).AddTicks(2783), "", 0, "User Detail", 16, "Feature", new DateTime(2026, 6, 5, 13, 19, 45, 921, DateTimeKind.Local).AddTicks(2783) },
                    { 23, "GetUsers", "/User/GetUsers", "User", new DateTime(2026, 6, 5, 13, 19, 45, 921, DateTimeKind.Local).AddTicks(2785), "", 0, "User GetUsers", 16, "Feature", new DateTime(2026, 6, 5, 13, 19, 45, 921, DateTimeKind.Local).AddTicks(2785) },
                    { 24, "GetUserById", "/User/GetUserById", "User", new DateTime(2026, 6, 5, 13, 19, 45, 921, DateTimeKind.Local).AddTicks(2786), "", 0, "User GetById", 16, "Feature", new DateTime(2026, 6, 5, 13, 19, 45, 921, DateTimeKind.Local).AddTicks(2787) },
                    { 25, "CreateUser", "/User/CreateUser", "User", new DateTime(2026, 6, 5, 13, 19, 45, 921, DateTimeKind.Local).AddTicks(2788), "", 0, "User CreateUser", 16, "Feature", new DateTime(2026, 6, 5, 13, 19, 45, 921, DateTimeKind.Local).AddTicks(2789) },
                    { 26, "UpdateUser", "/User/UpdateUser", "User", new DateTime(2026, 6, 5, 13, 19, 45, 921, DateTimeKind.Local).AddTicks(2790), "", 0, "User UpdateUser", 16, "Feature", new DateTime(2026, 6, 5, 13, 19, 45, 921, DateTimeKind.Local).AddTicks(2790) },
                    { 27, "DeleteUser", "/User/DeleteUser", "User", new DateTime(2026, 6, 5, 13, 19, 45, 921, DateTimeKind.Local).AddTicks(2792), "", 0, "User DeleteUser", 16, "Feature", new DateTime(2026, 6, 5, 13, 19, 45, 921, DateTimeKind.Local).AddTicks(2792) },
                    { 28, "ResetPassword", "/User/ResetPassword", "User", new DateTime(2026, 6, 5, 13, 19, 45, 921, DateTimeKind.Local).AddTicks(2793), "", 0, "User ResetPassword", 16, "Feature", new DateTime(2026, 6, 5, 13, 19, 45, 921, DateTimeKind.Local).AddTicks(2794) }
                });

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

            migrationBuilder.InsertData(
                table: "ModuleRoles",
                columns: new[] { "Id", "CreatedAt", "ModuleId", "RolId", "UpdatedAt", "UserId" },
                values: new object[,]
                {
                    { 1, new DateTime(2026, 6, 5, 13, 19, 45, 921, DateTimeKind.Local).AddTicks(2819), 1, 1, new DateTime(2026, 6, 5, 13, 19, 45, 921, DateTimeKind.Local).AddTicks(2820), 1 },
                    { 2, new DateTime(2026, 6, 5, 13, 19, 45, 921, DateTimeKind.Local).AddTicks(2821), 2, 1, new DateTime(2026, 6, 5, 13, 19, 45, 921, DateTimeKind.Local).AddTicks(2821), 1 },
                    { 3, new DateTime(2026, 6, 5, 13, 19, 45, 921, DateTimeKind.Local).AddTicks(2822), 3, 1, new DateTime(2026, 6, 5, 13, 19, 45, 921, DateTimeKind.Local).AddTicks(2823), 1 },
                    { 4, new DateTime(2026, 6, 5, 13, 19, 45, 921, DateTimeKind.Local).AddTicks(2824), 4, 1, new DateTime(2026, 6, 5, 13, 19, 45, 921, DateTimeKind.Local).AddTicks(2824), 1 },
                    { 5, new DateTime(2026, 6, 5, 13, 19, 45, 921, DateTimeKind.Local).AddTicks(2825), 5, 1, new DateTime(2026, 6, 5, 13, 19, 45, 921, DateTimeKind.Local).AddTicks(2826), 1 },
                    { 6, new DateTime(2026, 6, 5, 13, 19, 45, 921, DateTimeKind.Local).AddTicks(2826), 6, 1, new DateTime(2026, 6, 5, 13, 19, 45, 921, DateTimeKind.Local).AddTicks(2827), 1 },
                    { 7, new DateTime(2026, 6, 5, 13, 19, 45, 921, DateTimeKind.Local).AddTicks(2828), 7, 1, new DateTime(2026, 6, 5, 13, 19, 45, 921, DateTimeKind.Local).AddTicks(2828), 1 },
                    { 8, new DateTime(2026, 6, 5, 13, 19, 45, 921, DateTimeKind.Local).AddTicks(2829), 8, 1, new DateTime(2026, 6, 5, 13, 19, 45, 921, DateTimeKind.Local).AddTicks(2830), 1 },
                    { 9, new DateTime(2026, 6, 5, 13, 19, 45, 921, DateTimeKind.Local).AddTicks(2831), 9, 1, new DateTime(2026, 6, 5, 13, 19, 45, 921, DateTimeKind.Local).AddTicks(2831), 1 },
                    { 10, new DateTime(2026, 6, 5, 13, 19, 45, 921, DateTimeKind.Local).AddTicks(2832), 10, 1, new DateTime(2026, 6, 5, 13, 19, 45, 921, DateTimeKind.Local).AddTicks(2832), 1 },
                    { 11, new DateTime(2026, 6, 5, 13, 19, 45, 921, DateTimeKind.Local).AddTicks(2833), 11, 1, new DateTime(2026, 6, 5, 13, 19, 45, 921, DateTimeKind.Local).AddTicks(2834), 1 },
                    { 12, new DateTime(2026, 6, 5, 13, 19, 45, 921, DateTimeKind.Local).AddTicks(2835), 12, 1, new DateTime(2026, 6, 5, 13, 19, 45, 921, DateTimeKind.Local).AddTicks(2835), 1 },
                    { 13, new DateTime(2026, 6, 5, 13, 19, 45, 921, DateTimeKind.Local).AddTicks(2837), 13, 1, new DateTime(2026, 6, 5, 13, 19, 45, 921, DateTimeKind.Local).AddTicks(2837), 1 },
                    { 14, new DateTime(2026, 6, 5, 13, 19, 45, 921, DateTimeKind.Local).AddTicks(2838), 14, 1, new DateTime(2026, 6, 5, 13, 19, 45, 921, DateTimeKind.Local).AddTicks(2839), 1 },
                    { 15, new DateTime(2026, 6, 5, 13, 19, 45, 921, DateTimeKind.Local).AddTicks(2840), 15, 1, new DateTime(2026, 6, 5, 13, 19, 45, 921, DateTimeKind.Local).AddTicks(2840), 1 },
                    { 16, new DateTime(2026, 6, 5, 13, 19, 45, 921, DateTimeKind.Local).AddTicks(2841), 16, 1, new DateTime(2026, 6, 5, 13, 19, 45, 921, DateTimeKind.Local).AddTicks(2842), 1 },
                    { 17, new DateTime(2026, 6, 5, 13, 19, 45, 921, DateTimeKind.Local).AddTicks(2844), 17, 1, new DateTime(2026, 6, 5, 13, 19, 45, 921, DateTimeKind.Local).AddTicks(2844), 1 },
                    { 18, new DateTime(2026, 6, 5, 13, 19, 45, 921, DateTimeKind.Local).AddTicks(2845), 18, 1, new DateTime(2026, 6, 5, 13, 19, 45, 921, DateTimeKind.Local).AddTicks(2846), 1 },
                    { 19, new DateTime(2026, 6, 5, 13, 19, 45, 921, DateTimeKind.Local).AddTicks(2847), 19, 1, new DateTime(2026, 6, 5, 13, 19, 45, 921, DateTimeKind.Local).AddTicks(2847), 1 },
                    { 20, new DateTime(2026, 6, 5, 13, 19, 45, 921, DateTimeKind.Local).AddTicks(2848), 20, 1, new DateTime(2026, 6, 5, 13, 19, 45, 921, DateTimeKind.Local).AddTicks(2848), 1 },
                    { 21, new DateTime(2026, 6, 5, 13, 19, 45, 921, DateTimeKind.Local).AddTicks(2849), 21, 1, new DateTime(2026, 6, 5, 13, 19, 45, 921, DateTimeKind.Local).AddTicks(2850), 1 },
                    { 22, new DateTime(2026, 6, 5, 13, 19, 45, 921, DateTimeKind.Local).AddTicks(2851), 22, 1, new DateTime(2026, 6, 5, 13, 19, 45, 921, DateTimeKind.Local).AddTicks(2851), 1 },
                    { 23, new DateTime(2026, 6, 5, 13, 19, 45, 921, DateTimeKind.Local).AddTicks(2852), 23, 1, new DateTime(2026, 6, 5, 13, 19, 45, 921, DateTimeKind.Local).AddTicks(2852), 1 },
                    { 24, new DateTime(2026, 6, 5, 13, 19, 45, 921, DateTimeKind.Local).AddTicks(2853), 24, 1, new DateTime(2026, 6, 5, 13, 19, 45, 921, DateTimeKind.Local).AddTicks(2854), 1 },
                    { 25, new DateTime(2026, 6, 5, 13, 19, 45, 921, DateTimeKind.Local).AddTicks(2855), 25, 1, new DateTime(2026, 6, 5, 13, 19, 45, 921, DateTimeKind.Local).AddTicks(2855), 1 },
                    { 26, new DateTime(2026, 6, 5, 13, 19, 45, 921, DateTimeKind.Local).AddTicks(3018), 26, 1, new DateTime(2026, 6, 5, 13, 19, 45, 921, DateTimeKind.Local).AddTicks(3019), 1 },
                    { 27, new DateTime(2026, 6, 5, 13, 19, 45, 921, DateTimeKind.Local).AddTicks(3020), 27, 1, new DateTime(2026, 6, 5, 13, 19, 45, 921, DateTimeKind.Local).AddTicks(3021), 1 },
                    { 28, new DateTime(2026, 6, 5, 13, 19, 45, 921, DateTimeKind.Local).AddTicks(3022), 28, 1, new DateTime(2026, 6, 5, 13, 19, 45, 921, DateTimeKind.Local).AddTicks(3022), 1 }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
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
                table: "ModuleRoles",
                keyColumn: "Id",
                keyValue: 19);

            migrationBuilder.DeleteData(
                table: "ModuleRoles",
                keyColumn: "Id",
                keyValue: 20);

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

            migrationBuilder.DeleteData(
                table: "Modules",
                keyColumn: "Id",
                keyValue: 19);

            migrationBuilder.DeleteData(
                table: "Modules",
                keyColumn: "Id",
                keyValue: 20);

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
                columns: new[] { "PasswordHash", "PasswordSalt" },
                values: new object[] { new byte[] { 81, 242, 69, 158, 245, 48, 179, 239, 24, 65, 37, 17, 119, 102, 34, 103, 248, 10, 31, 225, 148, 147, 32, 149, 235, 20, 172, 1, 127, 9, 48, 212, 219, 173, 162, 67, 179, 210, 198, 155, 230, 242, 106, 88, 209, 185, 119, 34, 5, 44, 202, 211, 177, 217, 158, 61, 180, 185, 106, 188, 31, 144, 2, 50 }, new byte[] { 115, 150, 60, 162, 20, 173, 36, 117, 31, 201, 163, 222, 228, 41, 140, 34, 68, 104, 157, 14, 177, 219, 225, 99, 22, 89, 188, 9, 56, 42, 25, 65, 42, 200, 201, 42, 59, 1, 186, 56, 245, 144, 41, 221, 122, 96, 179, 155, 245, 191, 115, 106, 171, 242, 194, 16, 27, 17, 140, 205, 180, 14, 72, 100, 68, 244, 193, 139, 206, 197, 81, 106, 242, 151, 23, 54, 67, 25, 109, 7, 153, 152, 201, 27, 58, 219, 14, 4, 75, 94, 196, 235, 159, 232, 229, 30, 25, 189, 14, 229, 183, 251, 27, 161, 87, 252, 52, 242, 146, 242, 204, 213, 220, 209, 179, 244, 145, 254, 151, 45, 25, 65, 166, 113, 48, 10, 245, 200 } });
        }
    }
}
