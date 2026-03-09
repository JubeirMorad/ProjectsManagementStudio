
using ProjectsManagementStudio.Domain;

namespace ProjectsManagementStudio.Application.Persistence
{
    public interface IUserRepository
    {
        //
        //
        // Queries //
        Task<IEnumerable<User>?> GetAllUsersAsync();

        Task<User?> GetUserByIdAsync(Guid id);

        Task<IEnumerable<User>?> GetUsersByRoleAsync(UserRole role);

        Task<User?> GetUserByTaskIdAsync(Guid taskId);

        Task<User?> GetUserByEmailAsync(string email);

        Task<bool> ExistsByEmailAsync(string email);

        //
        //
        // Commands //
        Task<Guid> AddUserAsync(User user);  

        Task UpdateUserAsync(User user);

        Task DeleteUserAsync(User user);



    }
}