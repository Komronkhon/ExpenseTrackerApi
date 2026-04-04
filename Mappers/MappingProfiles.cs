using AutoMapper;
using ExpenseTracker.Entities.DTOs.Request;
using ExpenseTracker.Entities.DTOs.Response;
using ExpenseTracker.Entities.Models;

namespace ExpenseTracker.Mappers
{
    public class MappingProfiles : Profile
    {
        public MappingProfiles()
        {
            CreateMap<CreateCategoryDto, Category>();
            CreateMap<Category, CategoryResponseDto>();

            CreateMap<CreateExpenseDto, Expense>();
            CreateMap<Expense, ExpenseResponseDto>();
        }
    }
}