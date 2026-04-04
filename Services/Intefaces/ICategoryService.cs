using ExpenseTracker.Entities.DTOs.Request;
using ExpenseTracker.Entities.DTOs.Response;
using ExpenseTracker.Entities.Models;

namespace ExpenseTracker.Services.Intefaces
{
    public interface ICategoryService
    {
        List<CategoryResponseDto> GetAllCategories();
        CategoryResponseDto? GetCategoryById(int id);
        CategoryResponseDto CreateCategory(CreateCategoryDto entity);
        CategoryResponseDto? UpdateCategory(int id, CreateCategoryDto entity);
        bool DeleteCategory(int id);
    }
}
