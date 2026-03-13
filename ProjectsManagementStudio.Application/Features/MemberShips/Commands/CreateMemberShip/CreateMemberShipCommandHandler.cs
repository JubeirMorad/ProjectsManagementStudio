
using ProjectsManagementStudio.Application.Persistence;
using ProjectsManagementStudio.Domain;

namespace ProjectsManagementStudio.Application.Features.MemberShips.Commands
{
    public class CreateMemberShipCommandHandler
    {
        private readonly IMemberShipRepository _membershipRepo;
        public CreateMemberShipCommandHandler(IMemberShipRepository memberShipRepository)
        {
            _membershipRepo = memberShipRepository;   
        }

        public async Task Handle(CreateMemberShipCommand command)
        {
            MemberShip member = new (command.UserId, command.ProjectId, command.Role);
            await _membershipRepo.AddMemberShipAsync(member);

            
        }
    }
}