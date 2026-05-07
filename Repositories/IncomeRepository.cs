using ExpenseTracker.Data;
using ExpenseTracker.Entities.Models;
using ExpenseTracker.Repositories.Interfaces;

namespace ExpenseTracker.Repositories
{
    public class IncomeRepository
    : BaseRepository<Income>,
      IIncomeRepository
    {
        public IncomeRepository(AppDbContext context)
            : base(context)
        {
        }
    }
}
