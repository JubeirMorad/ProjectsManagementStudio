
using ProjectsManagementStudio.Application.Persistence;
using ProjectsManagementStudio.Domain;
namespace ProjectsManagementStudio.Application.Features.Users.Queries
{
    public class GetUserByEmailQueryHandler
    {
        private readonly IUserRepository _userRepository;
        private readonly IProjectRepository _projectRepository;
        public GetUserByEmailQueryHandler(IUserRepository userRepository, IProjectRepository projectRepository)
        {
            _userRepository = userRepository;
            _projectRepository = projectRepository;
        }


        public async Task<UserResponse> Handle(GetUserByEmailQuery query, bool withTasks = false, bool withProjects = false)
        {
            var user = await _userRepository.GetUserByEmailAsync(query.Email, withTasks);

            if (user is null)
            {
                throw new KeyNotFoundException($"User with Email {query.Email} not found.");
            }


            IEnumerable<Project>? projects = null;
            if (withProjects)
            {
                projects = await _projectRepository.GetProjectsByUserIdAsync(user.Id);
            }

            return new UserResponse
            (
                Id: user.Id,
                Name: user.Name,
                Email: user.Email,
                Role: user.Role,
                Tasks: user.AssignedTasks ,
                Projects: projects
            );
        }

    }

}