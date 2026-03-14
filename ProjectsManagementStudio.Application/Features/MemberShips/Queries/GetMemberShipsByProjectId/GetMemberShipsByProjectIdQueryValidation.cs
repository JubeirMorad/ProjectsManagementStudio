

using FluentValidation;

namespace ProjectsManagementStudio.Application.Features.MemberShips.Queries
{
    public class GetMemberShipsByProjectIdQueryValidation : AbstractValidator<GetMemberShipsByProjectIdQuery>
    {
        public GetMemberShipsByProjectIdQueryValidation()
        {
            RuleFor(q => q.ProjectId)
                .NotNull()
                .WithMessage("Project id is required.");
        }   
    }
}