using Archimedes.Data.Abstract;
using Archimedes.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Archimedes.Data.Concrete.EfCore
{
    public class EfCoreShopListRepository : EfCoreGenericRepository<ShopList> , IShopListRepository
    {
        public EfCoreShopListRepository(ArchimedeDbContext context) : base(context)
        {

        }

        //public List<ShopList> GetProductByUser(string user)
        //{
        //    throw new NotImplementedException();
        //}
    }
}
