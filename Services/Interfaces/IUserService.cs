using ExpenseTracker.Entities.DTOs.Request;
using ExpenseTracker.Entities.DTOs.Response;

namespace ExpenseTracker.Services.Interfaces
{
    public interface IUserService
        : IBaseService<UserResponseDto, CreateUserDto>
    {
        Task<decimal> GetBalance(int userId);
    }
}
