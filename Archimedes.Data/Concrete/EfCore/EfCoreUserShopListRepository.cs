using Archimedes.Data.Abstract;
using Archimedes.Entity;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Archimedes.Data.Concrete.EfCore
{
    public class EfCoreUserShopListRepository : EfCoreGenericRepository<UserShopList>, IUserShopListRepository
    {
        public EfCoreUserShopListRepository(ArchimedeDbContext context) : base(context)
        {

        }

        public ArchimedeDbContext archimedeDbContext
        {
            get
            {
                return _dbContext as ArchimedeDbContext;
            }
        }

        public List<UserShopList> AllList(string userId)
        {
            List<UserShopList> userShopLists = new List<UserShopList>();
            userShopLists = archimedeDbContext.UserShopLists.Include(x=>x.AppUser)
                .Include(usl => usl.ShopList).ToList();
            userShopLists.RemoveAll(x=>x.AppUserId==userId);
            return userShopLists;
        }

        public void Create(string userId,int shopListId)
        {
            var userShopList = new UserShopList()
            {
                ShopListId = shopListId,
                AppUserId = userId
            };
            archimedeDbContext.UserShopLists.Add(userShopList);
            archimedeDbContext.SaveChanges();
        }
    }
}
