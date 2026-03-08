using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ProjectsManagementStudio.Application.Persistence;
using ProjectsManagementStudio.Domain;

namespace ProjectsManagementStudio.Application.Features.Users.Commands
{
    public class ChangeUserPasswordCommandHandler
    {
        private readonly IUserRepository _userRepo;
        private readonly IPasswordHasher _passwordHasher;
        public ChangeUserPasswordCommandHandler(IUserRepository userRepository, IPasswordHasher passwordHasher)
        {
            _userRepo = userRepository;
            _passwordHasher = passwordHasher;
        }

        public async Task Handle(ChangeUserPasswordCommand command)
        {
            if (await _userRepo.GetUserByIdAsync(command.Id) is User user)
            {

                if (!_passwordHasher.Verfiy(command.CurrentPassword, user.PasswordHash))
                    return; // return Result later

                var newPasswordHash = _passwordHasher.HashPassword(command.NewPassword);

                user.PasswordHash = newPasswordHash;

                await _userRepo.UpdateUserAsync(user);
                return; // return Result later
                
            }
            else throw new KeyNotFoundException($"User with id {command.Id} was not found!");
        }
    }
}