using System.ComponentModel.DataAnnotations;
using ProjectsManagementStudio.Domain;

namespace ProjectsManagementStudio.Application.Features
{

    public record CreateTaskCommand
    (
        [MaxLength(50, ErrorMessage = "Title length cannot be > 50")]
        string Title,
        
        [MaxLength(255, ErrorMessage = "Description length cannot be > 255")]
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

        [MaxLength(50, ErrorMessage = "Title length cannot be > 50")]
        string NewTitle
    );


    public record ChangeTaskDescriptionCommand
    (
        Guid TaskId,

        [MaxLength(255, ErrorMessage = "Description length cannot be > 255")]
        string NewDescription
    );


    public record MoveTaskToAnotherProjectCommand
    (
        Guid TaskId,
        Guid NewProjectId
    );

    

}
