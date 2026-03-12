using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ProjectsManagementStudio.Application.Persistence;
using ProjectsManagementStudio.Domain;

namespace ProjectsManagementStudio.Application.Features.Tasks.Commands
{
    public class CreateTaskCommandHandler
    {
        private readonly ITaskRepository _taskRepo;
        public CreateTaskCommandHandler(ITaskRepository taskRepository)
        {
            _taskRepo = taskRepository;
        }

        public async Task<Guid> Handle(CreateTaskCommand command)
        {
            TaskItem task = new(command.Title, command.Description, command.AssignedToUserId, command.ProjectId);
            return await _taskRepo.AddTaskAsync(task);
        }
    }
}