using PushDailyNews.Data.Helper;
using PushDailyNews.Data.Repository;
using PushDailyNews.Infrastructure.Model;
using PushDailyNews.Infrastructure.Request;
using PushDailyNews.Infrastructure.Settings;
using PushDailyNews.Manager.Abstraction;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PushDailyNews.Manager
{
    public class BrandManager : IBrandManager
    {
        public BrandRepository _firmRepository { get; set; }
        private readonly IApiHelper<MediaServiceSettings> _mediaServiceApiHelper;
        private readonly IApiHelper<SearchManagerServiceSettings> _searcManagerServiceApiHelper;
        private readonly IStateManager _stateManager;
        #region Single Section
        private static readonly Lazy<BrandManager> instance = new Lazy<BrandManager>(() => new BrandManager());
        public BrandManager(IApiHelper<MediaServiceSettings> mediaServiceApi, IApiHelper<SearchManagerServiceSettings> searcManagerServiceApi)
        {
            _firmRepository = new BrandRepository();
            _mediaServiceApiHelper = mediaServiceApi;
            _searcManagerServiceApiHelper = searcManagerServiceApi;
            _stateManager = stateManager;
        }
        public static BrandManager Instance => instance.Value;
        #endregion
        public Task DeleteRowAsync(Guid id)
        {
            var firm = _firmRepository.GetAsync(id);
            firm.Result.IsDeleted = true;
            firm.Result.UpdatedUser = id; //TODO : CurrentUser getirilecek
            firm.Result.UpdatedDate = DateTime.Now;
            return _firmRepository.UpdateAsync(firm.Result);
        }

        public Task<IEnumerable<BrandModel>> GetAllAsync()
        {
            var allFirm = _firmRepository.GetAllAsync();
            return Task.FromResult(allFirm.Result.Where(w => !w.IsDeleted));
        }

        public Task<BrandModel> GetAsync(Guid id)
        {
            var firm = _firmRepository.GetAsync(id);
            return Task.FromResult(firm.Result);
        }

        public Task InsertAsync(BrandModel model)
        {
            return _firmRepository.InsertAsync(model);
        }

        public Task<int> SaveRangeAsync(IEnumerable<BrandModel> list)
        {
            return Task.FromResult(_firmRepository.SaveRangeAsync(list).Result);
        }

        public Task UpdateAsync(BrandModel model)
        {
            return _firmRepository.UpdateAsync(model);
        }

        public Task<bool> AddElastic(NewElasticRequestModel request, string languageCode)
        {
            request = new NewElasticRequestModel()
            {
                BrandName = "deneme"
            };// silebilirsin 

            var headers = new Dictionary<string, string>();

            headers.Add("LanguageCode", languageCode);

            return _searcManagerServiceApiHelper.PostAsync<bool>(services => services.AddAsync, request, headers);
        }

        public Task<bool> CreateIndex(string indexName, string languageCode)
        {
            indexName= indexName + languageCode;


            return _searcManagerServiceApiHelper.PostAsync<bool>(services => services.CreateIndex, request, headers);
            return _searcManagerServiceApiHelper.GetAsync<object>(services => services.GetItem, request, headers);
        }
    }
}
