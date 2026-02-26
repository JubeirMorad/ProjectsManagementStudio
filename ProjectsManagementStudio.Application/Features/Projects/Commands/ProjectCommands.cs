
using ProjectsManagementStudio.Domain;
using System.ComponentModel.DataAnnotations;


namespace ProjectsManagementStudio.Application.Features
{
    public record CreateProjectCommand
    (
        [MaxLength(50, ErrorMessage = "Project name cannot exceed 50 characters.")]
        string Name,

        [MaxLength(255, ErrorMessage = "Project description cannot exceed 255 characters.")]
        string Description
    );

    public record UpdateProjectNameCommand
    (
        Guid Id,

        [MaxLength(50, ErrorMessage = "Project name cannot exceed 50 characters.")]
        string Name,

        [MaxLength(255, ErrorMessage = "Project description cannot exceed 255 characters.")]
        string Description
    );

    public record UpdateProjectDescriptionCommand
    (
        Guid Id,
        [MaxLength(255, ErrorMessage = "Project description cannot exceed 255 characters.")]
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