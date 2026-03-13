
using FluentValidation;

namespace ProjectsManagementStudio.Application.Features.MemberShips.Commands
{
    public class DeleteMemberShipCommandValidator : AbstractValidator<DeleteMemberShipCommand>
    {
        public DeleteMemberShipCommandValidator()
        {
            
            RuleFor(c => c.UserId)
                .NotNull()
                .WithMessage("User id is required.");

            RuleFor(c => c.ProjectId)
                .NotNull()
                .WithMessage("Project id is required.");
   
        }
    }
}