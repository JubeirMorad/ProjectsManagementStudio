
using ProjectsManagementStudio.Domain;

namespace ProjectsManagementStudio.Application.Features
{
    public record UserResponse
    (
        Guid Id,
        string Name,
        string Email,
        UserRole Role,
        IEnumerable<TaskItem>? Tasks,
        IEnumerable<Project>? Projects
    );

    
}