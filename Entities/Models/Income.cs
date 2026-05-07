namespace ExpenseTracker.Entities.Models
{
    public class Income : BaseEntity
    {
        public string Source { get; set; } = string.Empty;
        public decimal Amount { get; set; }
        public int UserId { get; set; }

        public User User { get; set; } = null!;
    }
}
