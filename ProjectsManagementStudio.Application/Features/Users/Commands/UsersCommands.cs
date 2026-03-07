
using System.ComponentModel.DataAnnotations;
using System.Net.Mail;
using ProjectsManagementStudio.Domain;

namespace ProjectsManagementStudio.Application.Features
{

    public record LoginUserCommand(
        [MaxLength(255, ErrorMessage =  "Email length cannot be > 255")]
        string Email,

        [StringLength(10, MinimumLength = 6, ErrorMessage = "Password length must be between 6 and 10 characters.")]
        string Password
    );

    public record LogoutUserCommand();


    public record RegisterUserCommand
    (
        [MaxLength(50, ErrorMessage = "Name length cannot be > 50")]
        string Name,

        [MaxLength(255, ErrorMessage = "Email length cannot be > 255"), EmailAddress(ErrorMessage = "Invalid email format.")]
        string Email,

        [MaxLength(10,ErrorMessage = "Password length must be between 6 and 10 characters.")]
        string Password
    );



    public record ChangeUserNameCommand
    (
        [Required]
        Guid Id,

        [MaxLength(50, ErrorMessage = "Name length cannot be > 50")]
        string NewName
    );



    public record DeleteUserCommand
    (
        [Required]
        Guid Id
    );



    public record ChangeUserRoleCommand
    (
        [Required]
        Guid Id,

        [Required]
        UserRole NewRole
    );



    public record ChangeUserPasswordCommand
    (
        [Required]
        Guid Id,

        [Required]
        string CurrentPassword,

        [StringLength(10, MinimumLength = 6, ErrorMessage = "Password length must be between 6 and 10 characters.")]
        string NewPassword
    );



    public record ChangeUserEmailCommand
    (
        [Required]
        Guid Id,

        [MaxLength(255, ErrorMessage =  "Email length cannot be > 255"),EmailAddress(ErrorMessage = "Invalid email format.")]
        string NewEmail
    );

    
    
    
}