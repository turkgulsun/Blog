using Blog.SqlServer.EntityFrameworkCore.Abstractions;
using System;
using System.Linq;

namespace Blog.SqlServer.EntityFrameworkCore.Extensions
{
    public static class CultureExtensions
    {
        public static IQueryable<TEntity> Culture<TEntity>(this IQueryable<TEntity> queryable, string culture) where TEntity : class, ICultureBase, IEntityFramework
        {
            return queryable.Where(x => x.Culture.Equals(culture, StringComparison.OrdinalIgnoreCase));
        }
    }
}
