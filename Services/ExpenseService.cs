using AutoMapper;
using ExpenseTracker.Entities.DTOs.Request;
using ExpenseTracker.Entities.DTOs.Response;
using ExpenseTracker.Entities.Models;
using ExpenseTracker.Repositories.Intetfaces;
using ExpenseTracker.Services.Intefaces;

namespace ExpenseTracker.Services
{
    public class ExpenseService : BaseService<Expense, ExpenseResponseDto, CreateExpenseDto>, IExpenseService
    {
        private readonly IExpenseRepository _expenseRepository;

        public ExpenseService(IExpenseRepository expenseRepository, IMapper mapper) 
            : base(expenseRepository, mapper)
        {
            _expenseRepository = expenseRepository;
        }

        public async Task<List<ExpenseResponseDto>> GetMonthlyExpenses(int userId)
        {
            var expenses = (await _expenseRepository.GetAll())
                .Where(x => x.UserId == userId &&
                            x.CreatedAt.Month == DateTime.UtcNow.Month &&
                            x.CreatedAt.Year == DateTime.UtcNow.Year)
                .ToList();

            return _mapper.Map<List<ExpenseResponseDto>>(expenses);
        }

        public async Task<decimal> GetTotalByCategory(int categoryId)
        {
            var expenses = await _expenseRepository.GetAll();

            return expenses
                .Where(x => x.CategoryId == categoryId)
                .Sum(x => x.Amount);
        }
    }
}