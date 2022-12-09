using Archimedes.Entity.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Archimedes.Entity
{
    public class ShopListDetail : BaseEntity<int>
    {
        public int ShopListId { get; set; }
        public int ProductId { get; set; }
        public short Quantity { get; set; }
        public int UnitPrice { get; set; }
        public ShopList ShopList { get; set; }
        public Product Product { get; set; }
    }
}
