
using FluentValidation;


namespace ProjectsManagementStudio.Application.Features.Tasks.Commands
{
    public class ChangeUserAssignmentCommandValidator : AbstractValidator<ChangeUserAssignmentCommand>
    {
        public ChangeUserAssignmentCommandValidator()
        {
            RuleFor(c => c.TaskId)
                .NotNull()
                .WithMessage("Task id is required.");


            RuleFor(c => c.NewAssignedToUserId)
                .NotNull()
                .WithMessage("User id is required.");
        }
    }
}