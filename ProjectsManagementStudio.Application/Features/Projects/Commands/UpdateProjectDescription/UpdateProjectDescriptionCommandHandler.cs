using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ProjectsManagementStudio.Application.Persistence;

namespace ProjectsManagementStudio.Application.Features.Projects.Commands
{
    public class UpdateProjectDescriptionCommandHandler
    {
        private readonly IProjectRepository _projectRepo;
        public UpdateProjectDescriptionCommandHandler(IProjectRepository projectRepository)
        {
            _projectRepo = projectRepository;
        }

        public async Task Handler(UpdateProjectDescriptionCommand command)
        {
            var project = await _projectRepo.GetProjectByIdAsync(command.Id);

            if (project is null)
                throw new KeyNotFoundException($"Project with id {command.Id} was not found.");

            project.Description = command.Description;

            await _projectRepo.UpdateProjectAsync(project);
        }
    }
}