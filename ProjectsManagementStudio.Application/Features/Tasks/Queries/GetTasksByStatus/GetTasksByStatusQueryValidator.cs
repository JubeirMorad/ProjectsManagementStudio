
using FluentValidation;

namespace ProjectsManagementStudio.Application.Features.Tasks.Queries
{
    public class GetTasksByStatusQueryValidator : AbstractValidator<GetTasksByStatusQuery>
    {
        public GetTasksByStatusQueryValidator()
        {
            RuleFor(q => q.Status)
                .NotNull()
                .WithMessage("Status is required.");
        }
    }
}