using System;
using System.Collections.Generic;
using System.Data.Entity;
using PandyIT.Core.Database.Interfaces;

namespace PandyIT.Core.Database.Implementations
{
    public class UnitOfWork : IUnitOfWork
    {
        private bool disposed;

        private readonly Dictionary<Type, object> repositories = new Dictionary<Type, object>();

        private DbContext DbContext { get; set; }

        public UnitOfWork(DbContext context)
        {
            DbContext = context;
        }

        public IRepository<TEntity> GetRepository<TEntity>() where TEntity : class
        {
            IRepository<TEntity> repo;

            if (repositories.ContainsKey(typeof (TEntity)))
            {
                repo = repositories[typeof (TEntity)] as IRepository<TEntity>;
            }
            else
            {
                repo = new Repository<TEntity>(DbContext) as IRepository<TEntity>;
                repositories.Add(typeof (TEntity), repo);
            }

            return repo;
        }

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }

        private void Dispose(bool disposing)
        {
            if (disposed || !disposing)
                return;

            if (DbContext != null)
                DbContext.Dispose();

            disposed = true;
        }
    }
}
