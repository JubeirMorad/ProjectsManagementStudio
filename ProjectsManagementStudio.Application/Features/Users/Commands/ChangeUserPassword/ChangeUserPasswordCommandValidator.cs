using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FluentValidation;
using ProjectsManagementStudio.Domain;

namespace ProjectsManagementStudio.Application.Features.Users.Commands
{
    public class ChangeUserPasswordCommandValidator : AbstractValidator<ChangeUserPasswordCommand>
    {
        public ChangeUserPasswordCommandValidator()
        {
            RuleFor(user => user.Id)
                .NotNull().WithMessage("Id is required.");


            RuleFor(user => user.CurrentPassword)
                .Cascade(CascadeMode.Stop)
                .NotEmpty()
                .WithMessage("Password is Required.")
                .Length(8, 128)
                .WithMessage("Password length must be between 8 and 128 characters.");


            RuleFor(user => user.NewPassword )
                .Cascade(CascadeMode.Stop)
                .NotEmpty()
                .WithMessage("Password is Required.")
                .Length(8, 128)
                .WithMessage("Password length must be between 8 and 128 characters.");
        }
    }
}