

using ProjectsManagementStudio.Domain;

namespace ProjectsManagementStudio.Application.Features
{

    public record ProjectResponse
    (
        Guid Id,
        string Name,
        string Description,
        DateTime StartDate,
        DateTime? EndDate,
        ProjectStatus Status
    );


}