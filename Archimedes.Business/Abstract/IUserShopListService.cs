using Archimedes.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Archimedes.Business.Abstract
{
    public interface IUserShopListService
    {
        void Create(UserShopList entity);

        void Update(UserShopList entity);

        void Delete(UserShopList entity);

        Task<UserShopList> GetById(int id);

        Task<List<UserShopList>> GetAll();
        List<UserShopList> AllList(string userId);
        void Create(string userId, int shopListId);

    }
}
