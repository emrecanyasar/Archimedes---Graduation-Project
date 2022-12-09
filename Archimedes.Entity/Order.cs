using Archimedes.Entity.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Archimedes.Entity
{
    public class Order : BaseEntity<int>
    {
        public AppUser AppUser { get; set; }
        public ICollection<OrderDetail> OrderDetails { get; set; }
    }
}
