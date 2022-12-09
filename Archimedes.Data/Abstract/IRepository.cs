using Archimedes.Entity.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Archimedes.Data.Abstract
{
    public interface IRepository<TEntity, TKey> where TEntity : class where TKey : IEquatable<TKey>
    {
        IQueryable<TEntity> Get(Expression<Func<TEntity, bool>> predicate = null);
        TEntity GetById(TKey id);
        TKey Insert(TEntity entity);
        int Update(TEntity entity);
        int Delete(TEntity entity);
        int Save();
    }
}
