using Microsoft.Extensions.Logging;
using StackExchange.Redis;

namespace Shared.Cache.Redis
{
    public class Cacher : ICacher
    {
        private readonly ConnectionMultiplexer? _multiplexer;
        private readonly ILogger<Cacher> _logger;

        public Cacher(ConnectionMultiplexer? multiplexer, ILogger<Cacher> logger)
        {
            _multiplexer = multiplexer;
            _logger = logger;
        }

        public void SetString(string key, string value, CacheType type)
        {
            var db = _multiplexer.GetDatabase((int)type);
            db.StringSet(
                new RedisKey(key), 
                new RedisValue(value), 
                expiry: new TimeSpan(0, 10, 0));
        }

        public string GetString(string key, CacheType type)
        {
            var db = _multiplexer.GetDatabase((int)type);
            var value = db.StringGet(new RedisKey(key));
            if (value != RedisValue.Null)
            {
                return value.ToString();
            }
            return "";
        }

        public void PubString(string channel, string value)
        {
            var sb = _multiplexer.GetSubscriber();
            sb.Publish(
                new RedisChannel(channel, RedisChannel.PatternMode.Literal),
                new RedisValue(value));
        }

        public void SubString(string channel)
        {
            var sb = _multiplexer.GetSubscriber();
            sb.Subscribe(channel, (c, v) =>
            {
                _logger.LogInformation(v.ToString());
            });
        }
    }
}
