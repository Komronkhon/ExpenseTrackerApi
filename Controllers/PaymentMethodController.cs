using ExpenseTracker.Entities.DTOs.Request;
using ExpenseTracker.Services.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace ExpenseTracker.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class PaymentMethodController : ControllerBase
    {
        private readonly IPaymentMethodService _paymentMethodService;
        private readonly ILogger<PaymentMethodController> _logger;

        public PaymentMethodController(IPaymentMethodService paymentMethodService, ILogger<PaymentMethodController> logger)
        {
            _paymentMethodService = paymentMethodService;
            _logger = logger;
        }

        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            _logger.LogInformation("Get all payment methods"); 
            var paymentMethods = await _paymentMethodService.GetAll(); 

            return Ok(paymentMethods);
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetById(int id)
        {
            _logger.LogInformation($"Get payment method by id: {id}");
            var paymentMethod = await _paymentMethodService.GetById(id);

            if (paymentMethod == null)
            {
                _logger.LogError($"This payment method not found");
                return NotFound();
            }

            return Ok(paymentMethod);
        }

        [HttpPost]
        public async Task<IActionResult> Create(CreatePaymentMethodDto entity)
        {
            _logger.LogInformation("Create new payment method");
            return Ok(await _paymentMethodService.Create(entity));
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> Update(int id, CreatePaymentMethodDto entity)
        {
            _logger.LogInformation($"Update payment method by id: {id}");
            var paymentMethod = await _paymentMethodService.Update(id, entity);

            if (paymentMethod == null)
            {
                _logger.LogError($"This payment method not found");
                return NotFound();
            }

            return Ok(paymentMethod);
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(int id)
        {
            _logger.LogInformation($"Delete payment method by id: {id}");
            var paymentMethod = await _paymentMethodService.Delete(id);

            if (!paymentMethod)
            {
                _logger.LogError($"This payment method not found");
                return NotFound();
            }

            return NoContent();
        }
    }
}