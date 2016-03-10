using System.Threading.Tasks;

namespace Dry.Caching.Async
{
    public interface ICacheReader
    {
        Task<T> GetAsync<T>(string key);
    }
}
