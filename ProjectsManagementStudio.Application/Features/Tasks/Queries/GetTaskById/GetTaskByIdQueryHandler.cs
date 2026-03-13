using ProjectsManagementStudio.Application.Persistence;

namespace ProjectsManagementStudio.Application.Features.Tasks.Queries
{
    public class GetTaskByIdQueryHandler
    {
        private readonly ITaskRepository _taskRepo;

        public GetTaskByIdQueryHandler(ITaskRepository taskRepository)
        {
            _taskRepo = taskRepository;
        }

        public async Task<TaskByIdResponse> Handle(GetTaskByIdQuery query)
        {
            var task = await _taskRepo.GetTaskByIdAsync(query.TaskId);

            if (task is null)
                throw new KeyNotFoundException($"task with id {query.TaskId} was not found.");

            UserResponse? user = null;
            ProjectResponse project ;

            if (task.AssignedToUser is not null)
            {
                user = new(
                    task.AssignedToUser.Id,
                    task.AssignedToUser.Name,
                    task.AssignedToUser.Email,
                    task.AssignedToUser.Role
                ) ;
            }
            
            project = new(
                task.Project.Id,
                task.Project.Name,
                task.Project.Description,
                task.Project.StartDate,
                task.Project.EndDate,
                task.Project.Status
            );
            

            return new(
                task.Id,
                task.Title,
                task.Description,
                task.Status,
                user,
                project);
        }
    }
}