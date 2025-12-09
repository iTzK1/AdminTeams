using AdminTeams.Domain.Entities;
using FluentValidation;

namespace AdminTimes.Service.Validators
{
    public class PlayerValidator : AbstractValidator<Player>
    {
        public PlayerValidator()
        {
            RuleFor(p => p.Name)
                .NotEmpty().WithMessage("Please enter the name.")
                .NotNull().WithMessage("Please enter the name.")
                .MaximumLength(100).WithMessage("Name must be 100 characters or fewer.");

            RuleFor(p => p.BirthDate)
                .NotEmpty().WithMessage("Please enter the birth date.")
                .NotNull().WithMessage("Please enter the birth date.");

            RuleFor(p => p.ShirtNumber)
                .GreaterThan(0).WithMessage("Shirt number must be greater than zero.");

            RuleFor(p => p.Team)
                .NotNull().WithMessage("Please select a team.");

            RuleFor(p => p.Position)
                .NotNull().WithMessage("Please select a position.");
        }
    }
}