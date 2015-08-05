using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;

namespace PandyIT.HMS.Business.Logic
{
    public interface IBusinessContext
    {
        IEnumerable<T> GetEntities<T>() where T : class;

        IEnumerable<T> GetEntities<T>(Expression<Func<T, bool>> predicate) where T : class;

        IEnumerable<T> GetEntities<T>(Expression<Func<T, bool>> predicate, Func<IQueryable<T>, IQueryable<T>> include) where T : class;
    }
}