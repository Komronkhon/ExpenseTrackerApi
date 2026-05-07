namespace ExpenseTracker.Entities.DTOs.Response
{
    public class PaymentMethodResponseDto
    {
        public int Id { get; set; }
        public string Name { get; set; } = string.Empty;
        public DateTime CreatedAt { get; set; }
    }
}
