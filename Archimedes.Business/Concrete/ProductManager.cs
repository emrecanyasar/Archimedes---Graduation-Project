using Archimedes.Business.Abstract;
using Archimedes.Data.Abstract;
using Archimedes.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Archimedes.Business.Concrete
{
    public class ProductManager : IProductService
    {
        IProductRepository _productRepository;

        public ProductManager(IProductRepository productRepository)
        {
            _productRepository = productRepository;
        }

        public void Create(Product entity)
        {
            _productRepository.Create(entity);
        }

        public void Create(Product entity, int[] categoryIds)
        {
             _productRepository.Create(entity, categoryIds);
        }

        public void Delete(Product entity)
        {
            _productRepository.Delete(entity);
        }

        public async Task<List<Product>> GetAll()
        {
            return await _productRepository.GetAll();
        }

        public async Task<List<Product>> GetAllProducts()
        {
            return await _productRepository.GetAllCategory();
        }

        public async Task<Product> GetById(int id)
        {
            return await _productRepository.GetById(id);
        }

        public Product GetProductByName(string name)
        {
            return _productRepository.GetProductByName(name);
        }

        public Product GetProductDetails(int id)
        {
            return _productRepository.GetProductDetails(id);
        }

        public List<Product> GetProductsByCategory(string category)
        {
            return _productRepository.GetProductsByCategory(category);
        }

        public List<Product> GetSearchResult(string searchString)
        {
            return _productRepository.GetSearchResult(searchString);
        }

        public void Update(Product entity)
        {
            _productRepository.Update(entity);
        }


    }
}
