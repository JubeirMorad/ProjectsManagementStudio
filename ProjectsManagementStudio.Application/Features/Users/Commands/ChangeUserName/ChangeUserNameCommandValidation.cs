
using FluentValidation;

namespace ProjectsManagementStudio.Application.Features.Users.Commands
{
    public class ChangeUserNameCommandValidation : AbstractValidator<ChangeUserNameCommand>
    {
        public ChangeUserNameCommandValidation()
        {
            
            RuleFor(user => user.Id)
                .NotNull()
                .WithMessage("Id is required.");


            RuleFor(user => user.NewName)
                .Cascade(CascadeMode.Stop)
                .NotEmpty()
                .WithMessage("Name is required.")
                .MaximumLength(50)
                .WithMessage("Name length cannot be > 50.");
        }
    }
}