using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Archimedes.Core.Entities
{
    public class ArchimedeDbContext : DbContext
    {

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=. ; Database=ArchimedeDB; Trusted_Connection=True");
        }

        public  DbSet<Category> Categories { get; set; } = null!;
        public  DbSet<Customer> Customers { get; set; } = null!;
        public  DbSet<Product> Products { get; set; } = null!;
        public  DbSet<ProductList> ProductLists { get; set; } = null!;
        public  DbSet<Order> Orders { get; set; } = null!;
    }
}
