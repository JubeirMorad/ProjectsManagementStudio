
using ProjectsManagementStudio.Application.Persistence;
using ProjectsManagementStudio.Domain;

namespace ProjectsManagementStudio.Application.Features
{
    public class RegisterUserCommandHundler
    {
        private readonly IUserRepository _userRepo;
        private readonly IPasswordHasher _passwordHasher;
        public RegisterUserCommandHundler(IUserRepository userRepository, IPasswordHasher passwordHasher)
        {
            _userRepo = userRepository;
            _passwordHasher = passwordHasher;
        }

        public async Task<Guid> Hundle(RegisterUserCommand command)
        {
            string PasswordHash = _passwordHasher.HashPassword(command.Password);

            User newUser = new (command.Name, command.Email ,PasswordHash);
            
            return await _userRepo.AddUserAsync(newUser);
        }
    }
}