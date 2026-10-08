using System.Linq.Expressions;

namespace samarth_backend.DAL.Interfaces
{
    public interface IRepository<T>
    {
        Task<List<T>> GetAllAsync();
        Task<T> GetDetailsAsync(Expression<Func<T, bool>> condition, bool useNoTracking = false);
        Task<T> CreateAsync(T entity);
        Task<T> UpdateAsync(T entity);
        Task<long> GetMaxAsync(Expression<Func<T, long?>> selector);
    }
}
