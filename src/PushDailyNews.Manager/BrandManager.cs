using PushDailyNews.Data.Repository;
using PushDailyNews.Infrastructure.Model;
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

        #region Single Section
        private static readonly Lazy<BrandManager> instance = new Lazy<BrandManager>(() => new BrandManager());
        public BrandManager()
        {
            _firmRepository = new BrandRepository();
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
    }
}
