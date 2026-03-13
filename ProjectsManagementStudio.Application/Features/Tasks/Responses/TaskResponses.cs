
using ProjectsManagementStudio.Domain;

namespace ProjectsManagementStudio.Application.Features
{
    public record TaskByIdResponse
    (
        Guid Id,
        string Title,
        string Description,
        TaskItemStatus Status,
        UserResponse? AssignedToUser,
        ProjectResponse Project
    );

    public record TaskByProjectResponse
    (
        Guid Id,
        string Title,
        string Description,
        TaskItemStatus Status,
        Guid? AssignedToUserId
    );

    public record TasksByAssignedUserResponse
    (
        Guid Id,
        string Title,
        string Description,
        TaskItemStatus Status,
        Guid ProjectId
    );

    public record TaskByStatusResponse
    (
        Guid Id,
        string Title,
        string Description,
        TaskItemStatus Status,
        Guid? AssignedToUserId,
        Guid ProjectId
    );
}