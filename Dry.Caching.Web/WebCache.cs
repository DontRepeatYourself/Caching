using System;
using System.Web.Caching;

namespace Dry.Caching.Web
{
    public class WebCache : ICacheWithExpirationCallback
    {
        private readonly Cache cache;

        public WebCache(Cache cache)
        {
            if (cache == null)
                throw new ArgumentNullException(nameof(cache));

            this.cache = cache;
        }

        public T Get<T>(string key)
        {
            return (T)cache.Get(key);
        }

        public void Set<T>(string key, T value)
        {
            cache.Insert(key, value);
        }

        public void Set<TValue>(string key, TValue value, TimeSpan slidingExpiration)
        {
            cache.Insert(key, value, null, Cache.NoAbsoluteExpiration, slidingExpiration);
        }

        public void Set<TValue>(string key, TValue value, DateTime absoluteExpiration)
        {
            cache.Insert(key, value, null, absoluteExpiration, Cache.NoSlidingExpiration);
        }

        public void Set<TValue>(string key, TValue value, TimeSpan slidingExpiration, Func<TValue> onExpiry)
        {
            cache.Insert(key, value, null, Cache.NoAbsoluteExpiration, slidingExpiration);
        }

        public void Set<TValue>(string key, TValue value, DateTime absoluteExpiration, Func<TValue> onExpiry)
        {
            cache.Insert(key, value, null, absoluteExpiration, Cache.NoSlidingExpiration);
        }
    }
}
