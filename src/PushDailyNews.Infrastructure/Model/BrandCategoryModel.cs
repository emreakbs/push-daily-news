using System;

namespace PushDailyNews.Infrastructure.Model
{
    public class BrandCategoryModel : BaseModel
    {
        public Guid BrandId { get; set; }
        public string BrandCategoryName { get; set; }
    }
}
