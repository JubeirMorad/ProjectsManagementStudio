
using ProjectsManagementStudio.Application.Persistence;
using ProjectsManagementStudio.Domain;

namespace ProjectsManagementStudio.Application.Features.Users.Commands
{
    public class DeleteUserCommandHandler
    {
        private readonly IUserRepository _userRepo;
        public DeleteUserCommandHandler(IUserRepository userRepository)
        {
            _userRepo = userRepository;
        }

        public async Task Handle(DeleteUserCommand command)
        {
            if ( await _userRepo.GetUserByIdAsync(command.Id) is User user )
            {
                await _userRepo.DeleteUserAsync(user);
                
            }
            else throw new KeyNotFoundException($"User with id {command.Id} was not found!");
        }
    }
}