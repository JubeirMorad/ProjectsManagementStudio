
using System.ComponentModel.DataAnnotations;
using System.Net.Mail;
using ProjectsManagementStudio.Domain;

namespace ProjectsManagementStudio.Application.Features.Users.Commands
{

    public record LoginUserCommand(
        
        string Email,
        string Password
    );

    public record LogoutUserCommand();


    public record RegisterUserCommand
    (
        string Name,
        string Email,
        string Password
    );



    public record ChangeUserNameCommand
    (
        Guid Id,

        string NewName
    );



    public record DeleteUserCommand
    (
        Guid Id
    );



    public record ChangeUserRoleCommand
    (
        Guid Id,
        UserRole NewRole
    );



    public record ChangeUserPasswordCommand
    (
        Guid Id,

        string CurrentPassword,

        string NewPassword
    );



    public record ChangeUserEmailCommand
    (
        Guid Id,
        string NewEmail
    );

    
    
    
}