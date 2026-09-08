using System.Linq.Expressions;
using Microsoft.EntityFrameworkCore;
using samarth_backend.DAL.Interfaces;

namespace samarth_backend.DAL
{
    public class Repository<T> : IRepository<T> where T : class
    {
        private readonly jaiBanglaDBContext _dbContext;
        private DbSet<T> _dbSet;

        public Repository(jaiBanglaDBContext dBContext)
        {
            _dbContext = dBContext;
            _dbSet = _dbContext.Set<T>();
        }

        public async Task<List<T>> GetAllAsync()
        {
            return await _dbSet.ToListAsync();
        }
        public async Task<T> GetDetailsAsync(Expression<Func<T, bool>> condition, bool useNoTracking = false)
        {
            if (useNoTracking)
            {
                return await _dbSet.AsNoTracking().FirstOrDefaultAsync(condition);
            }
            else
            {
                return await _dbSet.FirstOrDefaultAsync(condition);
            }
        }
        public async Task<T> CreateAsync(T entity)
        {
            await _dbSet.AddAsync(entity);
            await _dbContext.SaveChangesAsync();
            return entity;
        }
        public async Task<T> UpdateAsync(T entity)
        {
            _dbSet.Update(entity);
            await _dbContext.SaveChangesAsync();
            return entity;
        }
    }
}
