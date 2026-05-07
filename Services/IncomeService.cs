using AutoMapper;
using ExpenseTracker.Entities.DTOs.Request;
using ExpenseTracker.Entities.DTOs.Response;
using ExpenseTracker.Entities.Models;
using ExpenseTracker.Repositories.Interfaces;
using ExpenseTracker.Services.Interfaces;

namespace ExpenseTracker.Services
{
    public class IncomeService
    : BaseService<Income, IncomeResponseDto, CreateIncomeDto>,
      IIncomeService
    {
        public IncomeService(
            IIncomeRepository repository,
            IMapper mapper)
            : base(repository, mapper)
        {
        }
    }
}
