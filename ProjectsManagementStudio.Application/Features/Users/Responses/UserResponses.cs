
using ProjectsManagementStudio.Domain;

namespace ProjectsManagementStudio.Application.Features
{
    public record UserResponse
    (
        Guid Id,
        string Name,
        string Email,
        UserRole Role
    );

    public record UserWithTaskResponse
    (
        Guid Id,
        string Name,
        string Email,
        UserRole Role,
        IEnumerable<TaskItem> Tasks
    );

    public record UserWithProjectsResponse
    (
        Guid Id,
        string Name,
        string Email,
        UserRole Role,
        IEnumerable<Project> Projects
    );


    public record UserWithAllDetailsResponse
    (
        Guid Id,
        string Name,
        string Email,
        UserRole Role,
        IEnumerable<TaskItem> Tasks,
        IEnumerable<Project> Projects
    );
}