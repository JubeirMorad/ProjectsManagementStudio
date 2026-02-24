using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using ProjectsManagementStudio.Domain;

namespace ProjectsManagementStudio.Application.Features.Users
{

    public record LoginUserCommand(
        [MaxLength(255, ErrorMessage =  "Email length cannot be > 255")]
        string Email,

        [StringLength(255, MinimumLength = 6, ErrorMessage = "Password length must be between 6 and 255 characters.")]
        string Password
    );



    public record RegirsterUserCommand
    (
        [MaxLength(50, ErrorMessage = "Name length cannot be > 50")]
        string Name,

        [MaxLength(255, ErrorMessage =  "Email length cannot be > 255")]
        string Email,

        [MaxLength(255)]
        string PasswordHash
    );



    public record ChangeUserNameCommand
    (
        [Required]
        Guid Id,

        [MaxLength(50, ErrorMessage = "Name length cannot be > 50")]
        string Name
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

        [StringLength(255, MinimumLength = 6, ErrorMessage = "Password length must be between 6 and 255 characters.")]
        string NewPassword
    );



    public record ChangeUserEmailCommand
    (
        [Required]
        Guid Id,

        [MaxLength(255, ErrorMessage =  "Email length cannot be > 255")]
        string NewEmail
    );


    
    
}