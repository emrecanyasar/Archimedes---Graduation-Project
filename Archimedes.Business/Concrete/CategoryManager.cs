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
            Category category = new Category();
            category.Id = entity.Id;
            category.CategoryName = entity.CategoryName;
        }

        public void Delete(Category entity)
        {
            throw new NotImplementedException();
        }

        public List<Category> GetAll()
        {
           return _categoryRepository.Get().ToList();
        }

        public Category GetById(int id)
        {
            throw new NotImplementedException();
        }

        public Category GetByName(string name)
        {
            throw new NotImplementedException();
        }

        public void Update(Category entity)
        {
            throw new NotImplementedException();
        }
    }
}
