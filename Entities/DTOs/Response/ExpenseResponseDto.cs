using ExpenseTracker.Entities.Models;

namespace ExpenseTracker.Entities.DTOs.Response
{
    public class ExpenseResponseDto
    {
        public int Id { get; set; }
        public string Title { get; set; } = string.Empty;
        public decimal Amount { get; set; }
        public int CategoryId { get; set; }
        public PaymentMethod PaymentMethod { get; set; }
        public int UserId { get; set; }
        public DateTime CreatedAt { get; set; }
    }
}
