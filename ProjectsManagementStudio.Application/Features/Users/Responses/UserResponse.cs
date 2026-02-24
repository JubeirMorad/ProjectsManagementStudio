
using ProjectsManagementStudio.Domain;

namespace ProjectsManagementStudio.Application.Features.Users.Responses
{
    public record UserResponse
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public UserRole Role { get; set; }
    }
}