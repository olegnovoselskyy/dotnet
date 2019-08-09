using System;
using System.Collections.Generic;
using System.Text;

namespace Queries
{
    public static class MyLinqcs
    {
        public static IEnumerable<T> Filter<T>(this IEnumerable<T> source,
                                                Func<T, bool> predicate)
        {
            foreach (var item in source)
            {
                if (predicate(item))
                {
                    yield return item;
                }
            }
        }
    }
}
