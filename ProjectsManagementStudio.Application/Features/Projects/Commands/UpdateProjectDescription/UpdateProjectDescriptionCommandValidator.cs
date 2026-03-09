using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FluentValidation;

namespace ProjectsManagementStudio.Application.Features.Projects.Commands.UpdateProjectDescription
{
    public class UpdateProjectDescriptionCommandValidator : AbstractValidator<UpdateProjectDescriptionCommand>
    {
        public UpdateProjectDescriptionCommandValidator()
        {
            RuleFor(c => c.Id)
                .NotNull()
                .WithMessage("Project id is required.");


            RuleFor(c => c.Description)
                .Cascade(CascadeMode.Stop)
                .NotEmpty()
                .WithMessage("Project description is required.")
                .MaximumLength(300)
                .WithMessage("Project description cannot be > 300 characters.");
        }
    }
}