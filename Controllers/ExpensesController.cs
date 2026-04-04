using ExpenseTracker.Entities.DTOs.Request;
using ExpenseTracker.Services.Intefaces;
using Microsoft.AspNetCore.Mvc;

namespace ExpenseTracker.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ExpensesController : ControllerBase
    {
        private readonly IExpenseService _service;

        public ExpensesController(IExpenseService service)
        {
            _service = service;
        }

        [HttpGet]
        public IActionResult GetAll()
        {
            var expenses = _service.GetAllExpenses();

            return Ok(expenses);
        }

        [HttpGet("{id}")]
        public IActionResult GetById(int id)
        {
            var expense = _service.GetExpenseById(id);

            if (expense == null)
                return NotFound();

            return Ok(expense);
        }

        [HttpPost]
        public IActionResult Create( CreateExpenseDto entity)
        {
            var expense = _service.CreateExpense(entity);

            return Ok(expense);
        }

        [HttpPut("{id}")]
        public IActionResult Update(int id, CreateExpenseDto entity)
        {
            var expense = _service.UpdateExpense(id, entity);

            if (expense == null)
                return NotFound();

            return Ok(expense);
        }

        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            var expense = _service.DeleteExpense(id);

            if (!expense)
                return NotFound();

            return NoContent();
        }
    }
}
