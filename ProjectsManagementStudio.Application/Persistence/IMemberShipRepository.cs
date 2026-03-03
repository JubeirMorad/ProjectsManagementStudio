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
        Task UpdateMemberShipAsync(MemberShip memberShip);
        Task DeleteMemberShipAsync(MemberShip memberShip);
        Task AddMemberShipAsync(MemberShip memberShip);
        
    }
}