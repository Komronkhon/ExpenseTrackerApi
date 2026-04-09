using ExpenseTracker.Entities.Models;

namespace ExpenseTracker.Repositories.Intetfaces
{
    public interface IBaseRepository<T> where T : BaseEntity
    {
        List<T> GetAll();
        T? GetById(long id);
        T Create(T entity);
        T Update(int id, T target);
        void Delete(T entity);
    }
}
