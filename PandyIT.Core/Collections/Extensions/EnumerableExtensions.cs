using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PandyIT.Core.Collections.Extensions
{
    public static class EnumerableExtensions
    {
        public static void ForEachInEnumerable<TEnumerable>(this IEnumerable<TEnumerable> enumerable, Action<TEnumerable> action)
        {
            foreach (var item in enumerable)
            {
                action(item);
            }
        }
    }
}
