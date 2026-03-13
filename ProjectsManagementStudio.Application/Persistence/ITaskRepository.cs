
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
        Task<IEnumerable<TaskItem>?> GetTasksByProjectIdAsync(Guid projectId);
        Task<IEnumerable<TaskItem>?> GetTasksByAssignedUserIdAsync(Guid userId);
        Task<IEnumerable<TaskItem>?> GetTasksByStatusAsync(TaskItemStatus status);
        Task<IEnumerable<TaskItem>?> GetTasksByProjectIdAndStatusAsync(Guid ProjectId, TaskItemStatus status);
        Task<IEnumerable<TaskItem>?> GetTasksByUserIdAndStatusAsync(Guid UserId, TaskStatus status);

        //
        //
        // Commands
        Task<Guid> AddTaskAsync(TaskItem newTaskItem);
        Task UpdateTaskAsync(TaskItem taskItem);
        Task DeleteTaskAsync(TaskItem taskItem);

    }
}