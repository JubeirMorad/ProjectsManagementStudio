
using ProjectsManagementStudio.Application.Persistence;
using ProjectsManagementStudio.Domain;

namespace ProjectsManagementStudio.Application.Features.Tasks.Commands
{
    public class ChangeUserAssignmentCommandHandler
    {
        private readonly ITaskRepository _taskRepo;
        private readonly IUserRepository _userRepo;
        public ChangeUserAssignmentCommandHandler(ITaskRepository taskRepository, IUserRepository userRepository)
        {
            _taskRepo = taskRepository;
            _userRepo = userRepository;
        }

        public async Task Handle(ChangeUserAssignmentCommand command)
        {
            var task = await _taskRepo.GetTaskByIdAsync(command.TaskId);
            User? user;

            if (task is null)
                throw new KeyNotFoundException($"Task with id {command.TaskId} was not found.");


            if (command.NewAssignedToUserId is not null)
            {
                user = await _userRepo.GetUserByIdAsync(command.NewAssignedToUserId.Value);

                if (user is null)
                    throw new KeyNotFoundException($"User with id {command.NewAssignedToUserId} was not found.");
            }
        
        
            if (task.AssignedToUserId != command.NewAssignedToUserId)
            {
                task.AssignedToUserId = command.NewAssignedToUserId;
                await _taskRepo.UpdateTaskAsync(task);
            }

           

        }
    }
}