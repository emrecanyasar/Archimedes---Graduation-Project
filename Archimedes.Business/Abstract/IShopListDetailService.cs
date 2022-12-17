using Archimedes.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Archimedes.Business.Abstract
{
    public interface IShopListDetailService
    {
        void Create(ShopListDetail entity);

        void Update(ShopListDetail entity);

        void Delete(ShopListDetail entity);

        Task<ShopListDetail> GetById(int id);

        Task<List<ShopListDetail>> GetAll();
        List<ShopListDetail> GetShopListDetailByListId(int listId);

    }
}
