using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FluentValidation;

namespace ProjectsManagementStudio.Application.Features.Tasks.Commands
{
    public class UpdateTaskStatusCommandValidator : AbstractValidator<UpdateTaskStatusCommand>
    {
        public UpdateTaskStatusCommandValidator()
        {
            RuleFor(c => c.TaskId)
                .NotNull()
                .WithMessage("Task id is required.");

            RuleFor(c => c.NewStatus)
                .NotNull()
                .WithMessage("Task status id is required.");
        }
    }
}