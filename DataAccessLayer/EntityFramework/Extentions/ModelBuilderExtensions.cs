using Entity;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Utility.Security.Encryption;
using Utility.Security.Hashing;

namespace DataAccessLayer.EntityFramework.Extentions
{
    public static class ModelBuilderExtensions
    {
        public static void Seed(this ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Role>()
            .HasData(new Role
            {
                Id = 1,
                Name = "Süper Admin",
                CreatedAt = DateTime.Now,
                UpdatedAt = DateTime.Now
            },
            new Role
            {
                Id = 2,
                Name = "Kullanıcı",
                CreatedAt = DateTime.Now,
                UpdatedAt = DateTime.Now
            },
            new Role
            {
                Id = 3,
                Name = "Demo",
                CreatedAt = DateTime.Now,
                UpdatedAt = DateTime.Now
            }
            );
            modelBuilder.Entity<User>().HasData(
                CreateAdmin()
            );
            modelBuilder.Entity<Module>(
            ).HasData(
                new Module { Id = 1, Name = "Ana Sayfa", Address = "/Home/Index", Controller = "Home", Action = "Index", Icon = "fas fa-home", Menu = 1, ParentId = 0, Type = "Page", CreatedAt = DateTime.Now, UpdatedAt = DateTime.Now },
                new Module { Id = 2, Name = "Rol Yönetimi", Address = "/Role/Index", Controller = "Role", Action = "Index", Icon = "icon-user-lock", Menu = 1, ParentId = 0, Type = "Category", CreatedAt = DateTime.Now, UpdatedAt = DateTime.Now },
                new Module { Id = 3, Name = "Rol Ekle", Address = "/Role/Create", Controller = "Role", Action = "Create", Icon = "", Menu = 1, ParentId = 2, Type = "Page", CreatedAt = DateTime.Now, UpdatedAt = DateTime.Now },
                new Module { Id = 4, Name = "Rol Düzenleme", Address = "/Role/Edit", Controller = "Role", Action = "Edit", Icon = "", Menu = 0, ParentId = 2, Type = "Feature", CreatedAt = DateTime.Now, UpdatedAt = DateTime.Now },
                new Module { Id = 5, Name = "Rol Silme", Address = "/Role/Delete", Controller = "Role", Action = "Delete", Icon = "", Menu = 0, ParentId = 2, Type = "Feature", CreatedAt = DateTime.Now, UpdatedAt = DateTime.Now },
                new Module { Id = 6, Name = "Id Bazlı Rol Getirme", Address = "/Role/GetById", Controller = "Role", Action = "GetById", Icon = "", Menu = 0, ParentId = 2, Type = "Feature", CreatedAt = DateTime.Now, UpdatedAt = DateTime.Now },
                new Module { Id = 7, Name = "Rol Listesi", Address = "/Role/Index", Controller = "Role", Action = "Index", Icon = "", Menu = 1, ParentId = 2, Type = "Page", CreatedAt = DateTime.Now, UpdatedAt = DateTime.Now },
                new Module { Id = 8, Name = "Rol Listesi", Address = "/Role/GetList", Controller = "Role", Action = "GetList", Icon = "", Menu = 0, ParentId = 2, Type = "Page", CreatedAt = DateTime.Now, UpdatedAt = DateTime.Now },
                new Module { Id = 9, Name = "Rol Yetkilendirme", Address = "/Role/Authentication", Controller = "Role", Action = "Authentication", Icon = "", Menu = 0, ParentId = 2, Type = "Page", CreatedAt = DateTime.Now, UpdatedAt = DateTime.Now },
                new Module { Id = 10, Name = "Modül Yönetimi", Address = "/Module/Index", Controller = "Module", Action = "Index", Icon = "fas fa-align-justify", Menu = 1, ParentId = 0, Type = "Category", CreatedAt = DateTime.Now, UpdatedAt = DateTime.Now },
                new Module { Id = 11, Name = "Modül Listesi", Address = "/Module/Index", Controller = "Module", Action = "Index", Icon = "", Menu = 1, ParentId = 10, Type = "Page", CreatedAt = DateTime.Now, UpdatedAt = DateTime.Now },
                new Module { Id = 12, Name = "Modül Listesi", Address = "/Module/GetList", Controller = "Module", Action = "GetList", Icon = "", Menu = 0, ParentId = 10, Type = "Feature", CreatedAt = DateTime.Now, UpdatedAt = DateTime.Now },
                new Module { Id = 13, Name = "Modül Silme", Address = "/Module/Delete", Controller = "Module", Action = "Delete", Icon = "", Menu = 0, ParentId = 10, Type = "Feature", CreatedAt = DateTime.Now, UpdatedAt = DateTime.Now },
                new Module { Id = 14, Name = "Id Bazlı Rol Getirmea", Address = "/Module/GetById", Controller = "Module", Action = "GetById", Icon = "", Menu = 10, ParentId = 3, Type = "Feature", CreatedAt = DateTime.Now, UpdatedAt = DateTime.Now },
                new Module { Id = 15, Name = "Modül Ekle", Address = "/Module/Create", Controller = "Module", Action = "Create", Icon = "", Menu = 1, ParentId = 10, Type = "Page", CreatedAt = DateTime.Now, UpdatedAt = DateTime.Now },
                new Module { Id = 16, Name = "E-Posta Yönetimi", Address = "/Mail/Index", Controller = "Mail", Action = "Index", Icon = "icon-mail5 mr-3", Menu = 1, ParentId = 16, Type = "Category", CreatedAt = DateTime.Now, UpdatedAt = DateTime.Now },
                new Module { Id = 17, Name = "E-Posta Listesi", Address = "/Mail/Index", Controller = "Mail", Action = "Index", Icon = "", Menu = 1, ParentId = 16, Type = "Page", CreatedAt = DateTime.Now, UpdatedAt = DateTime.Now },
                new Module { Id = 18, Name = "E-Posta Listesi", Address = "/Mail/GetList", Controller = "Mail", Action = "GetList", Icon = "", Menu = 0, ParentId = 16, Type = "Feature", CreatedAt = DateTime.Now, UpdatedAt = DateTime.Now }
            );
            modelBuilder.Entity<ModuleRoles>().HasData(

                new ModuleRoles { Id = 1, RolId = 1, ModuleId = 1, UserId = 1, CreatedAt = DateTime.Now, UpdatedAt = DateTime.Now },
                new ModuleRoles { Id = 2, RolId = 1, ModuleId = 2, UserId = 1, CreatedAt = DateTime.Now, UpdatedAt = DateTime.Now },
                new ModuleRoles { Id = 3, RolId = 1, ModuleId = 3, UserId = 1, CreatedAt = DateTime.Now, UpdatedAt = DateTime.Now },
                new ModuleRoles { Id = 4, RolId = 1, ModuleId = 4, UserId = 1, CreatedAt = DateTime.Now, UpdatedAt = DateTime.Now },
                new ModuleRoles { Id = 5, RolId = 1, ModuleId = 5, UserId = 1, CreatedAt = DateTime.Now, UpdatedAt = DateTime.Now },
                new ModuleRoles { Id = 6, RolId = 1, ModuleId = 6, UserId = 1, CreatedAt = DateTime.Now, UpdatedAt = DateTime.Now },
                new ModuleRoles { Id = 7, RolId = 1, ModuleId = 7, UserId = 1, CreatedAt = DateTime.Now, UpdatedAt = DateTime.Now },
                new ModuleRoles { Id = 8, RolId = 1, ModuleId = 8, UserId = 1, CreatedAt = DateTime.Now, UpdatedAt = DateTime.Now },
                new ModuleRoles { Id = 9, RolId = 1, ModuleId = 9, UserId = 1, CreatedAt = DateTime.Now, UpdatedAt = DateTime.Now },
                new ModuleRoles { Id = 10, RolId = 1, ModuleId = 10, UserId = 1, CreatedAt = DateTime.Now, UpdatedAt = DateTime.Now },
                new ModuleRoles { Id = 11, RolId = 1, ModuleId = 11, UserId = 1, CreatedAt = DateTime.Now, UpdatedAt = DateTime.Now },
                new ModuleRoles { Id = 12, RolId = 1, ModuleId = 12, UserId = 1, CreatedAt = DateTime.Now, UpdatedAt = DateTime.Now },
                new ModuleRoles { Id = 13, RolId = 1, ModuleId = 13, UserId = 1, CreatedAt = DateTime.Now, UpdatedAt = DateTime.Now },
                new ModuleRoles { Id = 14, RolId = 1, ModuleId = 14, UserId = 1, CreatedAt = DateTime.Now, UpdatedAt = DateTime.Now },
                new ModuleRoles { Id = 15, RolId = 1, ModuleId = 15, UserId = 1, CreatedAt = DateTime.Now, UpdatedAt = DateTime.Now },
                new ModuleRoles { Id = 16, RolId = 1, ModuleId = 16, UserId = 1, CreatedAt = DateTime.Now, UpdatedAt = DateTime.Now },
                new ModuleRoles { Id = 17, RolId = 1, ModuleId = 17, UserId = 1, CreatedAt = DateTime.Now, UpdatedAt = DateTime.Now },
                new ModuleRoles { Id = 18, RolId = 1, ModuleId = 18, UserId = 1, CreatedAt = DateTime.Now, UpdatedAt = DateTime.Now }

                );
        }

        public static User CreateAdmin()
        {
            byte[] passwordHash;
            byte[] passwordSalt;
            HashingHelper.CreatePasswordHash("123123", out passwordHash, out passwordSalt);
            User user = new User
            {
                Id = 1,
                Phone = "00000000000",
                RoleId = 1,
                PasswordHash = passwordHash,
                PasswordSalt = passwordSalt
            };
            return user;
        }
    }
}
