using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ProjectsManagementStudio.Application.Persistence;

namespace ProjectsManagementStudio.Application.Features.Tasks.Commands
{
    public class ChangeTaskTitleCommandHandler
    {
        private readonly ITaskRepository _taskRepo;
        public ChangeTaskTitleCommandHandler(ITaskRepository taskRepository)
        {
            _taskRepo = taskRepository;
        }

        public async Task Handle(ChangeTaskTitleCommand command)
        {
            var task = await _taskRepo.GetTaskByIdAsync(command.TaskId);

            if (task is null)
                throw new KeyNotFoundException($"Task with id {command.TaskId} was not found.");

            task.Title = command.NewTitle;

            await _taskRepo.UpdateTaskAsync(task);
        }
    }
}