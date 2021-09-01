using System;

namespace PushDailyNews.Infrastructure.Model
{
    public class UserModel : BaseModel
    {
        public string UserName { get; set; }
        public string UserSurname { get; set; }
        public string UserEmail { get; set; }
        public string UserMobile { get; set; }
        public string UserPassword { get; set; }
        public DateTime CreatedDate { get; set; }
    }
}
