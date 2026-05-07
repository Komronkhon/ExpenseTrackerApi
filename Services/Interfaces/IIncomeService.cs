using ExpenseTracker.Entities.DTOs.Request;
using ExpenseTracker.Entities.DTOs.Response;

namespace ExpenseTracker.Services.Interfaces
{
    public interface IIncomeService
    : IBaseService<IncomeResponseDto, CreateIncomeDto>
    {
    }
}
