using Archimedes.Entity.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Archimedes.Entity
{
    public class Product : BaseEntity<int>
    {
        public int CategoryId { get; set; }
        public string ProductName { get; set; }
        public long Price { get; set; }
        public string ImageUrl { get; set; }
        public Category Category { get; set; }
        public ICollection<OrderDetail> OrderDetails { get; set; }
        public ICollection<ShopListDetail> ShopListDetails { get; set; }

    }
}
