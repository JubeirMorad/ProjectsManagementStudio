using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FluentValidation;
using ProjectsManagementStudio.Application.Persistence;

namespace ProjectsManagementStudio.Application.Features.Projects.Commands
{
    public class UpdateProjectNameCommandValidator : AbstractValidator<UpdateProjectNameCommand>
    {
        private readonly IProjectRepository _projectRepo;
        public UpdateProjectNameCommandValidator(IProjectRepository projectRepository)
        {
            _projectRepo = projectRepository;

            RuleFor(c => c.Id)
                .NotNull()
                .WithMessage("Project Id is required.");


            RuleFor(c => c.Name)
                .Cascade(CascadeMode.Stop)
                .NotEmpty()
                .WithMessage("Project name is required.")
                .MaximumLength(50)
                .WithMessage("Project name cannot be > 50 characters.");
        }

    }
}