namespace ExpenseTracker.Entities.Models
{
    public class Expense : BaseEntity
    {
        public string Title { get; set; } = string.Empty;
        public decimal Amount { get; set; }
        public int PaymentMethodId { get; set; }
        public int CategoryId { get; set; }
        public int UserId { get; set; }

        public Category Category { get; set; } = null!;
        public User User { get; set; } = null!;
        public PaymentMethod PaymentMethod { get; set; } = null!;
    }
}
