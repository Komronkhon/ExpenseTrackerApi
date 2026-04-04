using ExpenseTracker.Enums;

namespace ExpenseTracker.Entities.Models
{
    public class Expense : BaseEntity
    {
        public string Title { get; set; } = string.Empty;
        public decimal Amount { get; set; }
        public PaymentMethod PaymentMethod { get; set; }
        public int CategoryId { get; set; }
        public int UserId { get; set; }
    }
}
