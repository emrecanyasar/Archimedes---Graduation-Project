using Archimedes.Data.Abstract;
using Archimedes.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Archimedes.Data.Concrete.EfCore
{
    public class EfCoreCategoryRepository : EfCoreGenericRepository<Category> ,ICategoryRepository
    {
        public EfCoreCategoryRepository(ArchimedeDbContext context):base(context)
        {

        }

        public ArchimedeDbContext archimedeDbContext
        {
            get
            {
                return _dbContext as ArchimedeDbContext;
            }
        }

        public Category GetCategoryByName(string name)
        {
            return archimedeDbContext.Categories
                .Where(x=>x.CategoryName==name).FirstOrDefault();
        }
    }
}
