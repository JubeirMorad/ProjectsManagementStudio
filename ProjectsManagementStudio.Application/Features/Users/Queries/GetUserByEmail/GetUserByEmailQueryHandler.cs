
using ProjectsManagementStudio.Application.Persistence;
using ProjectsManagementStudio.Domain;
namespace ProjectsManagementStudio.Application.Features.Users.Queries
{
    public class GetUserByEmailQueryHandler
    {
        private readonly IUserRepository _userRepository;
        public GetUserByEmailQueryHandler(IUserRepository userRepository)
        {
            _userRepository = userRepository;
        }


        public async Task<UserResponse> Handle(GetUserByEmailQuery query)
        {
            var user = await _userRepository.GetUserByEmailAsync(query.Email);

            if (user is null)
            {
                throw new KeyNotFoundException($"User with Email {query.Email} not found.");
            }

            return new 
            (
                Id: user.Id,
                Name: user.Name,
                Email: user.Email,
                Role: user.Role
            );
        }

    }

}