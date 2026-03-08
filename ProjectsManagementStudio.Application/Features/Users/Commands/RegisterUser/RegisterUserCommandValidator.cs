
using FluentValidation;
using ProjectsManagementStudio.Application.Features.Users.Commands;
using ProjectsManagementStudio.Application.Persistence;

namespace ProjectsManagementStudio.Application.Features.Users.Validators
{
    public class RegisterUserCommandValidator : AbstractValidator<RegisterUserCommand>
    {
        private readonly IUserRepository _userRepo;
        public RegisterUserCommandValidator(IUserRepository userRepository)
        {
            _userRepo = userRepository;


            RuleFor(user => user.Name)
                .Cascade(CascadeMode.Stop)
                .NotEmpty()
                .WithMessage("Name is required.")
                .MaximumLength(50)
                .WithMessage("Name length cannot be > 50.");


            RuleFor(user => user.Email)
                .Cascade(CascadeMode.Stop)
                .NotEmpty()
                .WithMessage("Email is required.")
                .EmailAddress()
                .WithMessage("Invalid email address format.")
                .MustAsync(IsUniqueEmail)
                .WithMessage("Email already exists.");


            RuleFor(user => user.Password)
                .Cascade(CascadeMode.Stop)
                .NotEmpty()
                .WithMessage("Password is Required.")
                .Length(8, 128)
                .WithMessage("Password length must be between 8 and 128 characters.");
        }


        private async Task<bool> IsUniqueEmail(string email, CancellationToken cancellationToken)
            => !await _userRepo.ExistsByEmailAsync(email);
    }
}