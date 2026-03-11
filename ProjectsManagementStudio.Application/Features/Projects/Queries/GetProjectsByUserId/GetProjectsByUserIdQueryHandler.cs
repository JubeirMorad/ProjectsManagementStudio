using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ProjectsManagementStudio.Application.Persistence;

namespace ProjectsManagementStudio.Application.Features.Projects.Queries
{
    public class GetProjectsByUserIdQueryHandler
    {
        private readonly IProjectRepository _projectRepo;

        public GetProjectsByUserIdQueryHandler(IProjectRepository projectRepository)
        {
            _projectRepo = projectRepository;
        }

        public async Task<List<ProjectResponse>?> Handle(GetProjectsByUserIdQuery query)
        {
            var projects = await _projectRepo.GetProjectsByUserIdAsync(query.UserId);

            return projects?.Select(
                p =>
                new ProjectResponse(p.Id, p.Name, p.Description, p.StartDate, p.EndDate, p.Status)
            ).ToList();
        }
    }
}