using Archimedes.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Archimedes.Business.Abstract
{
    public interface IProductService
    {
        void Create(Product entity);
        void Create(Product entity, int[] categoryIds);

        void Update(Product entity);

        void Delete(Product entity);

        Task<Product> GetById(int id);

        Task<List<Product>> GetAll();
        Product GetProductDetails(int id);
        List<Product> GetProductsByCategory(string category);
        List<Product> GetSearchResult(string searchString);
        Task<List<Product>> GetAllProducts();



    }
}
