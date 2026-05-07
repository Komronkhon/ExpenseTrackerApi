namespace ExpenseTracker.Entities.DTOs.Response
{
    public class ReportResponseDto
    {
        public long Id { get; set; }
        public string Title { get; set; } = string.Empty;
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public decimal TotalAmount { get; set; }
        public long UserId { get; set; }
    }
}
