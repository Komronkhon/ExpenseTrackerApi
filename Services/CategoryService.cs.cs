using AutoMapper;
using ExpenseTracker.Entities.DTOs.Request;
using ExpenseTracker.Entities.DTOs.Response;
using ExpenseTracker.Entities.Models;
using ExpenseTracker.Repositories.Intetfaces;
using ExpenseTracker.Services;
using ExpenseTracker.Services.Intefaces;

public class CategoryService
    : BaseService<Category, CategoryResponseDto, CreateCategoryDto>,
      ICategoryService
{
    public CategoryService(
        ICategoryRepository repository,
        IMapper mapper
    ) : base(repository, mapper)
    {
    }
}