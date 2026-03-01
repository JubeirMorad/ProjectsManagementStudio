
using ProjectsManagementStudio.Application.Features;
using ProjectsManagementStudio.Domain;

namespace ProjectsManagementStudio.Application.Persistence
{
    public interface IUserRepository
    {
        //
        //
        // Queries //
        Task<IEnumerable<User>?> GetAllUsersAsync();

        Task<User?> GetUserByIdAsync(Guid id, bool WithTasks = false);

        Task<User?> GetUserByRoleAsync(UserRole role, bool WithTasks = false);

        Task<IEnumerable<User>?> GetUsersByTaskIdAsync(Guid taskId);

        Task<User?> GetUserByEmailAsync(string email, bool WithTasks = false);

        Task<bool> ExistsByEmailAsync(string email);

        //
        //
        // Commands //
        Task AddUserAsync(User user);

        Task UpdateUser(User user);

        Task DeleteUser(Guid userId);

    }
}