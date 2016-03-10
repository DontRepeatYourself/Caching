
namespace Dry.Caching
{
    public interface ICacheReader
    {
        T Get<T>(string key);
    }
}
