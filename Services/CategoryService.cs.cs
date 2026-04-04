using AutoMapper;
using ExpenseTracker.Entities.DTOs.Request;
using ExpenseTracker.Entities.DTOs.Response;
using ExpenseTracker.Entities.Models;
using ExpenseTracker.Repositories.Intetfaces;
using ExpenseTracker.Services.Intefaces;

public class CategoryService : ICategoryService
{
    private readonly ICategoryRepository _categeoryRepository;
    private readonly IMapper _mapper;

    public CategoryService(ICategoryRepository categeoryRepository, IMapper mapper)
    {
        _categeoryRepository = categeoryRepository;
        _mapper = mapper;
    }

    public List<CategoryResponseDto> GetAllCategories()
    {
        var categories = _categeoryRepository.GetAll();

        return _mapper.Map<List<CategoryResponseDto>>(categories);
    }

    public CategoryResponseDto? GetCategoryById(int id)
    {
        var category = _categeoryRepository.GetById(id);

        if (category == null)
            return null;

        return _mapper.Map<CategoryResponseDto>(category);
    }

    public CategoryResponseDto CreateCategory(CreateCategoryDto entity)
    {
        var category = _mapper.Map<Category>(entity);

        var createdCategory = _categeoryRepository.Create(category);

        return _mapper.Map<CategoryResponseDto>(createdCategory);
    }

    public CategoryResponseDto? UpdateCategory(int id, CreateCategoryDto entity)
    {
        var category = _mapper.Map<Category>(entity);

        var updatedCategory = _categeoryRepository.Update(id, category);

        if (updatedCategory == null)
            return null;

        return _mapper.Map<CategoryResponseDto>(updatedCategory);
    }

    public bool DeleteCategory(int id)
    {
        var category = _categeoryRepository.GetById(id);

        if (category == null)
            return false;

        _categeoryRepository.Delete(category);

        return true;
    }
}