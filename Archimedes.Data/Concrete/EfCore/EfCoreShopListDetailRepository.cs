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
    public class EfCoreShopListDetailRepository : EfCoreGenericRepository<ShopListDetail> , IShopListDetailRepository
    {
        public EfCoreShopListDetailRepository(ArchimedeDbContext context) : base(context)
        {

        }

        public ArchimedeDbContext archimedeDbContext
        {
            get
            {
                return _dbContext as ArchimedeDbContext;
            }
        }

        public List<ShopListDetail> GetShopListDetailByListId(int listId)
        {
            List<ShopListDetail> list = new List<ShopListDetail>();
            list= archimedeDbContext.ShopListDetails
                .Include(p=>p.Product)
                .ThenInclude(c=>c.Category)
                .Where(sl=>sl.ShopListId==listId).ToList();
            return list;
        }
    }
}
