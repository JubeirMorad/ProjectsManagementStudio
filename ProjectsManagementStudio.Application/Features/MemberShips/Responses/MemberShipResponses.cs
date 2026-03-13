using ProjectsManagementStudio.Domain;
 
namespace ProjectsManagementStudio.Application.Features
{
    public record MemberShipResponse
    (
        Guid UserId,
        Guid ProjectId,
        ProjectRole Role
    );
}