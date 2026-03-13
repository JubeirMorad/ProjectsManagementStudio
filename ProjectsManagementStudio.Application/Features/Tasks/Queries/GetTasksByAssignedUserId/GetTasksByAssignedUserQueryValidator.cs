using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FluentValidation;

namespace ProjectsManagementStudio.Application.Features.Tasks.Queries
{
    public class GetTasksByAssignedUserQueryValidator  : AbstractValidator<GetTasksByAssignedUserIdQuery>
    {
        public GetTasksByAssignedUserQueryValidator()
        {
            RuleFor(q => q.AssignedToUserId)
                .NotNull()
                .WithMessage("User id is required.");
        }
    }
}