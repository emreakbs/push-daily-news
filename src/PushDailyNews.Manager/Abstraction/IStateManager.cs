using System.Threading.Tasks;

namespace PushDailyNews.Manager.Abstraction
{
    public interface IStateManager
    {
        Task ClearStateAsync(string methodName, string language);
        Task<bool> CheckStateAvailableAsync(string stateName);
        Task SetStateAsync(string stateName, string stateValue, CacheTime cacheTime);
    }
}
