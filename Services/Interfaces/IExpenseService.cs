using ExpenseTracker.Entities.DTOs.Request;
using ExpenseTracker.Entities.DTOs.Response;

namespace ExpenseTracker.Services.Interfaces
{
    public interface IExpenseService 
        : IBaseService<ExpenseResponseDto, CreateExpenseDto>
    {
        Task<List<ExpenseResponseDto>> GetMonthlyExpenses(int userId);

        Task<decimal> GetTotalByCategory(int categoryId);
    }
}
