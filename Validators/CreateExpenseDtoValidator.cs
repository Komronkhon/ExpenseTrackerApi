using ExpenseTracker.Entities.DTOs.Request;
using FluentValidation;

namespace ExpenseTracker.Validators
{
    public class CreateExpenseDtoValidator : AbstractValidator<CreateExpenseDto>
    {
        public CreateExpenseDtoValidator()
        {
            RuleFor(e => e.Title)
                .NotEmpty()
                .Length(100);

            RuleFor(e => e.Amount)
                .NotNull()
                .GreaterThan(0);

            RuleFor(e => e.PaymentMethod)
                .IsInEnum();

            RuleFor(e => e.CategoryId)
                .NotNull()
                .GreaterThan(0); 

            RuleFor(e => e.UserId)
                .NotNull()
                .GreaterThan(0);    
        }
    }
}
