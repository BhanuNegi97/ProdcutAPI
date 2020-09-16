using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace ProductAPI.Filters
{
    public static class SearchExtension
    {
        public static IQueryable<TSource> Search<TSource>(this IQueryable<TSource> source, string searchTerm, params Expression<Func<TSource, string>>[] stringProperties)
        {
            if (String.IsNullOrEmpty(searchTerm))
            {
                return source;
            }
            if (stringProperties.Length == 0) return source.Where(x => false);

            var searchTermExpression = Expression.Constant(searchTerm);
            var param = stringProperties[0].Parameters.Single();
            Expression orExpression = null;

            foreach (var stringProperty in stringProperties)
            {
                var body = SwapExpressionVisitor.Swap(stringProperty.Body, stringProperty.Parameters.Single(), param);

                var checkContainsExpression = Expression.Call(
                    body, typeof(string).GetMethod("Contains", new[] { typeof(string) }), searchTermExpression);

                if (orExpression == null)
                {
                    orExpression = checkContainsExpression;
                }
                else
                {   
                    orExpression = Expression.OrElse(orExpression, checkContainsExpression);
                }
            }

            var lambda = Expression.Lambda<Func<TSource, bool>>(orExpression, param);
            return source.Where(lambda);
        }

    }
}
