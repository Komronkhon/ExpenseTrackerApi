using ExpenseTracker.Entities.DTOs.Request;
using ExpenseTracker.Entities.DTOs.Response;

namespace ExpenseTracker.Services.Intefaces
{
    public interface IExpenseService
    {
        List<ExpenseResponseDto> GetAllExpenses();
        ExpenseResponseDto? GetExpenseById(int id);
        List<ExpenseResponseDto> GetMonthlyExpenses(int userId);
        decimal GetTotalByCategory(int categoryId);
        ExpenseResponseDto CreateExpense(CreateExpenseDto entity);
        ExpenseResponseDto? UpdateExpense(int id, CreateExpenseDto entity);
        bool DeleteExpense(int id);
    }
}
