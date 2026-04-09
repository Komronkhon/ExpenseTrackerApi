using ExpenseTracker.Entities.DTOs.Request;
using ExpenseTracker.Entities.DTOs.Response;
using ExpenseTracker.Services.Intefaces;

public interface ICategoryService
    : IBaseService<CategoryResponseDto, CreateCategoryDto>
{
}