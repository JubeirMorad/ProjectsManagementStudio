
using ProjectsManagementStudio.Application.Persistence;

namespace ProjectsManagementStudio.Application.Features.MemberShips.Commands
{
    public class DeleteMemberShipCommandHandler
    {
        private readonly IMemberShipRepository _membershipRepo;
        public DeleteMemberShipCommandHandler(IMemberShipRepository memberShipRepository)
        {
            _membershipRepo = memberShipRepository;
        }

        public async Task Handle(DeleteMemberShipCommand command)
        {
            var member = await _membershipRepo.GetMemberShipByUserAndProjectAsync(command.UserId, command.ProjectId);
        
            if (member is null)
                throw new KeyNotFoundException($"Membership with user id {command.UserId} and project id {command.ProjectId}");

            await _membershipRepo.DeleteMemberShipAsync(member);
        }
    }
}