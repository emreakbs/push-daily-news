using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PushDailyNews.Infrastructure.Settings
{
    public class SearchManagerServiceSettings : IApiSetting
    {
        public string Url { get; set; }
        public ApiMethod AddAsync{ get; set; }
        public ApiMethod CreateIndex{ get; set; }
        public void Validate()
        {
        }
    }
}
