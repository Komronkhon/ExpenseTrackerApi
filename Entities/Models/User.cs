namespace ExpenseTracker.Entities.Models
{
    public class User : BaseEntity
    {
        public string Name { get; set; } = string.Empty;

        public string Email { get; set; } = string.Empty;

        public ICollection<Expense> Expenses { get; set; } = new List<Expense>();

        public ICollection<Income> Incomes { get; set; } = new List<Income>();

        public ICollection<Report> Reports { get; set; } = new List<Report>();
    }
}
