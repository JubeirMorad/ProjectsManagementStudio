
using FluentValidation;

namespace ProjectsManagementStudio.Application.Features.Users.Queries
{
    public class GetUserByIdQueryValidator : AbstractValidator<GetUserByIdQuery>
    {
        public GetUserByIdQueryValidator()
        {
            RuleFor(user => user.Id)
                .NotNull()
                .WithMessage("Id is required.");
        }
    }
}