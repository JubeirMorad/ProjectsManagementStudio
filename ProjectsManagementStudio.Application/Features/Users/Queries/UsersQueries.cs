using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using ProjectsManagementStudio.Domain;

namespace ProjectsManagementStudio.Application.Features.Users.Queries
{ 
    public record GetUserByIdQuery
    (
        Guid Id
    );



    public record GetUserByEmailQuery
    (
        string Email
    );



    public record GetUsersByRoleQuery
    (
        UserRole Role
    );



    public record GetAllUsersQuery;
    
}