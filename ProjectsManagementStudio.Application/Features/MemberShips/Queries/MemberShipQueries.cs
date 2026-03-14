

namespace ProjectsManagementStudio.Application.Features
{

    public record GetMemberShipsByProjectIdQuery
    (
        Guid ProjectId
    );

    public record GetMemberShipsByUserIdQuery
    (
        Guid UserId
    );

    public record GetMemberShipByUserAndProjectIdQuery
    (
        Guid ProjectId,
        Guid UserId
    );
}