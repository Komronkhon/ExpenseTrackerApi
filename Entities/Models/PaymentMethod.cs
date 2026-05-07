namespace ExpenseTracker.Entities.Models
{
    public class PaymentMethod : BaseEntity
    {
        public string Name { get; set; } = string.Empty;

        public ICollection<Expense> Expenses { get; set; } = new List<Expense>();
    }
}
