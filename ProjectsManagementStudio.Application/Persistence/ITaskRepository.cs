
using System.Transactions;
using ProjectsManagementStudio.Domain;

namespace ProjectsManagementStudio.Application.Persistence
{
    public interface ITaskRepository
    {
        //
        //
        // Queries
        Task<TaskItem?> GetTaskByIdAsync(Guid id);
        Task<IEnumerable<TaskItem>?> GetTasksByProjectId(Guid projectId);
        Task<IEnumerable<TaskItem>?> GetTasksByAssignedUserId(Guid userId);
        Task<IEnumerable<TaskItem>?> GetTasksByStatus(Guid userId);
        Task<IEnumerable<TaskItem>?> GetTasksByProjectIdAndStatus(Guid ProjectId, TaskItemStatus status);
        Task<IEnumerable<TaskItem>?> GetTasksByUserIdAndStatus(Guid UserId, TaskStatus status);

        //
        //
        // Commands
        Task<Guid> AddTaskAsync(TaskItem newTaskItem);
        Task<bool> ChangeTaskAsync(TaskItem taskItem);
        Task<bool> DeleteTaskAsync(Guid Id);

    }
}