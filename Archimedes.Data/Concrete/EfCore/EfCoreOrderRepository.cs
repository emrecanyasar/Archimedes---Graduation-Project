using Archimedes.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Archimedes.Data.Concrete.EfCore
{
    public class EfCoreOrderRepository :EfCoreGenericRepository<Order>
    {
        public EfCoreOrderRepository(ArchimedeDbContext context) : base(context)
        {

        }
    }
}
