
using ProjectsManagementStudio.Application.Features.Projects.Queries;
using ProjectsManagementStudio.Application.Persistence;
using ProjectsManagementStudio.Domain;

namespace ProjectsManagementStudio.Application.Features.Users.Queries
{
    public class GetUserByIdQueryHandler
    {
        private readonly IUserRepository _userRepository;
        public GetUserByIdQueryHandler(IUserRepository userRepository)
        {
            _userRepository = userRepository;
        }

        public async Task<UserResponse> Handle(GetUserByIdQuery query)
        {
            var user = await _userRepository.GetUserByIdAsync(query.Id);

            if (user is null)
            {
                throw new KeyNotFoundException($"User with Id {query.Id} not found.");
            }

            return new UserResponse
            (
                Id: user.Id,
                Name: user.Name,
                Email: user.Email,
                Role: user.Role
            );
        }

    }
}