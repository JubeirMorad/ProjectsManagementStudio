
using System.Linq.Expressions;
using ProjectsManagementStudio.Application.Persistence;
using ProjectsManagementStudio.Domain;

namespace ProjectsManagementStudio.Application.Features.Users.Commands
{
    public class LoginUserCommandHandler
    {
        private readonly IUserRepository _userRepo;
        private readonly IPasswordHasher _passwordHasher;

        public LoginUserCommandHandler(IUserRepository userRepository, IPasswordHasher passwordHasher)
        {
            _userRepo = userRepository;
            _passwordHasher = passwordHasher;
        }

        public async Task Handle(LoginUserCommand command)
        {
            User? user = await _userRepo.GetUserByEmailAsync(command.Email);

            if(user is not null && _passwordHasher.Verfiy(command.Password, user.PasswordHash))
            {
                // sign in the user, create a session, generate a token, etc.
            }
            else throw new KeyNotFoundException($"User with email {command.Email} was not found!");
              
        }
    }
}