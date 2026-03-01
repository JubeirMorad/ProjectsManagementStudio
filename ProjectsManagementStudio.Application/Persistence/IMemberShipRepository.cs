using ProjectsManagementStudio.Domain;

namespace ProjectsManagementStudio.Application.Persistence
{
    public interface IMemberShipRepository
    {
        //
        //
        // Queries
        Task<IEnumerable<MemberShip>?> GetMemberShipsByUserIdAsync(Guid Id);
        Task<IEnumerable<MemberShip>?> GetMemberShipsByProjectIdAsync(Guid Id);
        Task<MemberShip> GetMemberShipByUserAndProjectAsync(Guid ProjectId, Guid UserId);

        //
        //
        // Commands
        Task<bool> UpdateMemberShipAsync(Guid ProjectId, Guid UserId);
        Task<bool> DeleteMemberShipAsync(Guid ProjectId, Guid UserId);
        Task AddMemberShipAsync(Guid ProjectId, Guid UserId);
        
    }
}