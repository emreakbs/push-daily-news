using System;

namespace PushDailyNews.Infrastructure.Model
{
    public class BaseModel
    {
        public Guid Id { get; set; }
        public Guid? UpdatedUser { get; set; }
        public DateTime? UpdatedDate { get; set; }
        public bool IsActive { get; set; }
        public bool IsDeleted { get; set; }
    }
}
