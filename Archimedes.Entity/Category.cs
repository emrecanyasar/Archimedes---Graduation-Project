using Archimedes.Entity.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Archimedes.Entity
{
    public class Category : BaseEntity<int>
    {
        public string CategoryName { get; set; }
        public ICollection<Product> Products { get; set; }
    }
}