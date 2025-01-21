using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shared.Cache.Redis
{
    public enum CacheType
    {
        Common = 0,
        Global = 1,
        Users = 2,
        UserTokens = 3,
    }
}
