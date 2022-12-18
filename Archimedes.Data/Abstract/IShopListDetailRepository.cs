using Archimedes.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Archimedes.Data.Abstract
{
    public interface IShopListDetailRepository : IRepository<ShopListDetail>
    {
        List<ShopListDetail> GetShopListDetailByListId(int listId);
        ShopListDetail GetProductDetails(int id);


    }
}
