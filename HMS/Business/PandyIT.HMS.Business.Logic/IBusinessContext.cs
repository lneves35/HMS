using System;
using System.Collections.Generic;
using System.Linq.Expressions;

namespace PandyIT.HMS.Business.Logic
{
    public interface IBusinessContext
    {
        IEnumerable<T> GetEntities<T>(Expression<Func<T, bool>> predicate) where T : class;
    }
}