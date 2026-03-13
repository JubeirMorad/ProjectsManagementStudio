
using FluentValidation;

namespace ProjectsManagementStudio.Application.Features.MemberShips.Commands
{
    public class CreateMemberShipCommandValidator : AbstractValidator<CreateMemberShipCommand>
    {
        public CreateMemberShipCommandValidator()
        {
            RuleFor(c => c.UserId)
                .NotNull()
                .WithMessage("User id is required.");

            RuleFor(c => c.ProjectId)
                .NotNull()
                .WithMessage("Project id is required.");

            RuleFor(c => c.Role)
                .NotNull()
                .WithMessage("Project role is required.");
        }
    }
}