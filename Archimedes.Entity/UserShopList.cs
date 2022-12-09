using Archimedes.Entity.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Archimedes.Entity
{
    public class UserShopList : BaseEntity<int>
    {
        public int ShopListId { get; set; }
        public ShopList ShopList { get; set; }
        public AppUser AppUser { get; set; }
    }
}
