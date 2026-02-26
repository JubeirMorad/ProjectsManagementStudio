
using ProjectsManagementStudio.Domain;

namespace ProjectsManagementStudio.Application.Features
{
    public record GetProjectQuery
    (
        Guid Id
    );


    public record GetProjectsByStatusQuery
    (
        ProjectStatus Status
    );



    public record GetProjectsByUserIdQuery
    (
        Guid UserId
    );



    public record GetProjectByMembershipIdQuery
    (
        Guid MembershipId
    );



    public record GetAllProjectsQuery();


}