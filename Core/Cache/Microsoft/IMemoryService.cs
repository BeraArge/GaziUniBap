using Microsoft.Extensions.Caching.Memory;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Cache.Microsoft
{
    public interface IMemoryService
    {
        List<ICacheEntry> GetAll();
        T Get<T>(string key);
        object Get(string key);

        long CacheSize();
        int GetCount();

        void Add(string key, object data, DateTimeOffset? duration);
        bool IsAdd(string key);
        void Remove(string key);
    }
}
