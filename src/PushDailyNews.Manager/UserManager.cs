using PushDailyNews.Data.Repository;
using PushDailyNews.Infrastructure.Model;
using PushDailyNews.Manager.Abstraction;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PushDailyNews.Manager
{
    public class UserManager : IUserManager
    {
        private UserRepository _userRepository { get; set; }
        #region Single Section
        private static readonly Lazy<UserManager> instance = new Lazy<UserManager>(() => new UserManager());
        public UserManager()
        {
            _userRepository = new UserRepository();
        }
        public static UserManager Instance => instance.Value;
        #endregion
        public Task DeleteRowAsync(Guid id)
        {
            var user = _userRepository.GetAsync(id);
            user.Result.IsDeleted = true;
            user.Result.UpdatedUser = id; //TODO : CurrentUser getirilecek
            user.Result.UpdatedDate = DateTime.Now;
            return _userRepository.UpdateAsync(user.Result);
        }

        public Task<IEnumerable<UserModel>> GetAllAsync()
        {
            var allUser = _userRepository.GetAllAsync();
            return Task.FromResult(allUser.Result.Where(w => !w.IsDeleted));
        }

        public Task<UserModel> GetAsync(Guid id)
        {
            var user = _userRepository.GetAsync(id);
            return Task.FromResult(user.Result);
        }

        public Task InsertAsync(UserModel model)
        {
            return _userRepository.InsertAsync(model);
        }

        public Task<int> SaveRangeAsync(IEnumerable<UserModel> list)
        {
            return Task.FromResult(_userRepository.SaveRangeAsync(list).Result);
        }

        public Task UpdateAsync(UserModel model)
        {
            return _userRepository.UpdateAsync(model);
        }
    }
}
