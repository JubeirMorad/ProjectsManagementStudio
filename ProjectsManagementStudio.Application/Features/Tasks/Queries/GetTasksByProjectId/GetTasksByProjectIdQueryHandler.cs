
using ProjectsManagementStudio.Application.Persistence;

namespace ProjectsManagementStudio.Application.Features.Tasks.Queries
{
    public class GetTasksByProjectIdQueryHandler
    {
        private readonly ITaskRepository _taskRepo;

        public GetTasksByProjectIdQueryHandler(ITaskRepository taskRepository)
        {
            _taskRepo = taskRepository;
        }

        public async Task<List<TaskByProjectResponse>> Handle(GetTasksByProjectIdQuery query)
        {
            var tasks = await _taskRepo.GetTasksByProjectIdAsync(query.ProjectId);

            if (tasks is null)
                return [];

            return tasks.Select(t =>
                        new TaskByProjectResponse(t.Id, t.Title, t.Description, t.Status, t.AssignedToUserId)
                    ).ToList();
        }
    }
}