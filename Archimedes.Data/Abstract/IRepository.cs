using Archimedes.Entity.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Archimedes.Data.Abstract
{
    public interface IRepository<T>
    {
        //Bu interface/repository tüm entitylerimiz ilgilendiren CRUD işlemlerini barındırıyor.
        Task<List<T>> GetAll();
        Task<T> GetById(int id);
        void Create(T entity);
        void Update(T entity);
        void Delete(T entity);
    }
}
