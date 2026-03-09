using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FluentValidation;

namespace ProjectsManagementStudio.Application.Features.Projects.Commands
{
    public class CreateProjectCommandValidation : AbstractValidator<CreateProjectCommand>
    {
        public CreateProjectCommandValidation()
        {
            RuleFor(c => c.Name)
                .Cascade(CascadeMode.Stop)
                .NotEmpty()
                .WithMessage("Project Name cannot be empty.")
                .MaximumLength(50)
                .WithMessage("Project name cannot be > 50 characters.");

            RuleFor(c => c.Description)
                .NotEmpty()
                .WithMessage("Project Description cannot be empty.")
                .MaximumLength(300)
                .WithMessage("Project description cannot be > 300 characters.");
        }
    }
}