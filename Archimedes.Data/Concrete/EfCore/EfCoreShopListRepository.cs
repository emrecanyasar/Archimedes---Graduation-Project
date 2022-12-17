using Archimedes.Data.Abstract;
using Microsoft.EntityFrameworkCore;
using Archimedes.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Archimedes.Data.Concrete.EfCore
{
    public class EfCoreShopListRepository : EfCoreGenericRepository<ShopList>, IShopListRepository
    {
        public EfCoreShopListRepository(ArchimedeDbContext context) : base(context)
        {

        }

        public ArchimedeDbContext archimedeDbContext
        {
            get
            {
                return _dbContext as ArchimedeDbContext;
            }
        }

        public void Create(ShopList entity, string userId)
        {
            archimedeDbContext.ShopLists.Add(entity);
            archimedeDbContext.SaveChanges();
            //entity.UserShopLists = userId
            //    .Select(catId => new UserShopList
            //    {
            //        AppUserId = userId,
            //        ShopListId = entity.Id
            //    }).ToList();
            var shoplist = new UserShopList
             {
                 AppUserId = userId,
                 ShopListId = entity.Id
             };
            archimedeDbContext.UserShopLists.Add(shoplist);
            archimedeDbContext.SaveChanges();
        }

        public List<ShopList> GetShopListByUser(string userId)
        {
            List<ShopList> shopLists = new List<ShopList>();
            if (!string.IsNullOrEmpty(userId))
            {
                shopLists = archimedeDbContext
                                  .ShopLists
                                  .Include(usl=>usl.UserShopLists)
                                  .ThenInclude(au=>au.AppUser)
                                  .Where(usl=>usl.UserShopLists.Any(au=>au.AppUser.Id==userId))
                                  .ToList();
            }
            else
            {
                shopLists = archimedeDbContext.ShopLists.ToList();
            }
            return shopLists;
        }

        public void ShopUse(int id)
        {
            throw new NotImplementedException();
        }

        //public void ShopUse(int id)
        //{
        //    var item = archimedeDbContext.ShopLists.Find(id);
        //    if (item.Use == false)
        //    {
        //        item.Use = true;
        //    }
        //    else
        //    {

        //    }

        //}
    }
}
