using System.Collections.Generic;
using System.Linq;

namespace ConnectAndSellSupport.Services.Extensions
{
    public static class HashSetExtensions
    {
        public static bool IsNullOrEmpty<T>(this HashSet<T> hashSet)
        {
            return !hashSet?.Any() ?? true;
        }
    }
}
