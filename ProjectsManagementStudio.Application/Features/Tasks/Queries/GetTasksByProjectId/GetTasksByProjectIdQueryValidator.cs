
using FluentValidation;

namespace ProjectsManagementStudio.Application.Features.Tasks.Queries
{
    public class GetTasksByProjectIdQueryValidator : AbstractValidator<GetTasksByProjectIdQuery>
    {
        public GetTasksByProjectIdQueryValidator()
        {
            RuleFor(q => q.ProjectId)
                .NotNull()
                .WithMessage("Project id is required.");
        }
    }
}