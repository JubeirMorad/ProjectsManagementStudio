
using FluentValidation;

namespace ProjectsManagementStudio.Application.Features.MemberShips.Queries
{
    public class GetMemberShipsByUserIdQueryValidator : AbstractValidator<GetMemberShipsByUserIdQuery>
    {
        public GetMemberShipsByUserIdQueryValidator()
        {
            RuleFor(q => q.UserId)
                .NotNull()
                .WithMessage("User id is required.");
        }
    }
}