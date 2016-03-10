using System;

namespace Dry.Caching
{
    public delegate TValue ExpirationCallback<TValue>();

    public interface ICacheWithExpiryCallback : ICacheWithExpiration
    {
        void Set<TValue>(string key, TValue value, TimeSpan slidingExpiration, ExpirationCallback<TValue> onExpiration);
        void Set<TValue>(string key, TValue value, DateTime absoluteExpiration, ExpirationCallback<TValue> onExpiration);
    }
}
