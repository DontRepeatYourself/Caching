
namespace Dry.Caching
{
    public interface ICache : ICacheReader
    {
        void Set<T>(string key, T value);
    }
}
