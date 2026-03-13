
using FluentValidation;

namespace ProjectsManagementStudio.Application.Features.MemberShips.Commands.UpdateMemberShipUser
{
    public class UpdateMemberShipUserCommandValidator : AbstractValidator<UpdateMemberShipRoleCommand>
    {
        public UpdateMemberShipUserCommandValidator()
        {
            
            RuleFor(c => c.UserId)
                .NotNull()
                .WithMessage("User id is required.");

            RuleFor(c => c.ProjectId)
                .NotNull()
                .WithMessage("Project id is required.");

            RuleFor(c => c.newRole)
                .NotNull()
                .WithMessage("Project role is required.");
        }
    }
}