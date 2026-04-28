using ExpenseTracker.Entities.Models;

namespace ExpenseTracker.Repositories.Intetfaces
{
    public interface IBaseRepository<T> where T : BaseEntity
    {
        Task<List<T>> GetAll();
        Task<T?> GetById(long id);
        Task<T> Create(T entity);
        Task<T?> Update(T entity);
        Task Delete(T entity);
    }
}
