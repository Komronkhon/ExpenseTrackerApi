using AutoMapper;
using ExpenseTracker.Entities.DTOs.Request;
using ExpenseTracker.Entities.DTOs.Response;
using ExpenseTracker.Entities.Models;
using ExpenseTracker.Repositories.Intetfaces;
using ExpenseTracker.Services.Intefaces;

namespace ExpenseTracker.Services
{
    public class ExpenseService : IExpenseService
    {
        private readonly IExpenseRepository _expenseRepository;
        private readonly IMapper _mapper;

        public ExpenseService(IExpenseRepository expenseRepository, IMapper mapper)
        {
            _expenseRepository = expenseRepository;
            _mapper = mapper;
        }

        public List<ExpenseResponseDto> GetAllExpenses()
        {
            var expenses = _expenseRepository.GetAll();

            return _mapper.Map<List<ExpenseResponseDto>>(expenses);
        }

        public ExpenseResponseDto? GetExpenseById(int id)
        {
            var expense = _expenseRepository.GetById(id);

            if (expense == null)
                return null;

            return _mapper.Map<ExpenseResponseDto>(expense);
        }

        public List<ExpenseResponseDto> GetMonthlyExpenses(int userId)
        {
            var expenses = _expenseRepository.GetAll()
                .Where(x => x.UserId == userId &&
                       x.CreatedAt.Month == DateTime.UtcNow.Month &&
                       x.CreatedAt.Year == DateTime.UtcNow.Year)
                .ToList();

            return _mapper.Map<List<ExpenseResponseDto>>(expenses);
        }

        public decimal GetTotalByCategory(int categoryId)
        {
            return _expenseRepository.GetAll()
                .Where(x => x.CategoryId == categoryId)
                .Sum(x => x.Amount);
        }

        public ExpenseResponseDto CreateExpense(CreateExpenseDto entity)
        {
            var expense = _mapper.Map<Expense>(entity);

            var createdExpense = _expenseRepository.Create(expense);

            return _mapper.Map<ExpenseResponseDto>(createdExpense);
        }

        public ExpenseResponseDto? UpdateExpense(int id, CreateExpenseDto entity)
        {
            var expense = _mapper.Map<Expense>(entity);

            var updatedExpense = _expenseRepository.Update(id, expense);

            if (updatedExpense == null)
                return null;

            return _mapper.Map<ExpenseResponseDto>(updatedExpense);
        }

        public bool DeleteExpense(int id)
        {
            var expense = _expenseRepository.GetById(id);

            if (expense == null)
                return false;

            _expenseRepository.Delete(expense);

            return true;
        }
    }
}