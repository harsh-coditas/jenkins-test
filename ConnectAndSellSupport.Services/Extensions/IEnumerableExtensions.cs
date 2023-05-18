using System.Collections.Generic;
using System.Linq;

namespace ConnectAndSellSupport.Services.Extensions
{
    public static class IEnumerableExtensions
    {
        public static bool IsNullOrEmpty<T>(this IEnumerable<T> list)
        {
            return !list?.Any() ?? true;
        }
    }
}
