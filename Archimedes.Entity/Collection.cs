using Archimedes.Entity.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Archimedes.Entity
{
    public class Collection : BaseEntity
    {
        public short Quantity { get; set; }
        public ICollection<Product> Products { get; set; }
        public ICollection<Customer> Customers { get; set; }
    }
}