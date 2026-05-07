namespace ExpenseTracker.Entities.DTOs.Request
{
    public class CreateIncomeDto
    {
        public string Source { get; set; } = string.Empty;
        public decimal Amount { get; set; }
        public int UserId { get; set; }
    }
}
