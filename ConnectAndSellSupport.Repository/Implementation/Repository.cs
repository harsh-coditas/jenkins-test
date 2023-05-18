using ConnectAndSellSupport.Domain.Models;
using ConnectAndSellSupport.Repository.Contracts;
using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Storage;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace ConnectAndSellSupport.Repository.Implementation
{
    public abstract class Repository<T> : IRepository<T> where T : class
    {
        protected readonly DbContext _context;
        private readonly DbSet<T> _dbSet;

        public Repository(DbContext context)
        {
            _context = context;
            _dbSet = _context.Set<T>();
        }

        public virtual async Task AddAsync(T entity)
        {
            await _context.Set<T>().AddAsync(entity);
            await _context.SaveChangesAsync();
        }

        public virtual async Task AddMultiAsync(IEnumerable<T> entities)
        {
            await _context.Set<T>().AddRangeAsync(entities);
            await _context.SaveChangesAsync();
        }

        public virtual async Task<T> GetSingleAsync(Expression<Func<T, bool>> predicate)
        {
            return await _context.Set<T>().Where(predicate).FirstOrDefaultAsync();
        }

        public virtual async Task<IEnumerable<T>> GetMultiAsync(Expression<Func<T, bool>> predicate)
        {
            return await _context.Set<T>().Where(predicate).ToListAsync();
        }

        public virtual async Task UpdateAsync(T entity)
        {
            _context.Entry(entity).CurrentValues.SetValues(_dbSet);
            await _context.SaveChangesAsync();
        }

        public virtual async Task UpdateMultiAsync(IEnumerable<T> entities)
        {
            _context.Set<T>().UpdateRange(entities);
            await _context.SaveChangesAsync();
        }

        public virtual async Task RemoveAsync(T entity)
        {
            _context.Set<T>().Attach(entity);
            _context.Set<T>().Remove(entity);
            await _context.SaveChangesAsync();
        }

        public virtual async Task RemoveMultiAsync(IEnumerable<T> entities)
        {
            _context.Set<T>().AttachRange(entities);
            _context.Set<T>().RemoveRange(entities);
            await _context.SaveChangesAsync();
        }
    }
}
