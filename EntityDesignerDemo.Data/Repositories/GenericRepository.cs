using EntityDesignerDemo.Data.IRepositories;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.ChangeTracking;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace EntityDesignerDemo.Data.Repositories
{
    public class GenericRepository<T> : IGenericRepository<T> where T : class
    {
        private DbContext _dbContext;
        private DbSet<T> _dbSet;

        public GenericRepository(DbContext dbContext)
        {
            _dbContext = dbContext;
            _dbSet = dbContext.Set<T>();
        }

        public async Task<T> CreateAsync(T entity)
        {
            EntityEntry entry = await _dbSet.AddAsync(entity);
            await _dbContext.SaveChangesAsync();

            return (T)entry.Entity;
        }

        public async Task<bool> DeleteAsync(Expression<Func<T, bool>> predicate)
        {
            T res = await GetAsync(predicate);

            if (res is null)
                return false;

            _dbSet.Remove(res);
            await _dbContext.SaveChangesAsync();

            return true;
        }

        public Task<IQueryable<T>> GetAllAsync(Expression<Func<T, bool>> predicate = null)
        {
            return (Task<IQueryable<T>>)(predicate == null ? _dbSet : _dbSet.Where(predicate));
        }

        public Task<T> GetAsync(Expression<Func<T, bool>> predicate)
        {
            return _dbSet.FirstOrDefaultAsync(predicate);
        }

        public async Task<T> UpdateAsync(T entity)
        {
            EntityEntry entry = _dbSet.Update(entity);

            await _dbContext.SaveChangesAsync();

            return (T) entry.Entity;
        }
    }
}
