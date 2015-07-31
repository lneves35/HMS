using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.Core.Metadata.Edm;
using System.Linq;
using System.Linq.Expressions;
using LinqKit;
using PandyIT.Core.Database.Interfaces;

namespace PandyIT.Core.Database.Implementations
{
    public class Repository<TEntity> : IRepository<TEntity> where TEntity : class
    {
        private DbContext DbContext { get; set; }

        private DbSet<TEntity> EntitySet { get; set; }

        public Repository(DbContext dbContext)
        {
            DbContext = dbContext;
            EntitySet = dbContext.Set<TEntity>();
        }

        public TEntity Create(TEntity entity)
        {
            var ret = EntitySet.Add(entity);
            DbContext.SaveChanges();
            return ret;
        }

        public IEnumerable<TEntity> Find(Expression<Func<TEntity, bool>> predicate)
        {
            predicate = predicate ?? PredicateBuilder.True<TEntity>();
            return EntitySet.AsExpandable().Where(predicate);
        }

        public TEntity Update(TEntity entity)
        {
            EntitySet.Attach(entity);
            DbContext.Entry(entity).State = EntityState.Modified;
            DbContext.SaveChanges();
            return entity;
        }

        public void Delete(TEntity entity)
        {
            if (DbContext.Entry(entity).State == EntityState.Detached)
            {
                EntitySet.Attach(entity);
            }
            EntitySet.Remove(entity);
            DbContext.SaveChanges();
        }
    }
}
