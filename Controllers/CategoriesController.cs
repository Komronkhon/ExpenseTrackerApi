using ExpenseTracker.Entities.DTOs.Request;
using ExpenseTracker.Services.Intefaces;
using Microsoft.AspNetCore.Mvc;

namespace ExpenseTracker.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class CategoriesController : ControllerBase
    {
        private readonly ICategoryService _service;
        private readonly ILogger<CategoriesController> _logger;

        public CategoriesController(ICategoryService service, ILogger<CategoriesController> logger)
        {
            _service = service;
            _logger = logger;
        }

        [HttpGet]
        public IActionResult GetAll()
        {
            _logger.LogInformation("Get all categories"); 
            var categories = _service.GetAllCategories(); 

            return Ok(categories);
        }

        [HttpGet("{id}")]
        public IActionResult GetById(int id)
        {
            _logger.LogInformation($"Get category by id: {id}");
            var category = _service.GetCategoryById(id);

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
            return Ok(_service.CreateCategory(entity));
        }

        [HttpPut("{id}")]
        public IActionResult Update(int id, CreateCategoryDto entity)
        {
            _logger.LogInformation($"Update category by id: {id}");
            var category = _service.UpdateCategory(id, entity);

            if (category == null)
            {
                _logger.LogError($"This category not found");
                return NotFound();
            }

            return Ok(category);
        }

        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            _logger.LogInformation($"Delete category by id: {id}");
            var category = _service.DeleteCategory(id);

            if (!category)
            {
                _logger.LogError($"This category not found");
                return NotFound();
            }

            return NoContent();
        }
    }
}