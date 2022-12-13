﻿using Archimedes.Data.Abstract;
using Archimedes.Entity;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Archimedes.Data.Concrete.EfCore
{
    public class EfCoreProductRepository : EfCoreGenericRepository<Product>, IProductRepository
    {
        public EfCoreProductRepository(ArchimedeDbContext context) : base(context)
        {

        }

        public ArchimedeDbContext archimedeDbContext
        {
            get
            {
                return _dbContext as ArchimedeDbContext;
            }
        }
        public Product GetProductDetails(int id)
        {
            return archimedeDbContext.Products
                .Where(p=>p.Id == id)
                .Include(c=>c.Category)
                .FirstOrDefault();
        }

        public List<Product> GetProductsByCategory(string category)
        {
            List<Product> products = new List<Product>();
            products = archimedeDbContext
                                 .Products
                                 .Include(p => p.Category)
                                 .Where(p => p.Category.CategoryName == category)
                                 .ToList();                     
            return products;
        }

        public List<Product> GetSearchResult(string searchString)
        {
            var products = archimedeDbContext
                            .Products
                            .Where(p => p.ProductName.ToLower().Contains(searchString.ToLower()))
                            .AsQueryable();

            return products.ToList();
        }
    }
}
