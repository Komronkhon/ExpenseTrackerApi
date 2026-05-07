using ExpenseTracker.Entities.DTOs.Request;
using FluentValidation;

namespace ExpenseTracker.Validators
{
    public class CreateUserDtoValidator : AbstractValidator<CreateUserDto>
    {
        public CreateUserDtoValidator()
        {
            RuleFor(u => u.Name)
                .NotEmpty()
                .MaximumLength(100);

            RuleFor(u => u.Email)
                .NotEmpty()
                .EmailAddress()
                .MaximumLength(150);
        }
    }
}