using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ProjectsManagementStudio.Application.Persistence;
using ProjectsManagementStudio.Domain;

namespace ProjectsManagementStudio.Application.Features.Projects.Queries
{
    public class GetProjectsByStatusQueryHandler
    {
        private readonly IProjectRepository _projectRepo;

        public GetProjectsByStatusQueryHandler(IProjectRepository projectRepository)
        {
            _projectRepo = projectRepository;
        }

        public async Task<List<ProjectResponse>?> Handle(GetProjectsByStatusQuery query)
        {
            var projects = await _projectRepo.GetProjectsByStatusAsync(query.Status);

            return projects?.Select(
                p => 
                new ProjectResponse (p.Id, p.Name, p.Description, p.StartDate, p.EndDate, p.Status)
            ).ToList();
        }
    }
}