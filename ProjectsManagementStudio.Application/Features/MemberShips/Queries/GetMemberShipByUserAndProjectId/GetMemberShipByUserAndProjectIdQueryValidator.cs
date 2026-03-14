
using FluentValidation;

namespace ProjectsManagementStudio.Application.Features.MemberShips.Queries
{
    public class GetMemberShipByUserAndProjectIdQueryValidator : AbstractValidator<GetMemberShipByUserAndProjectIdQuery>
    {
        public GetMemberShipByUserAndProjectIdQueryValidator()
        {
            
            RuleFor(q => q.UserId)
                .NotNull()
                .WithMessage("User id is required.");
            
            
            RuleFor(q => q.ProjectId)
                .NotNull()
                .WithMessage("Project id is required.");
        }
    }
}