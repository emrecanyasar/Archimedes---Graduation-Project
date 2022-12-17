using Archimedes.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Archimedes.Data.Abstract
{
    public interface IUserShopListRepository : IRepository<UserShopList>
    {
        List<UserShopList> AllList(string userId);
        void Create(string userId,int shopListId);

    }
}
