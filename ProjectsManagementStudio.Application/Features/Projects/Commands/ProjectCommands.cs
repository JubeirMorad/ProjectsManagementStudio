
using ProjectsManagementStudio.Domain;
using System.ComponentModel.DataAnnotations;


namespace ProjectsManagementStudio.Application.Features
{
    public record CreateProjectCommand
    (
        string Name,

        string Description
    );

    public record UpdateProjectNameCommand
    (
        Guid Id,

        string Name
    );

    public record UpdateProjectDescriptionCommand
    (
        Guid Id,
        string Description
    );

    public record UpdateProjectStatusCommand
    (
        Guid Id,
        ProjectStatus NewStatus
    );

    public record DeleteProjectCommand
    (
        Guid Id
    );
}