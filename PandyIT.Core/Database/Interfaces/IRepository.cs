using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;

namespace PandyIT.Core.Database.Interfaces
{
    public interface IRepository<TEntity> where TEntity : class
    {
        TEntity Create(TEntity entity);

        IEnumerable<TEntity> Find(Expression<Func<TEntity, bool>> predicate);

        IEnumerable<TEntity> Find(Expression<Func<TEntity, bool>> predicate, Func<IQueryable<TEntity>, IQueryable<TEntity>> include);

        TEntity Update(TEntity entity);

        void Delete(TEntity entity);
    }
}
