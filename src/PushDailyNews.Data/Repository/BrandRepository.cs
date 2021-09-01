
using PushDailyNews.Data.Repository.Abstraction;
using PushDailyNews.Infrastructure.Model;

namespace PushDailyNews.Data.Repository
{
    public class BrandRepository : GenericRepository<BrandModel>, IBrandRepository
    {
        public BrandRepository(string tableName = "Brand") : base(tableName)
        {
        }
    }
}
