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
    public class UserShopListManager : IUserShopListService
    {
        public IUserShopListRepository _userShopListRepository ;

        public UserShopListManager(IUserShopListRepository userShopListRepository)
        {
            _userShopListRepository = userShopListRepository;
        }
        public List<UserShopList> AllList(string userId)
        {
            return _userShopListRepository.AllList(userId);
        }

        public void Create(UserShopList entity)
        {
            throw new NotImplementedException();
        }

        public void Create(string userId, int shopListId)
        {
            _userShopListRepository.Create(userId, shopListId);
        }

        public void Delete(UserShopList entity)
        {
            throw new NotImplementedException();
        }

        public Task<List<UserShopList>> GetAll()
        {
            throw new NotImplementedException();
        }

        public Task<UserShopList> GetById(int id)
        {
            throw new NotImplementedException();
        }

        public void Update(UserShopList entity)
        {
            throw new NotImplementedException();
        }
    }
}
