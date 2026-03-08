using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FluentValidation;
using ProjectsManagementStudio.Application.Persistence;

namespace ProjectsManagementStudio.Application.Features.Users.Commands
{
    public class ChangeUserEmailCommandValidation : AbstractValidator<ChangeUserEmailCommand>
    {
        private readonly IUserRepository _userRepo;
        public ChangeUserEmailCommandValidation(IUserRepository userRepository)
        {
            _userRepo = userRepository;


            RuleFor(user => user.Id)
                .NotNull().WithMessage("Id is required.");

            RuleFor(user => user.NewEmail)
                .Cascade(CascadeMode.Stop)
                .NotEmpty()
                .WithMessage("Email is required.")
                .EmailAddress()
                .WithMessage("Invalid email address format.")
                .MustAsync(IsUniqueEmail)
                .WithMessage("Email already exists.");
        }

        
        private async Task<bool> IsUniqueEmail(string email, CancellationToken cancellationToken)
            => !await _userRepo.ExistsByEmailAsync(email);
    }
}