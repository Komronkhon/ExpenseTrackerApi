using ExpenseTracker.Entities.DTOs.Request;
using FluentValidation;

namespace ExpenseTracker.Validators
{
    public class CreatePaymentMethodDtoValidator
        : AbstractValidator<CreatePaymentMethodDto>
    {
        public CreatePaymentMethodDtoValidator()
        {
            RuleFor(p => p.Name)
                .NotEmpty()
                .MaximumLength(100);
        }
    }
}