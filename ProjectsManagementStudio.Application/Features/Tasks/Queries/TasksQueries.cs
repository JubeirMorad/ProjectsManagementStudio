using ProjectsManagementStudio.Domain;

namespace ProjectsManagementStudio.Application
{
    public record GetTaskByIdQuery
    (
        Guid TaskId
    );


    public record GetTasksByProjectIdQuery
    (
        Guid ProjectId
    );


    public record GetTasksByAssignedUserIdQuery
    (
        Guid AssignedToUserId
    );


    public record GetTasksByStatusQuery
    (
        TaskItemStatus Status
    );


    public record GetTasksByProjectIdAndStatusQuery
    (
        Guid ProjectId,
        TaskItemStatus Status
    );


    public record GetTasksByAssignedUserIdAndStatusQuery
    (
        Guid AssignedToUserId,
        TaskItemStatus Status
    );


    public record GetAllTasksQuery;
}