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
    public class ArchimedeDbContext : IdentityDbContext<AppUser,IdentityRole,string>
    {
        public ArchimedeDbContext(DbContextOptions<ArchimedeDbContext> options) : base(options)
        {

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
