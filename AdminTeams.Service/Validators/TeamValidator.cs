using AdminTeams.Domain.Entities;
using FluentValidation;

namespace AdminTimes.Service.Validators
{
    public class TeamValidator : AbstractValidator<Team>
    {
        public TeamValidator()
        {
            RuleFor(t => t.Name)
                .NotEmpty().WithMessage("Please enter the name.")
                .NotNull().WithMessage("Please enter the name.")
                .MaximumLength(100).WithMessage("Name must be 100 characters or fewer.");

            RuleFor(t => t.Category)
                .NotEmpty().WithMessage("Please enter the category.")
                .NotNull().WithMessage("Please enter the category.")
                .MaximumLength(50).WithMessage("Category must be 50 characters or fewer.");
        }
    }
}