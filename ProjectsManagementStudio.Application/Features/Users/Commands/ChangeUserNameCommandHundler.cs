

using ProjectsManagementStudio.Application.Persistence;
using ProjectsManagementStudio.Domain;

namespace ProjectsManagementStudio.Application.Features
{
    public class ChangeUserNameCommandHundler
    {
        private readonly IUserRepository _userRepo;
        public ChangeUserNameCommandHundler(IUserRepository userRepository)
        {
            _userRepo = userRepository;
        }

        public async Task<User?> Hundle(ChangeUserNameCommand command)
        {
            User? user = await _userRepo.GetUserByIdAsync(command.Id);

            if (user is not null)
            {
                user.Name = command.Name;
                await _userRepo.UpdateUserAsync(user);
            }

            return user;
        }
    }
}