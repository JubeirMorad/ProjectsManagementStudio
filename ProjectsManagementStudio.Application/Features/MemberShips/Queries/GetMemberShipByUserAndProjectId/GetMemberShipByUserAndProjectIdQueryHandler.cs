
using ProjectsManagementStudio.Application.Persistence;

namespace ProjectsManagementStudio.Application.Features.MemberShips.Queries
{
    public class GetMemberShipByUserAndProjectIdQueryHandler
    {
        private readonly IMemberShipRepository _membershipRepo;
        public GetMemberShipByUserAndProjectIdQueryHandler(IMemberShipRepository memberShipRepository)
        {
            _membershipRepo = memberShipRepository;
        }

        public async Task<MemberShipResponse> Handle(GetMemberShipByUserAndProjectIdQuery query)
        {
            var member = await _membershipRepo.GetMemberShipByUserAndProjectAsync(query.UserId, query.ProjectId);

            if (member is null)
                throw new KeyNotFoundException($"Membership with user id {query.UserId} and project id {query.ProjectId}");

            return new(member.UserId, member.ProjectId, member.Role);
        }
    }
}