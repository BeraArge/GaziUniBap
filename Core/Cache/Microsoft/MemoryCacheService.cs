using Microsoft.Extensions.Caching.Memory;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Core.Cache.Microsoft
{
    public class MemoryCacheService : IMemoryService
    {
        private readonly IMemoryCache _memoryCache;

        public MemoryCacheService(IMemoryCache memoryCache)
        {
            _memoryCache = memoryCache;
        }

        public void Add(string key, object data, DateTimeOffset? duration)
        {
            if (duration.HasValue && duration.Value != DateTimeOffset.MinValue)
            {
                var opt = new MemoryCacheEntryOptions
                {
                    AbsoluteExpiration = duration,
                };
                _memoryCache.Set(key, data, opt);
            }
            else
                _memoryCache.Set(key, data);
        }

        public long CacheSize()
        {
            var _coherentState = typeof(MemoryCache).GetField("_coherentState", BindingFlags.Instance | BindingFlags.NonPublic);
            var _coherentStateValue = _coherentState.GetValue(_memoryCache);
            long result = (long)_coherentStateValue.GetType().GetField("_cacheSize", BindingFlags.Instance | BindingFlags.NonPublic).GetValue(_coherentStateValue);


            return result;
        }

        public T Get<T>(string key)
        {
            return _memoryCache.Get<T>(key);
        }

        public object Get(string key)
        {
            return _memoryCache.Get(key);
        }

        public List<ICacheEntry> GetAll()
        {
            List<ICacheEntry> result = new();
            var _coherentState = typeof(MemoryCache).GetField("_coherentState", BindingFlags.Instance | BindingFlags.NonPublic);
            var _coherentStateValue = _coherentState.GetValue(_memoryCache);
            var entryCollection = _coherentStateValue.GetType().GetProperty("EntriesCollection", BindingFlags.Instance | BindingFlags.NonPublic).GetValue(_coherentStateValue, null);

            var cacheEntriesCollection = entryCollection as dynamic;
            foreach (var cacheItem in cacheEntriesCollection)
                result.Add(cacheItem.GetType().GetProperty("Value").GetValue(cacheItem, null));

            return result;
        }

        public int GetCount()
        {
            var _coherentState = typeof(MemoryCache).GetField("_coherentState", BindingFlags.Instance | BindingFlags.NonPublic);
            var _coherentStateValue = _coherentState.GetValue(_memoryCache);

            int result = (int)_coherentStateValue.GetType().GetProperty("Count", BindingFlags.Instance | BindingFlags.NonPublic).GetValue(_coherentStateValue, null);

            return result; ;
        }

        public bool IsAdd(string key)
        {
            var value = _memoryCache.TryGetValue(key, out _);
            return value;
        }

        public void Remove(string key)
        {
            _memoryCache.Remove(key);
        }
    }
}
