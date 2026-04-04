using ExpenseTracker.Entities.Models;
using ExpenseTracker.Repositories.Intetfaces;

namespace ExpenseTracker.Repositories
{
    public class ExpenseRepository : BaseRepository<Expense>, IExpenseRepository
    {
        public Expense? Update(int id, Expense entity)
        {
            var expense = GetById(id);

            if (expense == null)
                return null;

            expense.Title = entity.Title;
            expense.Amount = entity.Amount;
            expense.CategoryId = entity.CategoryId;
            expense.PaymentMethod = entity.PaymentMethod;
            expense.UserId= entity.UserId;
            expense.UpdatedAt = DateTime.Now;

            return expense;
        }
    }
}