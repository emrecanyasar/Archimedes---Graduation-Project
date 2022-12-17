using Archimedes.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Archimedes.Data.Abstract
{
    public interface IShopListRepository : IRepository<ShopList>
    {
        List<ShopList> GetShopListByUser(string userId);
        void Create(ShopList entity, string userId);
        void ShopUse(int id);

    }
}
