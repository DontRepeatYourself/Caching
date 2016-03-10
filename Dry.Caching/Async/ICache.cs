using System.Threading.Tasks;

namespace Dry.Caching.Async
{
    public interface ICache : ICacheReader
    {
        Task SetAsync<T>(string key, T value);
    }
}
