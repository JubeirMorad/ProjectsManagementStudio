
using ProjectsManagementStudio.Application.Persistence;
using ProjectsManagementStudio.Domain;

namespace ProjectsManagementStudio.Application.Features
{
    public class ChangeUserRoleCommandHandler
    {
        private readonly IUserRepository _userRepo;
        public ChangeUserRoleCommandHandler(IUserRepository userRepository)
        {
            _userRepo = userRepository;
        }

        public async Task Handle(ChangeUserRoleCommand command)
        {
            if (await _userRepo.GetUserByIdAsync(command.Id) is User user)
            {
                if(command.NewRole == user.Role) return;
                
                user.Role = command.NewRole;
                await _userRepo.UpdateUserAsync(user);
            }
            else throw new KeyNotFoundException($"User with id {command.Id} was not found!");
        }
    }
}