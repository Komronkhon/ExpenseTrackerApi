using ExpenseTracker.Entities.DTOs.Request;
using FluentValidation;
using System.ComponentModel.DataAnnotations;

namespace ExpenseTracker.Validators
{
    public class CreateCategoryDtoValidator : AbstractValidator<CreateCategoryDto>
    {
        public CreateCategoryDtoValidator()
        {
            RuleFor(c => c.Name)
                .NotEmpty()
                .MaximumLength(100);
        }
    }
}
