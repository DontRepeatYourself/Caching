using System;

using Enyim.Caching;
using Enyim.Caching.Memcached;

namespace Dry.Caching.Memcached
{
    public class MemcachedCache : ICacheWithExpiration
    {
        private readonly IMemcachedClient memcachedClient;

        public MemcachedCache(IMemcachedClient memcachedClient)
        {
            if (memcachedClient == null)
                throw new ArgumentNullException(nameof(memcachedClient));

            this.memcachedClient = memcachedClient;
        }

        public TValue Get<TValue>(string key)
        {
            return memcachedClient.Get<TValue>(key);
        }

        public void Set<TValue>(string key, TValue value)
        {
            memcachedClient.Store(StoreMode.Replace, key, value);
        }

        public void Set<TValue>(string key, TValue value, TimeSpan slidingExpiration)
        {
            memcachedClient.Store(StoreMode.Replace, key, value, slidingExpiration);
        }

        public void Set<TValue>(string key, TValue value, DateTime absoluteExpiration)
        {
            memcachedClient.Store(StoreMode.Replace, key, value, absoluteExpiration);
        }
    }
}
