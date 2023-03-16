using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;

using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace EFDBFrist.DataAccess
{
    public static class QueryExtensions
    {
        public static IQueryable<T> Query<T>(this DbContext context, bool isEager = false) where T : class
        {
            var query = context.Set<T>().AsQueryable();
            query = context.ProcessEager(query, isEager);
            return query;
        }

        public static IQueryable<T> Include<T, TProperty>(this IQueryable<T> query, Expression<Func<T, TProperty>> navigationPropertyPath) where T : class
        {
            return EntityFrameworkQueryableExtensions.Include(query, navigationPropertyPath);
        }
        //public static IQueryable<T> ThenInclude<T, TPreviousProperty, TProperty>(this IQueryable<T> query, Expression<Func<T, TPreviousProperty>> navigationPropertyPath, Expression<Func<TPreviousProperty, TProperty>> thenNavigationPropertyPath) where T : class
        //{
        //    var queryTemp = EntityFrameworkQueryableExtensions.Include(query, navigationPropertyPath);

        //    return EntityFrameworkQueryableExtensions.ThenInclude((Microsoft.EntityFrameworkCore.Query.IIncludableQueryable<T, IEnumerable<TPreviousProperty>>)queryTemp, thenNavigationPropertyPath);
        //}

        public static IQueryable<T> Query<T>(this DbContext context, Expression<Func<T, T>> selector, bool isEager = false) where T : class
        {
            var query = context.Set<T>().Select(selector);
            query = context.ProcessEager(query, isEager);
            return query;
        }

        public static IQueryable<T> Query<T>(this DbContext context, Expression<Func<T, bool>> predicate, bool isEager = false) where T : class
        {
            var query = context.Set<T>().Where(predicate);
            query = context.ProcessEager(query, isEager);
            return query;
        }

        public static IQueryable<T> Query<T>(this DbContext context, Expression<Func<T, bool>> predicate, Expression<Func<T, T>> selector, bool isEager = false) where T : class
        {
            var query = context.Set<T>().Where(predicate);
            query = context.ProcessEager(query, isEager);
            return query.Select(selector);
        }
        public static IQueryable<T> QueryAmr<T>(this DbContext context, Expression<Func<T, bool>> predicate) where T : class
        {
            var query = context.Set<T>().Where(predicate);
            return query;
        }

        public static IQueryable<TResult> Query<T, TResult>(this DbContext context, Expression<Func<T, bool>> predicate, Expression<Func<T, TResult>> selector, bool isEager = false) where T : class
        {
            var query = context.Set<T>().Where(predicate);
            query = context.ProcessEager(query, isEager);
            return query.Select(selector);
        }

        public static IQueryable<TResult> Query<T, TResult>(this DbContext context, Expression<Func<T, TResult>> selector, bool isEager = false) where T : class
        {
            var query = context.Set<T>().AsQueryable();
            query = context.ProcessEager(query, isEager);
            return query.Select(selector);
        }

        private static IQueryable<T> ProcessEager<T>(this DbContext context, IQueryable<T> query, bool isEager) where T : class
        {
            if (isEager)
            {
                var navigations = context.Model.FindEntityType(typeof(T))
                    .GetDerivedTypesInclusive()
                    .SelectMany(type => type.GetNavigations())

                    .Distinct();

                foreach (var property in navigations)
                    query = query.Include(property.Name).AsSingleQuery();
            }

            return query;
        }

        public static Task<List<TSource>> ToListAsyncSafe<TSource>(this IQueryable<TSource> source)
        {
            if (source == null)
                throw new ArgumentNullException(nameof(source));
            if (source is IAsyncEnumerable<TSource>)
                return source.ToListAsync();
            else
                return Task.FromResult(source.ToList());
        }

        public static Task<TSource> FirstOrDefaultAsyncSafe<TSource>(this IQueryable<TSource> source)
        {
            return Task.FromResult(source.FirstOrDefault());
            //return source.SingleOrDefaultAsync();
            //if (source == null)
            //    throw new ArgumentNullException(nameof(source));
            //if (source is IAsyncEnumerable<TSource>)
            //else
            //    return Task.FromResult(source.FirstOrDefault());
        }

        //public static IQueryable<T> AsNoTracking<T>(this IQueryable<T> values) => values.AsNoTracking(); 
    }
}
