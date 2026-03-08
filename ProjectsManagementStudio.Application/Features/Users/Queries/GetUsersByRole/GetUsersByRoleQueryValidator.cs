using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FluentValidation;

namespace ProjectsManagementStudio.Application.Features.Users.Queries
{
    public class GetUsersByRoleQueryValidator : AbstractValidator<GetUsersByRoleQuery>
    {
        public GetUsersByRoleQueryValidator()
        {
            RuleFor(user => user.Role)
                .NotNull()
                .WithMessage("Role is required.");
        }
    }
}