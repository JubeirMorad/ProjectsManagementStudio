using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FluentValidation;

namespace ProjectsManagementStudio.Application.Features.Projects.Commands
{
    public class UpdateProjectStatusCommandValidator : AbstractValidator<UpdateProjectStatusCommand>
    {
        public UpdateProjectStatusCommandValidator()
        {
            RuleFor(c => c.Id)
                .NotNull()
                .WithMessage("Project Id is required.");


            RuleFor(c => c.NewStatus)
                .NotNull()
                .WithMessage("Project Status is required.");
        }
    }
}