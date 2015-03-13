using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Extension_Methods_Delegates_Lambda_LINQ
{
    /// <summary>
    /// Problem 2. IEnumerable extensions
    /// Implement a set of extension methods for IEnumerable<T> that implement the following group functions: sum, product, min, max, average.
    /// </summary>
    static class IEnumerableExtensions
    {
        public static T SumExt<T>(this IEnumerable<T> source)
        {
            T sum = (dynamic)0;
            foreach (var item in source)
            {
                sum += (dynamic)item;
            }
            return sum;
        }

        public static T ProductExt<T>(this IEnumerable<T> source)
        {
            T sum = (dynamic)1;
            foreach (var item in source)
            {
                sum *= (dynamic)item;
            }
            return sum;
        }

        public static T MinExt<T>(this IEnumerable<T> source)
        {
            return source.Min<T>();
        }

        public static T MaxExt<T>(this IEnumerable<T> source)
        {
            return source.Max<T>();
        }
    }
}
