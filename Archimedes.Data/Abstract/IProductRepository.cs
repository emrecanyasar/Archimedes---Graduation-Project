using Archimedes.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Archimedes.Data.Abstract
{
    public interface IProductRepository : IRepository<Product>
    {
        List<Product> GetProductAll();
        Product GetProductById(int id);

        List<Product> GetProductByCategory(string category);
        List<Product> GetProductSearchResult(string search);

    }
}
