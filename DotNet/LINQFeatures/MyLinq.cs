using System;
using System.Collections.Generic;
using System.Text;

namespace LINQFeatures
{
    public static class MyLinq
    {
        public static int Count<T>(this IEnumerable<T> seqwence)
        {
            int count = 0;
            foreach (var item in seqwence)
            {
                count += 1;
            }
            return count;
        }
    }
}
