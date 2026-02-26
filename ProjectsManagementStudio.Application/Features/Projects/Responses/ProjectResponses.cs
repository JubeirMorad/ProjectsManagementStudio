

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



    public record ProjectWithMemberShipsResponse
    (
        Guid Id,
        string Name,
        string Description,
        DateTime StartDate,
        DateTime? EndDate,
        ProjectStatus Status,
        IEnumerable<MemberShipResponse>? MemberShips
    );


    public record ProjectWithTasksResponse
    (
        Guid Id,
        string Name,
        string Description,
        DateTime StartDate,
        DateTime? EndDate,
        ProjectStatus Status,
        IEnumerable<TaskResponse>? Tasks
    );



    public record ProjectWithDetailsResponse
    (
        Guid Id,
        string Name,
        string Description,
        DateTime StartDate,
        DateTime? EndDate,
        ProjectStatus Status,
        IEnumerable<MemberShipResponse>? MemberShips,
        IEnumerable<TaskResponse>? Tasks
    );
}