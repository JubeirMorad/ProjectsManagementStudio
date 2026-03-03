
using ProjectsManagementStudio.Application.Persistence;
using ProjectsManagementStudio.Domain;

namespace ProjectsManagementStudio.Application.Features
{
    public class DeleteUserCommandHundler
    {
        private readonly IUserRepository _userRepo;
        public DeleteUserCommandHundler(IUserRepository userRepository)
        {
            _userRepo = userRepository;
        }

        public async Task<bool> Hundle(DeleteUserCommand command)
        {
            if ( await _userRepo.GetUserByIdAsync(command.Id) is User user )
            {
                await _userRepo.DeleteUserAsync(user);
                return true;
            }
            return false;
        }
    }
}