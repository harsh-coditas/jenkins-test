using ConnectAndSellSupport.Services.Helpers.Redis;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using ServiceStack.Redis;

namespace ConnectAndSellSupport.API.Configuration
{
    public static class RedisConfiguration
    {
        public static void ConfigureRedis(this IServiceCollection services, IConfiguration configuration)
        {
            var redisSettingsSection = configuration["RedisConnection"];
            var redisFactory = new PooledRedisClientManager(redisSettingsSection)
            {
                ConnectTimeout = 5,
                IdleTimeOutSecs = 30,
                PoolTimeout = 3
            };
            services.AddSingleton<IRedisClientsManager>(c => redisFactory);
            services.AddSingleton<IRedisCacheService, RedisCacheService>();
        }
    }
}
