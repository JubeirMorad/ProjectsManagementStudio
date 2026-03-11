using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ProjectsManagementStudio.Application.Persistence;

namespace ProjectsManagementStudio.Application.Features.Projects.Queries
{
    public class GetProjectByIdQueryHandler
    {
        private readonly IProjectRepository _projectRepo;
        public GetProjectByIdQueryHandler(IProjectRepository projectRepository)
        {
            _projectRepo = projectRepository;
        }

        public async Task<ProjectResponse> Handle(GetProjectByIdQuery query)
        {
            var project = await _projectRepo.GetProjectByIdAsync(query.Id);


            if (project is null)
                throw new KeyNotFoundException($"Project with id {query.Id} was not found.");
                

            return new(
                project.Id,
                project.Name,
                project.Description,
                project.StartDate,
                project.EndDate,
                project.Status
                );
        }
    }
}