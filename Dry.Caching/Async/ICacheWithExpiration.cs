using System;
using System.Threading.Tasks;

namespace Dry.Caching.Async
{
    public interface ICacheWithExpiration : ICache
    {
        Task SetAsync<TObject>(string key, TObject value, TimeSpan slidingExpiration);

        Task SetAsync<TObject>(string key, TObject value, DateTime absoluteExpiration);
    }
}
