
using ProjectsManagementStudio.Application.Persistence;
using ProjectsManagementStudio.Domain;

namespace ProjectsManagementStudio.Application.Features.Projects.Commands
{
    public class UpdateProjectStatusCommandHandler
    {
        private readonly IProjectRepository _projectRepo;
        public UpdateProjectStatusCommandHandler(IProjectRepository projectRepository)
        {
            _projectRepo = projectRepository;
        }

        public async Task Handle(UpdateProjectStatusCommand command)
        {
            var project = await _projectRepo.GetProjectByIdAsync(command.Id);

            if (project is null)
                throw new KeyNotFoundException($"Project with id {command.Id} was not found.");

            if (command.NewStatus == ProjectStatus.InProgress)
                project.SetStatusInProgress();

            else if (command.NewStatus == ProjectStatus.Completed)
                project.SetStatusCompleted();


            else throw new ArgumentException("Invalid input, cannot set status 'New'.");

            await _projectRepo.UpdateProjectAsync(project);
        }
    }
}