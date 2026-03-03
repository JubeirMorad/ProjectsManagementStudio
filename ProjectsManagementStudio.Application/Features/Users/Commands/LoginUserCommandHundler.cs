
using ProjectsManagementStudio.Application.Persistence;
using ProjectsManagementStudio.Domain;

namespace ProjectsManagementStudio.Application.Features
{
    public class LoginUserCommandHundler
    {
        private readonly IUserRepository _userRepo;
        private readonly IPasswordHasher _passwordHasher;

        public LoginUserCommandHundler(IUserRepository userRepository, IPasswordHasher passwordHasher)
        {
            _userRepo = userRepository;
            _passwordHasher = passwordHasher;
        }

        public async Task<bool> Hundle(LoginUserCommand command)
        {
            User? user = await _userRepo.GetUserByEmailAsync(command.Email);

            if(user is not null)
                return _passwordHasher.Verfiy(command.Password, user.PasswordHash);

            return false;  
        }
    }
}