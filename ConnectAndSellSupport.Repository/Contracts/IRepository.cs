using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace ConnectAndSellSupport.Repository.Contracts
{
    public interface IRepository<T> where T : class
    {
        Task AddAsync(T entity);
        Task AddMultiAsync(IEnumerable<T> entities);
        Task<T> GetSingleAsync(Expression<Func<T, bool>> predicate);
        Task<IEnumerable<T>> GetMultiAsync(Expression<Func<T, bool>> predicate);
        Task UpdateAsync(T entity);
        Task UpdateMultiAsync(IEnumerable<T> entities);
        Task RemoveAsync(T entity);
        Task RemoveMultiAsync(IEnumerable<T> entities);
    }
}
