using Archimedes.Data.Abstract;
using Archimedes.Entity.Abstract;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Archimedes.Data.Concrete.EfCore
{
    public abstract class EfCoreGenericRepository<TEntity, TKey> : IRepository<TEntity, TKey> where TEntity : BaseEntity<TKey> where TKey : IEquatable<TKey>
    {
        public readonly ArchimedeDbContext _dbContext;
        public readonly DbSet<TEntity> _table;

        public EfCoreGenericRepository(ArchimedeDbContext context)
        {
            _dbContext= context;
            _table= _dbContext.Set<TEntity>();
        }
       
        public IQueryable<TEntity> Get(Expression<Func<TEntity, bool>> predicate = null)
        {
            return predicate == null ? _table : _table.Where(predicate);
        }

        public TEntity GetById(TKey id)
        {
            return _table.Find(id);
        }
        public TKey Insert(TEntity entity)
        {
            _table.Add(entity);
            return entity.Id;
        }
        public int Delete(TEntity entity)
        {
            _table.Remove(entity);
            return 1;
        }


        public int Save()
        {
            return _dbContext.SaveChanges();
        }

        public int Update(TEntity entity)
        {
            _table.Update(entity);
            return 1;
        }
    }
}
