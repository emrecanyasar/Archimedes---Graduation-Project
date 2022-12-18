using Archimedes.Business.Abstract;
using Archimedes.Data.Abstract;
using Archimedes.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Archimedes.Business.Concrete
{
    public class ShopListDetailManager : IShopListDetailService
    {
        public IShopListDetailRepository _shopListDetailRepository;

        public ShopListDetailManager(IShopListDetailRepository shopListDetailRepository)
        {
            _shopListDetailRepository = shopListDetailRepository;
        }
        public void Create(ShopListDetail entity)
        {
            _shopListDetailRepository.Create(entity);   
        }

        public void Delete(ShopListDetail entity)
        {
            _shopListDetailRepository.Delete(entity);
        }

        public Task<List<ShopListDetail>> GetAll()
        {
            throw new NotImplementedException();
        }

        public Task<ShopListDetail> GetById(int id)
        {
            return _shopListDetailRepository.GetById(id);
        }

        public ShopListDetail GetProductDetails(int id)
        {
            return _shopListDetailRepository.GetProductDetails(id);
        }

        public List<ShopListDetail> GetShopListDetailByListId(int listId)
        {
            return _shopListDetailRepository.GetShopListDetailByListId(listId);
        }

        public void Update(ShopListDetail entity)
        {
            throw new NotImplementedException();
        }
    }
}
