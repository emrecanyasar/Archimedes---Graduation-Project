using Archimedes.Data.Abstract;
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

        public List<Product> GetProductByCategory(string category)
        {
            throw new NotImplementedException();
        }

        public List<Product> GetProductSearchResult(string search)
        {
            throw new NotImplementedException();
        }
    }
}
