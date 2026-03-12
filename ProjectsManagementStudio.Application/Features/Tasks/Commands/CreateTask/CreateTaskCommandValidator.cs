using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FluentValidation;
using ProjectsManagementStudio.Application.Persistence;

namespace ProjectsManagementStudio.Application.Features.Tasks.Commands
{
    public class CreateTaskCommandValidator : AbstractValidator<CreateTaskCommand>
    {
        private readonly IUserRepository _userRepo;
        private readonly IProjectRepository _projectRepo;
        public CreateTaskCommandValidator(IUserRepository userRepository, IProjectRepository projectRepository)
        {
            _userRepo = userRepository;
            _projectRepo = projectRepository;


            RuleFor(c => c.Title)
                .Cascade(CascadeMode.Stop)
                .NotEmpty()
                .WithMessage("Tite is required.")
                .MaximumLength(50)
                .WithMessage("Title length cannot be > 50.");


            RuleFor(c => c.Description)
                .Cascade(CascadeMode.Stop)
                .NotEmpty()
                .WithMessage("Description is required.")
                .MaximumLength(300)
                .WithMessage("Description lenght cannot be > 300");


            RuleFor(c => c.AssignedToUserId)
                .MustAsync(UserNotExist)
                .WithMessage($"User with this id was not found.");


            RuleFor(c => c.ProjectId)
                .Cascade(CascadeMode.Stop)
                .NotNull()
                .WithMessage("Project id is required.")
                .MustAsync(ProjectNotExist)
                .WithMessage($"Project with this id was not found.");
        }

        private async Task<bool> UserNotExist(Guid? userId, CancellationToken cancellationToken)
        {
            if (userId == null) return true;

            return await _userRepo.GetUserByIdAsync(userId.Value) is not null;
        }
        
        private async Task<bool> ProjectNotExist(Guid ProjectId, CancellationToken cancellationToken)
        {
            return await _projectRepo.GetProjectByIdAsync(ProjectId) is not null; 
        }
    }
}