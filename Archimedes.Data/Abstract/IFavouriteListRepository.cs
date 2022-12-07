using Archimedes.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Archimedes.Data.Abstract
{
    public interface IFavouriteListRepository : IRepository<FavouriteList>
    {
        List<FavouriteList> GetFavouriteListtAll();
        Product GetFavouriteListById(int id);
        List<FavouriteList> GetProductByCustomer(string customer);
    }
}
