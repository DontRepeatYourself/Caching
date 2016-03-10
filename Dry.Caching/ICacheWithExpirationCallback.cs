using System;

namespace Dry.Caching
{
    public interface ICacheWithExpirationCallback : ICacheWithExpiration
    {
        void Set<TValue>(string key, TValue value, TimeSpan slidingExpiration, Func<TValue> onExpiry);

        void Set<TValue>(string key, TValue value, DateTime absoluteExpiration, Func<TValue> onExpiry);
    }
}
