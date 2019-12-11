using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Blog.SqlServer.EntityFrameworkCore.Extensions
{
    public sealed class DbContextPagination<T>
    {
        public int Page { get; }
        public int PageSize { get; }
        public int TotalPages { get; }
        public int TotalCount { get; }
        public bool HasPreviousPage => Page > 1;
        public bool HasNextPage => Page < TotalPages;
        public IEnumerable<T> Items { get; set; }

        public DbContextPagination(IEnumerable<T> items, int count, int page, int pageSize)
        {
            Page = page;
            PageSize = pageSize;
            TotalPages = (int)Math.Ceiling(count / (double)pageSize);
            TotalCount = count;
            Items = items;
        }
    }

    public static class DbContextPaginationExtensions
    {
        public static DbContextPagination<TEntity> PaginationToList<TEntity>(this IQueryable<TEntity> source, int page = 1, int pageSize = 10) where TEntity : class
        {
            var count = source.Count();
            var items = source.Skip((page - 1) * pageSize).Take(pageSize).ToList();
            return new DbContextPagination<TEntity>(items, count, page, pageSize);
        }

        public static async Task<DbContextPagination<TEntity>> PaginationToListAsync<TEntity>(this IQueryable<TEntity> source, int page = 1, int pageSize = 10) where TEntity : class
        {
            var count = await source.CountAsync();
            var items = await source.Skip((page - 1) * pageSize).Take(pageSize).ToListAsync();
            return new DbContextPagination<TEntity>(items, count, page, pageSize);
        }

        public static DbContextPagination<TModel> Map<TEntity, TModel>(this DbContextPagination<TEntity> pagination, Func<TEntity, TModel> map)
        {
            var items = pagination.Items.Select(map);
            return new DbContextPagination<TModel>(items, pagination.TotalCount, pagination.Page, pagination.PageSize);
        }
    }
}
