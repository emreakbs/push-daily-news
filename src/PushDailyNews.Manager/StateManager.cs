
using PushDailyNews.Infrastructure;
using PushDailyNews.Manager.Abstraction;
using System.Threading.Tasks;

namespace PushDailyNews.Manager
{
    public class StateManager : IStateManager
    {
        private readonly ICacheProvider _cacheProvider;

        public StateManager(ICacheProvider cacheProvider)
        {
            _cacheProvider = cacheProvider;
        }

        public async Task ClearStateAsync(string methodName, string language)
        {
            string stateName = string.Format("{0}_{1}", methodName.ToLower(), language);

            await _cacheProvider.SetAsync<string>(stateName, "clear", CacheTime.OneHour);
        }

        public async Task<bool> CheckStateAvailableAsync(string stateName)
        {
            var metodState = await _cacheProvider.GetAsync<string>(stateName);
            if (metodState == Constant.InProgress)
                return false;
            return true;
        }

        public async Task SetStateAsync(string stateName, string stateValue, CacheTime cacheTime)
        {
            await _cacheProvider.SetAsync<string>(stateName, stateValue, cacheTime);
        }
    }
}
