using System;
using System.Linq;

namespace PandyIT.Core.Collections.Extensions
{
    public static class QueryableExtensions
    {
        public static IQueryable<TEntity> IncludeAssociations<TEntity>(this IQueryable<TEntity> query, Func<IQueryable<TEntity>, IQueryable<TEntity>> include) where TEntity : class
        {
            return include(query);
        }
    }
}
