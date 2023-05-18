using System.Collections.Generic;
using System.Threading.Tasks;

namespace ConnectAndSellSupport.Services.Helpers.Redis
{
    public interface IRedisCacheService
    {
        Task<Tout> GetAsync<Tout>(string key);
        Task<IDictionary<string, Tout>> GetMultiAsync<Tout>(IEnumerable<string> keys);
        Task SetAsync<T>(string key, T value);
        Task SetMultiAsync<T>(IDictionary<string, T> keyValuePairs);
    }
}
