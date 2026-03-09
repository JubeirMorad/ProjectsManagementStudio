using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ProjectsManagementStudio.Application.Persistence;

namespace ProjectsManagementStudio.Application.Features.Projects.Commands
{
    public class UpdateProjectNameCommandHandler
    {
        private readonly IProjectRepository _projectRepo;
        public UpdateProjectNameCommandHandler(IProjectRepository projectRepository)
        {
            _projectRepo = projectRepository;
        }

        public async Task Handle(UpdateProjectNameCommand command)
        {
            var project = await _projectRepo.GetProjectByIdAsync(command.Id);

            if (project is null)
                throw new KeyNotFoundException($"Project with id {command.Id} was not found.");

            project.Name = command.Name;
            await _projectRepo.UpdateProjectAsync(project);
        }
    }
}