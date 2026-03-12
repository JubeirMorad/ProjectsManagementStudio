using FluentValidation;

namespace ProjectsManagementStudio.Application.Features.Tasks.Commands
{
    public class DeleteTaskCommandValidator : AbstractValidator<DeleteTaskCommand>
    {
        public DeleteTaskCommandValidator()
        {
            RuleFor(c => c.TaskId)
                .NotNull()
                .WithMessage("Task id is required.");
        }
    }
}