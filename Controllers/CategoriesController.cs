using ExpenseTracker.Entities.DTOs.Request;
using ExpenseTracker.Services.Intefaces;
using Microsoft.AspNetCore.Mvc;

namespace ExpenseTracker.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class CategoriesController : ControllerBase
    {
        private readonly ICategoryService _categoryService;
        private readonly ILogger<CategoriesController> _logger;

        public CategoriesController(ICategoryService categoryService, ILogger<CategoriesController> logger)
        {
            _categoryService = categoryService;
            _logger = logger;
        }

        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            _logger.LogInformation("Get all categories"); 
            var categories = await _categoryService.GetAll(); 

            return Ok(categories);
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetById(int id)
        {
            _logger.LogInformation($"Get category by id: {id}");
            var category = await _categoryService.GetById(id);

            if (category == null)
            {
                _logger.LogError($"This category not found");
                return NotFound();
            }

            return Ok(category);
        }

        [HttpPost]
        public IActionResult Create(CreateCategoryDto entity)
        {
            _logger.LogInformation("Create new category");
            return Ok(_categoryService.Create(entity));
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> Update(int id, CreateCategoryDto entity)
        {
            _logger.LogInformation($"Update category by id: {id}");
            var category = await _categoryService.Update(id, entity);

            if (category == null)
            {
                _logger.LogError($"This category not found");
                return NotFound();
            }

            return Ok(category);
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(int id)
        {
            _logger.LogInformation($"Delete category by id: {id}");
            var category = await _categoryService.Delete(id);

            if (!category)
            {
                _logger.LogError($"This category not found");
                return NotFound();
            }

            return NoContent();
        }
    }
}