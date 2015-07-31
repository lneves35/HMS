using System;
using System.Collections.Generic;
using System.Linq.Expressions;

namespace PandyIT.Core.Database.Interfaces
{
    public interface IRepository<TEntity> where TEntity : class
    {
        TEntity Create(TEntity entity);

        IEnumerable<TEntity> Find(Expression<Func<TEntity, bool>> predicate);

        TEntity Update(TEntity entity);

        void Delete(TEntity entity);
    }
}
