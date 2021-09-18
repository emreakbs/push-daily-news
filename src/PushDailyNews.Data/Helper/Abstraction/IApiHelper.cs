using PushDailyNews.Infrastructure.Request;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PushDailyNews.Data.Helper.Abstraction
{
    public interface IApiHelper<T>
    {
        Task<T1> PostAsync<T1>(Func<object, object> p, NewElasticRequestModel request, Dictionary<string, string> headers);
        Task<bool> GetAsync<T1>(Func<T1, T1> p, T1 request, T1 headers);
    }
}
