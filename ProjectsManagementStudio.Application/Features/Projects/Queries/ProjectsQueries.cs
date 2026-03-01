
using ProjectsManagementStudio.Domain;

namespace ProjectsManagementStudio.Application.Features
{
    public record GetProjectByIdQuery
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




    public record GetAllProjectsQuery();


}