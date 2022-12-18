using Archimedes.Entity.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Archimedes.Entity
{
    public class ShopList : BaseEntity<int>
    {
        public string ShopListName { get; set; }
        public bool Use { get; set; } = false;
        public ICollection<Product> Products { get; set; }
        public ICollection<UserShopList> UserShopLists { get; set; }
    }
}