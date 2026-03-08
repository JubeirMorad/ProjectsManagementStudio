
using ProjectsManagementStudio.Application.Persistence;
using ProjectsManagementStudio.Domain;

namespace ProjectsManagementStudio.Application.Features.Users.Queries
{
    public class GetUserByIdQueryHandler
    {
        private readonly IUserRepository _userRepository;
        private readonly IProjectRepository _projectRepository;
        public GetUserByIdQueryHandler(IUserRepository userRepository, IProjectRepository projectRepository)
        {
            _userRepository = userRepository;
            _projectRepository = projectRepository;
        }

        public async Task<UserResponse> Handle(GetUserByIdQuery query, bool withTasks = false, bool withProjects = false)
        {
            var user = await _userRepository.GetUserByIdAsync(query.Id, withTasks);

            if (user is null)
            {
                throw new KeyNotFoundException($"User with Id {query.Id} not found.");
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