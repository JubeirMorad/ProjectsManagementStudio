

using ProjectsManagementStudio.Application.Persistence;

namespace ProjectsManagementStudio.Application.Features.MemberShips.Queries
{
    public class GetMemberShipsByUserIdQueryHandler
    {
        private readonly IMemberShipRepository _membershipRepo;
        public GetMemberShipsByUserIdQueryHandler(IMemberShipRepository memberShipRepository)
        {
            _membershipRepo = memberShipRepository;
        }

        public async Task<List<MemberShipResponse>> Handle(GetMemberShipsByUserIdQuery query)
        {
            var members = await _membershipRepo.GetMemberShipsByUserIdAsync(query.UserId);

            if (members is null)
                return [];

            return members.Select(
                m =>
                new MemberShipResponse(m.UserId, m.ProjectId, m.Role)
            ).ToList();
        }
    }
}