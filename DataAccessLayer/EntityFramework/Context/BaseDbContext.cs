using Core.DataAccess.Repositories;
using DataAccessLayer.EntityFramework.Extentions;
using Entity;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.EntityFramework.Context
{
    public class BaseDbContext : DbContext
    {
        public BaseDbContext(DbContextOptions<BaseDbContext> options) : base(options)
        {

        }

        public BaseDbContext()
        {
        }

        public virtual DbSet<User> Users { get; set; }
        public virtual DbSet<Role> Roles { get; set; }
        public virtual DbSet<Module> Modules { get; set; }
        public virtual DbSet<ModuleRoles> ModuleRoles { get; set; }
        public virtual DbSet<Notification> Notifications { get; set; }
        

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            //FLUENT API

            modelBuilder.Entity<User>().HasOne(u => u.Role).WithMany(u => u.Users).HasForeignKey(r => r.RoleId);

            modelBuilder.Entity<ModuleRoles>().HasOne(m => m.User).WithMany(u => u.ModuleRoles).HasForeignKey(m => m.UserId);
            modelBuilder.Entity<ModuleRoles>().HasOne(m => m.Module).WithMany(m => m.ModuleRoles).HasForeignKey(m => m.ModuleId);
            modelBuilder.Entity<ModuleRoles>().HasOne(m => m.Role).WithMany(m => m.ModuleRoles).HasForeignKey(m => m.RolId);


            modelBuilder.Entity<User>().Property(x => x.KvkkApproved).HasDefaultValue(false);
            modelBuilder.Entity<User>().Property(x => x.OnamApproved).HasDefaultValue(false);
            modelBuilder.Entity<User>().Property(x => x.IlkGiris).HasDefaultValue(false);




            ModelBuilderExtensions.Seed(modelBuilder);


        }

        public override int SaveChanges()
        {
            var datas = ChangeTracker.Entries<BaseEntity>();

            foreach (var data in datas)
            {
                var _ = data.State switch
                {
                    EntityState.Added => data.Entity.CreatedAt = DateTime.Now,
                    EntityState.Modified => data.Entity.UpdatedAt = DateTime.Now,
                    _ => DateTime.Now
                };
            }

            return base.SaveChanges();
        }

        public override async Task<int> SaveChangesAsync(CancellationToken cancellationToken = default)
        {
            var datas = ChangeTracker.Entries<BaseEntity>();

            foreach (var data in datas)
            {
                var _ = data.State switch
                {
                    EntityState.Added => data.Entity.CreatedAt = DateTime.Now,
                    EntityState.Modified => data.Entity.UpdatedAt = DateTime.Now,
                    _ => DateTime.Now
                };
            }

            return await base.SaveChangesAsync(cancellationToken);
        }
    }
}
