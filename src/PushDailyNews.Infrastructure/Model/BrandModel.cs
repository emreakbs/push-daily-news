using System;

namespace PushDailyNews.Infrastructure.Model
{
    public class BrandModel : BaseModel
    {
        public Guid CreatedUser { get; set; }
        public string BrandName { get; set; }
        public DateTime CreatedDate { get; set; }
    }
}
