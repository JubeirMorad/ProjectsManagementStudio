using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FluentValidation;

namespace ProjectsManagementStudio.Application.Features.Projects.Queries
{
    public class GetProjectByIdQueryValidator : AbstractValidator<GetProjectByIdQuery>
    {
        public GetProjectByIdQueryValidator()
        {
            RuleFor(q => q.Id)
                .NotNull()
                .WithMessage("Prject Id is required.");
        }
    }
}