using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FluentValidation;

namespace ProjectsManagementStudio.Application.Features.Projects.Queries
{
    public class GetProjectsByStatusQueryValidation : AbstractValidator<GetProjectsByStatusQuery>
    {
        public GetProjectsByStatusQueryValidation()
        {
            RuleFor(q => q.Status)
                .NotNull()
                .WithMessage("Project's status is required.");
        }
    }
}