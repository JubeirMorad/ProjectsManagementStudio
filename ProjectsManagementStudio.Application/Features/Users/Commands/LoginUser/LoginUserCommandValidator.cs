using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;
using FluentValidation;
using ProjectsManagementStudio.Application.Features.Users.Commands;
using ProjectsManagementStudio.Application.Persistence;
using ProjectsManagementStudio.Domain;

namespace ProjectsManagementStudio.Application.Features.Users.Validators
{
    public class LoginUserCommandValidator : AbstractValidator<LoginUserCommand>
    {
        public LoginUserCommandValidator()
        {

            RuleFor(user => user.Email)
                .Cascade(CascadeMode.Stop)
                .NotEmpty()
                .WithMessage("Email is Required.")
                .EmailAddress()
                .WithMessage("Invalid email address format.")
                .MaximumLength(255)
                .WithMessage("Email length cannot be > 255.");

            RuleFor(user => user.Password)
                .Cascade(CascadeMode.Stop)
                .NotEmpty()
                .WithMessage("Password is Required.")
                .Length(8, 128)
                .WithMessage("Password length must be between 8 and 128 characters.");
        }

    }
}