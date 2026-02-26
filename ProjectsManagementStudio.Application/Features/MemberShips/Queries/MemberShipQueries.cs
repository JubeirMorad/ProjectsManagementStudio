using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProjectsManagementStudio.Application.Features
{
    public record GetMemberShipByIdQuery
    (
        Guid Id
    );

    public record GetMemberShipsByProjectIdQuery
    (
        Guid ProjectId
    );

     public record GetMemberShipsByUserIdQuery
    (
        Guid UserId
    );
}