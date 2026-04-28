using ExpenseTracker.Data;
using ExpenseTracker.Entities.Models;
using ExpenseTracker.Repositories.Intetfaces;

namespace ExpenseTracker.Repositories
{
    public class ExpenseRepository : BaseRepository<Expense>, IExpenseRepository
    {
        public ExpenseRepository(AppDbContext context)
            : base(context)
        {
        }
    }
}