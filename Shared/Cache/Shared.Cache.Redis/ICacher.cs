using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shared.Cache.Redis
{
    public interface ICacher
    {
        public void SetString(string key, string value, CacheType type);

        public string GetString(string key, CacheType type);

        public void PubString(string channel, string value);

        public void SubString(string channel);
    }
}
