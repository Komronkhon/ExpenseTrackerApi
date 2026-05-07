namespace ExpenseTracker.Entities.DTOs.Request
{
    public class CreateReportDto
    {
        public string Title { get; set; } = string.Empty;
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public int UserId { get; set; }
    }
}
