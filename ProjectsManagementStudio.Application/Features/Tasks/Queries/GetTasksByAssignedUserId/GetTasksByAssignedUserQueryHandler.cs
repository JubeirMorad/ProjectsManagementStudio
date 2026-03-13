

using ProjectsManagementStudio.Application.Persistence;

namespace ProjectsManagementStudio.Application.Features.Tasks.Queries
{
    public class GetTasksByAssignedUserQueryHandler
    {
        private readonly ITaskRepository _taskRepo;
        public GetTasksByAssignedUserQueryHandler(ITaskRepository taskRepository)
        {
            _taskRepo = taskRepository;
        }

        public async Task<List<TasksByAssignedUserResponse>> Handle(GetTasksByAssignedUserIdQuery query)
        {
            var tasks = await _taskRepo.GetTasksByAssignedUserIdAsync(query.AssignedToUserId);

            if (tasks is null)
                return [];

            return tasks.Select(
                    t =>
                    new TasksByAssignedUserResponse(t.Id, t.Title, t.Description, t.Status, t.ProjectId)
                ).ToList();
        }
    }
}