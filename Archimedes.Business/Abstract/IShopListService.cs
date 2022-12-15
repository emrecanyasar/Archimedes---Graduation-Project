using Archimedes.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Archimedes.Business.Abstract
{
    public interface IShopListService
    {
        void Create(ShopList entity);

        void Update(ShopList entity);

        void Delete(ShopList entity);

        Task<ShopList> GetById(int id);

        Task<List<ShopList>> GetAll();
    }
}
