using ServiceStack.Redis;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace ConnectAndSellSupport.Services.Helpers.Redis
{
    public class RedisCacheService : IRedisCacheService
    {
        #region Private members
        private readonly IRedisClientsManager _redisClientsManager;
        #endregion

        #region Constructor
        public RedisCacheService(IRedisClientsManager redisClientsManager)
        {
            _redisClientsManager = redisClientsManager;
        }
        #endregion

        #region Interface implementations
        public async Task<Tout> GetAsync<Tout>(string key)
        {
            await using var redis = await _redisClientsManager.GetCacheClientAsync();
            return await redis.GetAsync<Tout>(key);
        }

        public async Task<IDictionary<string, Tout>> GetMultiAsync<Tout>(IEnumerable<string> keys)
        {
            await using var redis = await _redisClientsManager.GetCacheClientAsync();
            return await redis.GetAllAsync<Tout>(keys);
        }

        public async Task SetAsync<T>(string key, T value)
        {
            await using var redis = await _redisClientsManager.GetCacheClientAsync();
            await redis.SetAsync(key, value);
        }

        public async Task SetMultiAsync<T>(IDictionary<string, T> keyValuePairs)
        {
            await using var redis = await _redisClientsManager.GetCacheClientAsync();
            await redis.SetAllAsync(keyValuePairs);
        }
        #endregion
    }
}
