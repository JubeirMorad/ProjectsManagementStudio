
using FluentValidation;

namespace ProjectsManagementStudio.Application.Features.Users.Queries
{
    public class GetUserByEmailQueryValidator : AbstractValidator<GetUserByEmailQuery>
    {
        public GetUserByEmailQueryValidator()
        {
            RuleFor(user => user.Email)
                .Cascade(CascadeMode.Stop)
                .NotNull()
                .WithMessage("Email is required.")
                .EmailAddress()
                .WithMessage("Invalid email address format.");
        }
    }
}