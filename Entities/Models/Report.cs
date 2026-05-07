namespace ExpenseTracker.Entities.Models
{
    public class Report : BaseEntity
    {
        public string Title { get; set; } = string.Empty;
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public decimal TotalAmount { get; set; }
        public int UserId { get; set; }

        public User User { get; set; } = null!;
    }
}
