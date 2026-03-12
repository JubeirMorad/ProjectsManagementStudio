using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;
using ProjectsManagementStudio.Application.Persistence;
using ProjectsManagementStudio.Domain;

namespace ProjectsManagementStudio.Application.Features.Tasks.Commands
{
    public class UpdateTaskStatusCommandHandler
    {
        private readonly ITaskRepository _tasktRepo;

        public UpdateTaskStatusCommandHandler(ITaskRepository projectRepository)
        {
            _tasktRepo = projectRepository;
        }

        public async Task Handle(UpdateTaskStatusCommand command)
        {
            var task = await _tasktRepo.GetTaskByIdAsync(command.TaskId);

            if (task is null)
                throw new KeyNotFoundException($"Task with id {command.TaskId} was not found.");


            if (command.NewStatus == TaskItemStatus.InProgress)
                task.SetStatusInProgress();

            else if (command.NewStatus == TaskItemStatus.Done)
                task.SetStatusDone();

            else throw new ArgumentException("Cannot set status ToDo");


            await _tasktRepo.UpdateTaskAsync(task);
        }
        
    }
}