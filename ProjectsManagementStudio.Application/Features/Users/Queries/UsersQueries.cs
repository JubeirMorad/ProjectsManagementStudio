using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using ProjectsManagementStudio.Domain;

namespace ProjectsManagementStudio.Application.Features
{
    public record GetUserByIdQuery
    (
        [Required]
        Guid Id
    );



    public record GetUserByEmailQuery
    (
        [Required]
        [MaxLength(255, ErrorMessage =  "Email length cannot be > 255")]
        string Email
    );



    public record GetUserByRoleQuery
    (
        [Required]
        UserRole Role
    );



    public record GetAllUsersQuery;
    
}