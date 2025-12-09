using AdminTeams.Domain.Entities;
using FluentValidation;

namespace AdminTeams.Service.Validators
{
    public class PositionValidator : AbstractValidator<Position>
    {
        public PositionValidator()
        {
            RuleFor(p => p.Name)
                .NotEmpty().WithMessage("Please enter the name.")
                .NotNull().WithMessage("Please enter the name.")
                .MaximumLength(50).WithMessage("Name must be 50 characters or fewer.");

            RuleFor(p => p.Acronym)
                .NotEmpty().WithMessage("Please enter the acronym.")
                .NotNull().WithMessage("Please enter the acronym.")
                .MaximumLength(10).WithMessage("Acronym must be 10 characters or fewer.");
        }
    }
}