using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FluentValidation;

namespace ProjectsManagementStudio.Application.Features.Users.Commands
{
    public class ChangeUserRoleCommandValidator : AbstractValidator<ChangeUserRoleCommand>
    {
        public ChangeUserRoleCommandValidator()
        {
            RuleFor(user => user.Id)
                .NotNull().WithMessage("Id is required.");

            RuleFor(user => user.NewRole)
                .NotNull().WithMessage("Role is required.");
        }        
    }
}