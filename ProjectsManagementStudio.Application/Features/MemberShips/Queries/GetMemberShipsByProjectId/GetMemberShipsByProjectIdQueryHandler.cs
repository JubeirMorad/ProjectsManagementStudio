
using ProjectsManagementStudio.Application.Persistence;

namespace ProjectsManagementStudio.Application.Features.MemberShips.Queries
{
    public class GetMemberShipsByProjectIdQueryHandler
    {
        private readonly IMemberShipRepository _membershipRepo;

        public GetMemberShipsByProjectIdQueryHandler(IMemberShipRepository memberShipRepository)
        {
            _membershipRepo = memberShipRepository;
        }

        public async Task<List<MemberShipResponse>> Handle(GetMemberShipsByProjectIdQuery query)
        {
            var members = await _membershipRepo.GetMemberShipsByProjectIdAsync(query.ProjectId);

            if (members is null)
                return [];

            return members.Select(
                m => 
                new MemberShipResponse(m.UserId, m.ProjectId, m.Role)
            ).ToList();

        }
    }
}