using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FluentValidation;

namespace ProjectsManagementStudio.Application.Features.Projects.Queries
{
    public class GetProjectsByUserIdQueryValidator : AbstractValidator<GetProjectsByUserIdQuery>
    {
        public GetProjectsByUserIdQueryValidator()
        {
            RuleFor(q => q.UserId)
                .NotNull()
                .WithMessage("User id is required.");
        }
    }
}