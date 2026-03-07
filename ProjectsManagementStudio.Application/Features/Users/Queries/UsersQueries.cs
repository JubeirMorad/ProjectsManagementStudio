using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using ProjectsManagementStudio.Domain;

namespace ProjectsManagementStudio.Application.Features.Users.Queries
{ 
    public record GetUserByIdQuery
    (
        [Required]
        Guid Id
    );



    public record GetUserByEmailQuery
    (
        [Required]
        [MaxLength(255, ErrorMessage =  "Email length cannot be > 255"), EmailAddress(ErrorMessage = "Invalid email format.")]
        string Email
    );



    public record GetUsersByRoleQuery
    (
        [Required]
        UserRole Role
    );



    public record GetAllUsersQuery;
    
}