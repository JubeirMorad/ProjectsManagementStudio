using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ProjectsManagementStudio.Domain;
namespace ProjectsManagementStudio.Application.Features
{
    public record CreateMemberShipCommand
    (
        Guid UserId,
        Guid ProjectId,
        ProjectRole Role
    );

    public record UpdateMemberShipCommand
    (
        Guid Id,
        Guid UserId
    );

    public record DeleteMemberShipCommand
    (
        Guid ProjectId,
        Guid UserId
    );
}