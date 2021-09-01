using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PushDailyNews.Infrastructure.Model
{
    public class BrandCategoryModel : BaseModel
    {
        public Guid BrandId { get; set; }
        public string BrandCategoryName { get; set; }
    }
}
