using ExpenseTracker.Entities.DTOs.Request;
using ExpenseTracker.Entities.DTOs.Response;

namespace ExpenseTracker.Services.Intefaces
{
    public interface IExpenseService 
        : IBaseService<ExpenseResponseDto, CreateExpenseDto>
    {
        List<ExpenseResponseDto> GetMonthlyExpenses(int userId);
        decimal GetTotalByCategory(int categoryId);
    }
}
