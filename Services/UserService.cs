using AutoMapper;
using ExpenseTracker.Entities.DTOs.Request;
using ExpenseTracker.Entities.DTOs.Response;
using ExpenseTracker.Entities.Models;
using ExpenseTracker.Repositories.Interfaces;
using ExpenseTracker.Services.Interfaces;

namespace ExpenseTracker.Services
{
    public class UserService
    : BaseService<User, UserResponseDto, CreateUserDto>,
      IUserService
    {
        private readonly IExpenseRepository _expenseRepository;
        private readonly IIncomeRepository _incomeRepository;

        public UserService(
            IUserRepository repository,
            IExpenseRepository expenseRepository,
            IIncomeRepository incomeRepository,
            IMapper mapper)
            : base(repository, mapper)
        {
            _expenseRepository = expenseRepository;
            _incomeRepository = incomeRepository;
        }

        public async Task<decimal> GetBalance(int userId)
        {
            var incomes = (await _incomeRepository.GetAll())
                .Where(x => x.UserId == userId)
                .Sum(x => x.Amount);

            var expenses = (await _expenseRepository.GetAll())
                .Where(x => x.UserId == userId)
                .Sum(x => x.Amount);

            return incomes - expenses;
        }
    }
}
