using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ProjectsManagementStudio.Application.Persistence;
using ProjectsManagementStudio.Domain;

namespace ProjectsManagementStudio.Application.Features.Projects.Commands
{
    public class CreateProjectCommandHandler
    {
        private readonly IProjectRepository _projectRepo;
        public CreateProjectCommandHandler(IProjectRepository projectRepo)
        {
            _projectRepo = projectRepo;
        }

        public async Task<Guid> Handle(CreateProjectCommand command)
        {
            return await _projectRepo.AddProjectAsync(
                new Project(command.Name, command.Description)
            );
        }
    }
}