using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ProjectsManagementStudio.Application.Persistence;

namespace ProjectsManagementStudio.Application.Features.Tasks.Commands.DeleteTask
{
    public class DeleteTaskCommandHandler
    {
        private readonly ITaskRepository _taskRepo;
        public DeleteTaskCommandHandler(ITaskRepository taskRepository)
        {
            _taskRepo = taskRepository;
        }

        public async Task Handle(DeleteTaskCommand command)
        {
            var task = await _taskRepo.GetTaskByIdAsync(command.TaskId);

            if (task is null)
                throw new KeyNotFoundException($"Task with id {command.TaskId} was not found.");

            await _taskRepo.DeleteTaskAsync(task);
        }
    }
}