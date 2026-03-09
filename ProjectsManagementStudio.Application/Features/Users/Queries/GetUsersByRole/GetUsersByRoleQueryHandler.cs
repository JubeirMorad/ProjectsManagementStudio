using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ProjectsManagementStudio.Application.Features.Users.Queries;
using ProjectsManagementStudio.Application.Persistence;

namespace ProjectsManagementStudio.Application.Features.Users.Commands
{
    public class GetUsersByRoleQueryHandler
    {
        private readonly IUserRepository _userRepository;
        public GetUsersByRoleQueryHandler(IUserRepository userRepository)
        {
            _userRepository = userRepository;
        }

        public async Task<List<UserResponse>?> Handle(GetUsersByRoleQuery query)
        {
            var users = await _userRepository.GetUsersByRoleAsync(query.Role);
            
            if (users == null) return null;
            
            return users.Select(u => new UserResponse(
                u.Id,
                u.Name,
                u.Email,
                u.Role
            )).ToList();
        }
    }
}