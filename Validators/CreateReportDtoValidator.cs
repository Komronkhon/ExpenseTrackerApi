using ExpenseTracker.Entities.DTOs.Request;
using FluentValidation;

namespace ExpenseTracker.Validators
{
    public class CreateReportDtoValidator : AbstractValidator<CreateReportDto>
    {
        public CreateReportDtoValidator()
        {
            RuleFor(r => r.Title)
                .NotEmpty()
                .MaximumLength(150);

            RuleFor(r => r.UserId)
                .GreaterThan(0);

            RuleFor(r => r.StartDate)
                .LessThan(r => r.EndDate);

            RuleFor(r => r.EndDate)
                .GreaterThan(r => r.StartDate);
        }
    }
}