using ExpenseTracker.Entities.DTOs.Request;
using ExpenseTracker.Services.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace ExpenseTracker.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class IncomesController : ControllerBase
    {
        private readonly IIncomeService _incomeService;

        public IncomesController(IIncomeService incomeService)
        {
            _incomeService = incomeService;
        }

        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            return Ok(await _incomeService.GetAll());
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetById(int id)
        {
            var income = await _incomeService.GetById(id);

            if (income == null)
                return NotFound();

            return Ok(income);
        }

        [HttpPost]
        public async Task<IActionResult> Create(CreateIncomeDto dto)
        {
            return Ok(await _incomeService.Create(dto));
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> Update(int id, CreateIncomeDto dto)
        {
            var updated = await _incomeService.Update(id, dto);

            if (updated == null)
                return NotFound();

            return Ok(updated);
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(int id)
        {
            var deleted = await _incomeService.Delete(id);

            if (!deleted)
                return NotFound();

            return Ok();
        }
    }
}
