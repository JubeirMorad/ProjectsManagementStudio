

using FluentValidation;

namespace ProjectsManagementStudio.Application.Features.Tasks.Commands
{
    public class MoveTaskToAnotherProjectCommandValidator : AbstractValidator<MoveTaskToAnotherProjectCommand>
    {
        public MoveTaskToAnotherProjectCommandValidator()
        {


            RuleFor(c => c.TaskId)
                .NotNull()
                .WithMessage("Task id is required.");

            RuleFor(c => c.NewProjectId)
                .NotNull()
                .WithMessage("Project id is required.");

        }


    }
}