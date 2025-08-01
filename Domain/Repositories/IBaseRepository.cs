
namespace Domain.Repositories;

public interface IBaseRepository<T> where T : class
{
    Task InsertAsync(T entity);
    Task<IEnumerable<T>> FindallAsync();
    Task<T> FindByIdAsync(int id);
    Task DeleteAsync (T entity);
    Task UpdateAsync(T entity);
}
