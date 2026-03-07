
using ProjectsManagementStudio.Application.Persistence;
using ProjectsManagementStudio.Domain;

namespace ProjectsManagementStudio.Application.Features.Users.Commands
{
    public class RegisterUserCommandHandler
    {
        private readonly IUserRepository _userRepo;
        private readonly IPasswordHasher _passwordHasher;
        public RegisterUserCommandHandler(IUserRepository userRepository, IPasswordHasher passwordHasher)
        {
            _userRepo = userRepository;
            _passwordHasher = passwordHasher;
        }

        public async Task<Guid> Handle(RegisterUserCommand command)
        {
            string PasswordHash = _passwordHasher.HashPassword(command.Password);

            User newUser = new (command.Name, command.Email ,PasswordHash);

            // Check if email is already taken
            // send token, cookie, etc for authentication
            
            return await _userRepo.AddUserAsync(newUser);
        }
    }
}