
using ProjectsManagementStudio.Domain;

namespace ProjectsManagementStudio.Application.Features
{
    public record TaskResponse
    (
        Guid Id,
        string Title,
        string Description,
        TaskItemStatus Status,
        Guid? AssignedToUserId,
        Guid ProjectId
    );
}