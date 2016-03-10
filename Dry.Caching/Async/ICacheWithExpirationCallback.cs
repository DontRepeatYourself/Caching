using System;
using System.Threading.Tasks;

namespace Dry.Caching.Async
{
    public interface ICacheWithExpirationCallback : ICacheWithExpiration
    {
        Task SetAsync<TValue>(string key, TValue value, TimeSpan slidingExpiration, Func<TValue> onExpiry);

        Task SetAsync<TValue>(string key, TValue value, DateTime absoluteExpiration, Func<TValue> onExpiry);
    }
}
