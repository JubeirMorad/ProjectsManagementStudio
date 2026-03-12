
using FluentValidation;

namespace ProjectsManagementStudio.Application.Features.Tasks.Commands
{
    public class ChangeTaskDescriptionCommandValidator : AbstractValidator<ChangeTaskDescriptionCommand>
    {
        public ChangeTaskDescriptionCommandValidator()
        {
            RuleFor(c => c.TaskId)
                .NotNull()
                .WithMessage("Task id is required.");

            
            RuleFor(c => c.NewDescription)
                .Cascade(CascadeMode.Stop)
                .NotEmpty()
                .WithMessage("Description is required.")
                .MaximumLength(300)
                .WithMessage("Description lenght cannot be > 300");
        }
    }
}