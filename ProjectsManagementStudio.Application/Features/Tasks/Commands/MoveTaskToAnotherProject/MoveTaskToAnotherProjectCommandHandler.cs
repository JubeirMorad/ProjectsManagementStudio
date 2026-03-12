
using ProjectsManagementStudio.Application.Persistence;

namespace ProjectsManagementStudio.Application.Features.Tasks.Commands
{
    public class MoveTaskToAnotherProjectCommandHandler
    {
        private readonly ITaskRepository _taskRepo;
        private readonly IProjectRepository _projectRepo;
        public MoveTaskToAnotherProjectCommandHandler(ITaskRepository taskRepository, IProjectRepository projectRepository)
        {
            _taskRepo = taskRepository;
            _projectRepo = projectRepository;
        }

        public async Task Handle(MoveTaskToAnotherProjectCommand command)
        {
            var task = await _taskRepo.GetTaskByIdAsync(command.TaskId);


            if (task is null)
                throw new KeyNotFoundException($"Task with id {command.TaskId} was not found.");
            
            if (await _projectRepo.GetProjectByIdAsync(command.NewProjectId) is null)
                throw new KeyNotFoundException($"Project with id {command.NewProjectId} was not found.");

            if (task.ProjectId == command.NewProjectId)
                return;

            task.ProjectId = command.NewProjectId;

            await _taskRepo.UpdateTaskAsync(task);
        }
    }
}