using System.ComponentModel.DataAnnotations;

namespace ExpenseTracker.Entities.DTOs.Request
{
    public class CreatePaymentMethodDto
    {
        public string Name { get; set; } = string.Empty;
    }
}
