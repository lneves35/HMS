﻿using System;
using System.Data.Entity;

namespace PandyIT.Core.Database.Interfaces
{
    public interface IUnitOfWork : IDisposable
    {
        //DbContext Context { get; }

        IRepository<TEntity> GetRepository<TEntity>() where TEntity : class;
    }
}
