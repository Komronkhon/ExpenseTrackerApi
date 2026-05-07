using ExpenseTracker.Entities.DTOs.Request;
using FluentValidation;

namespace ExpenseTracker.Validators
{
    public class CreateIncomeDtoValidator : AbstractValidator<CreateIncomeDto>
    {
        public CreateIncomeDtoValidator()
        {
            RuleFor(i => i.Source)
                .NotEmpty()
                .MaximumLength(100);

            RuleFor(i => i.Amount)
                .GreaterThan(0);

            RuleFor(i => i.UserId)
                .GreaterThan(0);
        }
    }
}