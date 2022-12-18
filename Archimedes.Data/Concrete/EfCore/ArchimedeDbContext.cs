using Archimedes.Entity;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Archimedes.Data.Concrete.EfCore
{
    public class ArchimedeDbContext : IdentityDbContext<AppUser, IdentityRole, string>
    {
        public ArchimedeDbContext(DbContextOptions<ArchimedeDbContext> options) : base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
            var passwordHasher = new PasswordHasher<AppUser>();

            builder.Entity<Category>().HasIndex(c => new { c.CategoryName }).IsUnique();
            builder.Entity<Product>().HasIndex(c => new { c.ProductName }).IsUnique();


            //SEED DATA
            builder.Entity<IdentityRole>(entity =>
            {
                entity.HasData(new IdentityRole()
                {
                    Id = "1",
                    Name = Entity.Identity.Roles.Admin,
                    NormalizedName = Entity.Identity.Roles.Admin.ToUpper(),
                });
                entity.HasData(new IdentityRole()
                {
                    Id = "2",
                    Name = Entity.Identity.Roles.Customer,
                    NormalizedName = Entity.Identity.Roles.Customer.ToUpper(),
                });
            });

            builder.Entity<AppUser>(entity =>
            {
                entity.HasData(new AppUser()
                {
                    Id = "8e552862-a24d-4548-a6c6-9443d048cdb9",
                    FirstName = "Admin",
                    LastName = "Admin",
                    Email = "admin@gmail.com",
                    UserName = "admin",
                    NormalizedUserName = "ADMIN",
                    NormalizedEmail = "ADMIN@GMAIL.COM",
                    PasswordHash = passwordHasher.HashPassword(null, "Admin0808")
                });
            });

            builder.Entity<IdentityUserRole<string>>(entity =>
            {

                entity.HasData(new IdentityUserRole<string>
                {
                    RoleId = "1",
                    UserId = "8e552862-a24d-4548-a6c6-9443d048cdb9"
                });
            });
        }

        public DbSet<Category> Categories { get; set; } = null!;
        public DbSet<AppUser> AppUsers { get; set; } = null!;
        public DbSet<Product> Products { get; set; } = null!;
        public DbSet<ShopList> ShopLists { get; set; } = null!;
        public DbSet<Order> Orders { get; set; } = null!;
        public DbSet<OrderDetail> OrderDetails { get; set; } = null!;
        public DbSet<UserShopList> UserShopLists { get; set; } = null!;
        public DbSet<ShopListDetail> ShopListDetails { get; set; } = null!;
    }
}
