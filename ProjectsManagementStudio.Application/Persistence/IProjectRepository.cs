using ProjectsManagementStudio.Domain;

namespace ProjectsManagementStudio.Application.Persistence
{
    public interface IProjectRepository
    {
        //
        //
        // Queries
        Task<IEnumerable<Project>?> GetAllProjectAsync();
        Task<Project?> GetProjectByIdAsync(Guid ProjectId);
        Task<IEnumerable<Project>?> GetProjectsByStatusAsync(ProjectStatus Status);
        Task<IEnumerable<Project>?> GetProjectsByUserIdAsync(Guid UserId);

        //
        //
        // Commands
        Task<Guid> AddProjectAsync(Project project); // return new project id
        Task UpdateProjectAsync(Project project);
        Task DeleteProjectAsync(Project project);
    }
}