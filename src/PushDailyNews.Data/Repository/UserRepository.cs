using PushDailyNews.Data.Repository.Abstraction;
using PushDailyNews.Infrastructure.Model;

namespace PushDailyNews.Data.Repository
{
    public class UserRepository : GenericRepository<UserModel>, IUserRepository
    {
        public UserRepository(string tableName = "User") : base(tableName)
        {
            //Brand
            //BrandCategory
            //BrandBrandCategoryMap
        }
    }
}
