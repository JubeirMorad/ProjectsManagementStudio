using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ProjectsManagementStudio.Application.Persistence;

namespace ProjectsManagementStudio.Application.Features.Users.Queries
{
    public class GetAllUsersQueryHandler
    {
        private readonly IUserRepository _userRepository;
        public GetAllUsersQueryHandler(IUserRepository userRepository)
        {
            _userRepository = userRepository;
        }

        public async Task<List<UserResponse>> Handle(GetAllUsersQuery query)
        {
            var users = await _userRepository.GetAllUsersAsync();

            if (users == null) return [];
            
            return users.Select(u => new UserResponse(
                u.Id,
                u.Name,
                u.Email,
                u.Role
            )).ToList();
        }
    }
}