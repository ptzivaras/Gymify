using FluentValidation;
using GymifyAPI.DTOs;

namespace GymifyAPI.Validators
{
    public class CreateCustomerDtoValidator : AbstractValidator<CreateCustomerDto>
    {
        public CreateCustomerDtoValidator()
        {
            RuleFor(x => x.FullName)
                .NotEmpty().WithMessage("FullName is required")
                .MaximumLength(100);

            RuleFor(x => x.Email)
                .NotEmpty().WithMessage("Email is required")
                .EmailAddress();

            RuleFor(x => x.PhoneNumber)
                .NotEmpty().WithMessage("PhoneNumber is required")
                .Matches(@"^\+?[0-9]{7,15}$")
                .WithMessage("PhoneNumber must be a valid phone number");

            RuleFor(x => x.DateOfBirth)
                .LessThan(DateTime.Today)
                .WithMessage("DateOfBirth must be in the past");
        }
    }
}
