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
    public class ShopListManager : IShopListService
    {
        IShopListRepository _shopListRepository;

        public ShopListManager(IShopListRepository shopListRepository)
        {
            _shopListRepository = shopListRepository;
        }

        public void Create(ShopList entity)
        {
            _shopListRepository.Create(entity);
        }

        public void Create(ShopList entity, string userId)
        {
            _shopListRepository.Create(entity, userId);
        }

        public void Delete(ShopList entity)
        {
            _shopListRepository.Delete(entity);
        }

        public async Task<List<ShopList>> GetAll()
        {
            return await _shopListRepository.GetAll();
        }

        public async Task<ShopList> GetById(int id)
        {
           return await _shopListRepository.GetById(id);
        }

        public List<ShopList> GetListByUser(string userId)
        {
            return  _shopListRepository.GetShopListByUser(userId);
        }

        public List<ShopList> GetListByUser(int userId)
        {
            throw new NotImplementedException();
        }

        public List<ShopList> GetShopListByUser(string userId)
        {
            return _shopListRepository.GetShopListByUser(userId);
        }

        public void Update(ShopList entity)
        {
            _shopListRepository.Update(entity);
        }
    }
}
