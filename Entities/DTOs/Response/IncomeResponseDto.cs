namespace ExpenseTracker.Entities.DTOs.Response
{
    public class IncomeResponseDto
    {
        public int Id { get; set; }
        public string Source { get; set; } = string.Empty;
        public decimal Amount { get; set; }
        public int UserId { get; set; }
        public DateTime CreatedAt { get; set; }
    }
}
