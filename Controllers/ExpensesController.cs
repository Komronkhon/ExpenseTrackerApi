using ExpenseTracker.Entities.DTOs.Request;
using ExpenseTracker.Services;
using ExpenseTracker.Services.Intefaces;
using Microsoft.AspNetCore.Mvc;

namespace ExpenseTracker.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ExpensesController : ControllerBase
    {
        private readonly IExpenseService _expenseService;

        public ExpensesController(IExpenseService expenseService)
        {
            _expenseService = expenseService;
        }

        [HttpGet]
        public IActionResult GetAll()
        {
            var expenses = _expenseService.GetAll();

            return Ok(expenses);
        }

        [HttpGet("{id}")]
        public IActionResult GetById(int id)
        {
            var expense = _expenseService.GetById(id);

            if (expense == null)
                return NotFound();

            return Ok(expense);
        }

        [HttpGet("total-amount/{categoryId}")]
        public IActionResult GetTotalByCategory(int categoryId)
        {
            var total = _expenseService.GetTotalByCategory(categoryId);

            return Ok(total);
        }

        [HttpPost]
        public IActionResult Create( CreateExpenseDto entity)
        {
            var expense = _expenseService.Create(entity);

            return Ok(expense);
        }

        [HttpPut("{id}")]
        public IActionResult Update(int id, CreateExpenseDto entity)
        {
            var expense = _expenseService.Update(id, entity);

            if (expense == null)
                return NotFound();

            return Ok(expense);
        }

        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            var expense = _expenseService.Delete(id);

            if (!expense)
                return NotFound();

            return NoContent();
        }
    }
}
