using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ProjectsManagementStudio.Application.Persistence;

namespace ProjectsManagementStudio.Application.Features.Users.Commands
{
    public class ChangeUserEmailCommandHandler
    {
        private readonly IUserRepository _userRepo;
        public ChangeUserEmailCommandHandler(IUserRepository userRepository)
        {
            _userRepo = userRepository;
        }

        public async Task Handle(ChangeUserEmailCommand command)
        {
            if (await _userRepo.GetUserByIdAsync(command.Id) is Domain.User user)
            {
                if (command.NewEmail == user.Email) return;

                user.Email = command.NewEmail;
                await _userRepo.UpdateUserAsync(user);
            }
            else throw new KeyNotFoundException($"User with id {command.Id} was not found!");
        }
    }
}