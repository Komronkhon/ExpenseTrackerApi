using System.ComponentModel.DataAnnotations;

namespace ExpenseTracker.Entities.DTOs.Request
{
    public class CreateCategoryDto
    {
        public string Name { get; set; } = string.Empty;
    }
}
