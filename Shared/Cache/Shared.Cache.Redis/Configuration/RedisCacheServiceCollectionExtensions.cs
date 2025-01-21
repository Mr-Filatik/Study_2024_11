using Microsoft.Extensions.DependencyInjection;
using StackExchange.Redis;

namespace Shared.Cache.Redis.Configuration
{
    public static class RedisCacheServiceCollectionExtensions
    {
        public static void AddRedisCache(this IServiceCollection services)
        {
            var redOpt = new ConfigurationOptions()
            {
                EndPoints = { "localhost:6379" },
                //AbortOnConnectFail = false,
            };

            var mp = ConnectionMultiplexer.Connect(redOpt);
            services.AddSingleton(mp);

            services.AddSingleton<ICacher, Cacher>();
        }
    }
}
