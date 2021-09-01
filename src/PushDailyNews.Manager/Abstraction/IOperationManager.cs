using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace PushDailyNews.Manager.Abstraction
{
    public interface IOperationManager<T>
    {
        Task<IEnumerable<T>> GetAllAsync();
        Task DeleteRowAsync(Guid id);
        Task<T> GetAsync(Guid id);
        Task<int> SaveRangeAsync(IEnumerable<T> list);
        Task UpdateAsync(T model);
        Task InsertAsync(T model);
    }
}
