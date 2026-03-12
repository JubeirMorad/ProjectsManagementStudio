

using FluentValidation;

namespace ProjectsManagementStudio.Application.Features.Tasks.Commands
{
    public class ChangeTaskTitleCommandValidator : AbstractValidator<ChangeTaskTitleCommand>
    {
        public ChangeTaskTitleCommandValidator()
        {
            RuleFor(c => c.TaskId)
                .NotNull()
                .WithMessage("Task id is required.");

            RuleFor(c => c.NewTitle)
                .NotEmpty()
                .WithMessage("Tite is required.")
                .MaximumLength(50)
                .WithMessage("Title length cannot be > 50.");
                
        }
    }
}