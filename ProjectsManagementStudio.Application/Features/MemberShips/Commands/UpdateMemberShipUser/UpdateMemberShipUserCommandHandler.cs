
using ProjectsManagementStudio.Application.Persistence;

namespace ProjectsManagementStudio.Application.Features.MemberShips.Commands
{
    public class UpdateMemberShipUserCommandHandler
    {
        private readonly IMemberShipRepository _membershipRepo;
        public UpdateMemberShipUserCommandHandler(IMemberShipRepository memberShipRepository)
        {
            _membershipRepo = memberShipRepository;
        }

        public async Task Handle(UpdateMemberShipRoleCommand command)
        {
            var member = await _membershipRepo.GetMemberShipByUserAndProjectAsync(command.UserId, command.ProjectId);

            if (member is null)
                throw new KeyNotFoundException($"Membership with user id {command.UserId} and project id {command.ProjectId}");


            if (member.Role == command.newRole)
                return;

            member.Role = command.newRole;
            await _membershipRepo.UpdateMemberShipAsync(member);
        }
    }
}