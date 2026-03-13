using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ProjectsManagementStudio.Domain;
namespace ProjectsManagementStudio.Application.Features
{
    public record CreateMemberShipCommand
    (
        Guid ProjectId,
        Guid UserId,
        ProjectRole Role
    );


    public record UpdateMemberShipRoleCommand
    (
        Guid ProjectId,
        Guid UserId,
        ProjectRole newRole
    );

    public record DeleteMemberShipCommand
    (
        Guid ProjectId,
        Guid UserId
    );

}