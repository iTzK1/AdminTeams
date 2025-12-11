using AdminTeams.Domain.Entities;
using FluentValidation;

namespace AdminTeams.Service.Validators
{
    public class InjuryValidator : AbstractValidator<Injury>
    {
        public InjuryValidator()
        {
            RuleFor(x => x.Description)
                .NotEmpty().WithMessage("Please enter the description.")
                .MaximumLength(200).WithMessage("Description max length is 200.");

            RuleFor(x => x.StartDate)
                .NotEmpty().WithMessage("Start date is required.");

            
            RuleFor(x => x.PlayerId)
                .GreaterThan(0).WithMessage("Please select a player.");

            RuleFor(x => x.EndDate)
                .GreaterThanOrEqualTo(x => x.StartDate)
                .When(x => x.EndDate.HasValue)
                .WithMessage("End date must be after start date.");
        }
    }
}