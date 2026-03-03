
using ProjectsManagementStudio.Application.Persistence;
using ProjectsManagementStudio.Domain;

namespace ProjectsManagementStudio.Application.Features
{
    public class ChangeUserRoleCommandHundler
    {
        private readonly IUserRepository _userRepo;
        public ChangeUserRoleCommandHundler(IUserRepository userRepository)
        {
            _userRepo = userRepository;
        }

        public async Task<bool> Hundle(ChangeUserRoleCommand command)
        {
            if (await _userRepo.GetUserByIdAsync(command.Id) is User user)
            {
                user.Role = command.NewRole;
                await _userRepo.UpdateUserAsync(user);
                return true;
            }
            
            return false;
        }
    }
}