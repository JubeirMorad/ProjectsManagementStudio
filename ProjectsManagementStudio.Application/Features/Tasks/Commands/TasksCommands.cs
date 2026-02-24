using ProjectsManagementStudio.Domain;

namespace ProjectsManagementStudio.Application
{

    public record CreateTaskCommand
    (
        string Title,
        string Description,
        Guid AssignedToUserId,
        Guid ProjectId
    );


    public record UpdateTaskStatusCommand
    (
        Guid TaskId,
        TaskItemStatus NewStatus
    );



    public record ChangeUserAssignmentCommand
    (
        Guid TaskId,
        Guid? NewAssignedToUserId
    );


    public record DeleteTaskCommand
    (
        Guid TaskId
    );


    public record ChangeTaskTitleCommand
    (
        Guid TaskId,
        string NewTitle
    );


    public record ChangeTaskDescriptionCommand
    (
        Guid TaskId,
        string NewDescription
    );


    public record MoveTaskToAnotherProjectCommand
    (
        Guid TaskId,
        Guid NewProjectId
    );

    

}
