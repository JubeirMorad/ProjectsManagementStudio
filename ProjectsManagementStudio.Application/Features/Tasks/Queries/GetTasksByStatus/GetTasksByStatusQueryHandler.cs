
using ProjectsManagementStudio.Application.Persistence;

namespace ProjectsManagementStudio.Application.Features.Tasks.Queries
{
    public class GetTasksByStatusQueryHandler
    {
        private readonly ITaskRepository _taskRepo;
        public GetTasksByStatusQueryHandler(ITaskRepository taskRepository)
        {
            _taskRepo = taskRepository;
        }

        public async Task<List<TaskByStatusResponse>> Handle(GetTasksByStatusQuery query)
        {
            var tasks = await _taskRepo.GetTasksByStatusAsync(query.Status);

            if (tasks is null)
                return [];

            return tasks.Select(
                t =>
                new TaskByStatusResponse(t.Id, t.Title, t.Description, t.Status, t.AssignedToUserId, t.ProjectId)
            ).ToList();
            
        }
    }
}