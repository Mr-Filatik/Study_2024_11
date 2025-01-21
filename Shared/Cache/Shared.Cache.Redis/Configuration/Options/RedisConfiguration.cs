using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shared.Cache.Redis.Configuration.Options
{
    public class RedisConfiguration
    {
        public string Endpoint { get; set; }

        public string Username { get; set; }

        public string Password { get; set; }
    }
}
