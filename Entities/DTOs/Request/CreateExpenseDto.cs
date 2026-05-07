using ExpenseTracker.Entities.Models;

namespace ExpenseTracker.Entities.DTOs.Request
{
    public class CreateExpenseDto
    {
        public string Title { get; set; } = string.Empty;
        public decimal Amount { get; set; }
        public int PaymentMethodId { get; set; }
        public int CategoryId { get; set; }
        public int UserId { get; set; }
    }
}
