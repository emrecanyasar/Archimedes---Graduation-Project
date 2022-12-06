using Archimedes.Core.Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Archimedes.Core.Entities
{
    public class Product : BaseEntity
    {
        public int CategoryId { get; set; }
        public string ProductName { get; set; }
        public int Stock { get; set; }
        public long Price { get; set; }
        public Category Category { get; set; }
        public ICollection<Order> Orders { get; set; }
        public ICollection<ProductList> ProductLists { get; set; }

    }
}
