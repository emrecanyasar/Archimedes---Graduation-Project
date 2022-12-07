using Archimedes.Entity.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Archimedes.Entity
{
    public class Product : BaseEntity
    {
        public int CategoryId { get; set; }
        public string ProductName { get; set; }
        public int Stock { get; set; }
        public long Price { get; set; }
        public Category Category { get; set; }
        public ICollection<Order> Orders { get; set; }
        public ICollection<FavouriteList> ProductLists { get; set; }

    }
}
