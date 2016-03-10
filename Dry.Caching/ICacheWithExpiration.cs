using System;

namespace Dry.Caching
{
    public interface ICacheWithExpiration : ICache
    {
        void Set<TValue>(string key, TValue value, TimeSpan slidingExpiration);

        void Set<TValue>(string key, TValue value, DateTime absoluteExpiration);
    }
}
