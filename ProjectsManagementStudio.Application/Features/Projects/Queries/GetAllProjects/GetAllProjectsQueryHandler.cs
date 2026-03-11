using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ProjectsManagementStudio.Application.Persistence;

namespace ProjectsManagementStudio.Application.Features.Projects.Queries
{
    public class GetAllProjectsQueryHandler
    {
        private readonly IProjectRepository _projectRepo;

        public GetAllProjectsQueryHandler(IProjectRepository projectRepository)
        {
            _projectRepo = projectRepository;
        }

        public async Task<List<ProjectResponse>?> Handle(GetAllProjectsQuery query)
        {
            return (await _projectRepo.GetAllProjectAsync())?
                .Select(
                p =>
                new ProjectResponse(p.Id, p.Name, p.Description, p.StartDate, p.EndDate, p.Status)
            ).ToList();
        }
    }
}