using Archimedes.Business.Abstract;
using Archimedes.Data.Abstract;
using Archimedes.Data.Concrete.EfCore;
using Archimedes.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Archimedes.Business.Concrete
{
    public class CategoryManager : ICategoryService
    {
        public ICategoryRepository _categoryRepository;

        public CategoryManager(ICategoryRepository categoryRepository)
        {
            _categoryRepository = categoryRepository;
        }

        public void Create(Category entity)
        {
            _categoryRepository.Create(entity);
        }

        public void Delete(Category entity)
        {
            _categoryRepository.Delete(entity);
        }

        public async Task<List<Category>> GetAll()
        {
            return await _categoryRepository.GetAll();
        }

        public Task<Category> GetById(int id)
        {
            return _categoryRepository.GetById(id);
        }

        public Category GetCategoryByName(string name)
        {
            return _categoryRepository.GetCategoryByName(name);
        }

        public void Update(Category entity)
        {
            _categoryRepository.Update(entity);
        }
    }
}
