
using FluentValidation;

namespace ProjectsManagementStudio.Application.Features.Tasks.Queries
{
    public class GetTaskByIdQueryValidator : AbstractValidator<GetTaskByIdQuery>
    {
        public GetTaskByIdQueryValidator()
        {
            RuleFor(q => q.TaskId)
                .NotNull()
                .WithMessage("Task id is required.");
        }
    }
}