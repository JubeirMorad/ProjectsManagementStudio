
using ProjectsManagementStudio.Domain;

namespace ProjectsManagementStudio.Application.Features.Users.Responses
{
    public record UserResponse
    (
        Guid Id,
        string Name,
        string Email,
        UserRole Role
    );
}