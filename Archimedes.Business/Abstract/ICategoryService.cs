using Archimedes.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Archimedes.Business.Abstract
{
    public interface ICategoryService
    {
        void Create(Category entity);

        void Update(Category entity);

        void Delete(Category entity);

        Task<Category> GetById(int id);

        Task<List<Category>> GetAll();
        Category GetCategoryByName(string name);

    }
}
