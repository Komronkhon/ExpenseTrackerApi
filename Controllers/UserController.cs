using ExpenseTracker.Entities.DTOs.Request;
using ExpenseTracker.Services.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace ExpenseTracker.Controllers
{

    [ApiController]
    [Route("api/[controller]")]
    public class UsersController : ControllerBase
    {
        private readonly IUserService _userService;

        public UsersController(IUserService userService)
        {
            _userService = userService;
        }

        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            var users = await _userService.GetAll();

            return Ok(users);
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetById(int id)
        {
            var user = await _userService.GetById(id);

            if (user == null)
                return NotFound();

            return Ok(user);
        }

        [HttpGet("{id}/balance")]
        public async Task<IActionResult> GetBalance(int id)
        {
            var balance = await _userService.GetBalance(id);

            return Ok(balance);
        }

        [HttpPost]
        public async Task<IActionResult> Create(CreateUserDto dto)
        {
            var user = await _userService.Create(dto);

            return Ok(user);
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> Update(int id, CreateUserDto dto)
        {
            var user = await _userService.Update(id, dto);

            if (user == null)
                return NotFound();

            return Ok(user);
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(int id)
        {
            var deleted = await _userService.Delete(id);

            if (!deleted)
                return NotFound();

            return Ok();
        }
    }
}
