using ProjectsManagementStudio.Domain;

namespace ProjectsManagementStudio.Application.Features
{
    public record MemberShipResponse
    (
        Guid Id,
        Guid UserId,
        Guid ProjectId,
        ProjectResponse Project,
        UserResponse User,
        ProjectRole Role
    );
}