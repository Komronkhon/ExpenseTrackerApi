using ExpenseTracker.Entities.Models;

namespace ExpenseTracker.Repositories.Intetfaces
{
    public interface ICategoryRepository : IBaseRepository<Category>
    {
        Category? Update(int id, Category entity);
    }
}
