namespace ExpenseTracker.Entities.DTOs.Response
{
    public class CategoryResponseDto
    {
        public string Id { get; set; }
        public string Name { get; set; } = string.Empty;
        public DateTime CreatedAt { get; set; }
    }
}
