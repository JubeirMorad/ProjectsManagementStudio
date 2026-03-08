

using ProjectsManagementStudio.Application.Persistence;
using ProjectsManagementStudio.Domain;

namespace ProjectsManagementStudio.Application.Features.Users.Commands
{
    public class ChangeUserNameCommandHandler
    {
        private readonly IUserRepository _userRepo;
        public ChangeUserNameCommandHandler(IUserRepository userRepository)
        {
            _userRepo = userRepository;
        }

        public async Task Handle(ChangeUserNameCommand command)
        {
            User? user = await _userRepo.GetUserByIdAsync(command.Id);

            if (user is not null)
            {
                user.Name = command.NewName;
                await _userRepo.UpdateUserAsync(user);
            }
            else throw new KeyNotFoundException($"User with id {command.Id} was not found!");
        }
    }
}