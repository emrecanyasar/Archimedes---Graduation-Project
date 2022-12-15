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
        Product GetProductDetails(int id);
        List<Product> GetProductsByCategory(string category);
        List<Product> GetSearchResult(string searchString);
        void Create(Product entity, int[] categoryIds);
        Task<List<Product>> GetAllCategory();


    }
}
