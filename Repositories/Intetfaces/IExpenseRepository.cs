
using ExpenseTracker.Entities.Models;

namespace ExpenseTracker.Repositories.Intetfaces
{
    public interface IExpenseRepository : IBaseRepository<Expense>
    {
        Expense? Update(int id, Expense entity);
    }
}
