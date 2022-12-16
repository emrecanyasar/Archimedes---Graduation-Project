using Archimedes.Data.Abstract;
using Archimedes.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Archimedes.Data.Concrete.EfCore
{
    public class EfCoreUserRepository : EfCoreGenericRepository<AppUser>, IUserRepository
    {
        public EfCoreUserRepository(ArchimedeDbContext context) : base(context)
        {

        }

        public ArchimedeDbContext archimedeDbContext
        {
            get
            {
                return _dbContext as ArchimedeDbContext;
            }
        }

        public List<ShopList> GetListByUser(string userId)
        {
            throw new NotImplementedException();
        }
    }
}
