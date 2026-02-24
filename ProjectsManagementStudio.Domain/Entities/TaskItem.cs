using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ProjectsManagementStudio.Domain;

public class TaskItem
{
    [Key]
    public Guid Id { get; private set; }


    [Required, MaxLength(50 , ErrorMessage = "Name length cannot be > 50.")]
    public string Title { get; private set; }


    [Required, MaxLength(300, ErrorMessage = "Description length cannot be > 300.")]
    public string Description { get; private set; }


    //
    [Required]
    public TaskItemStatus Status { get; private set; }


    //
    [ForeignKey(nameof(AssignedToUser))]
    public Guid? AssignedToUserId { get; private set; }
    public User? AssignedToUser { get; private set; }


    //
    [ForeignKey(nameof(Project))]
    public Guid ProjectId { get; private set; }
    public Project Project { get; private set; }


    private TaskItem() { } // for EF Core


    public TaskItem(string title, string description, Guid assignedToUserId, Guid projectId)
    {
        if (string.IsNullOrWhiteSpace(title))
            throw new ArgumentException("Title cannot be empty.", nameof(title));

        if (string.IsNullOrWhiteSpace(description))
            throw new ArgumentException("Description cannot be empty.", nameof(description));

        if (assignedToUserId == Guid.Empty)
            throw new ArgumentException("AssignedToUserId cannot be empty.", nameof(assignedToUserId));

        if (projectId == Guid.Empty)
            throw new ArgumentException("ProjectId cannot be empty.", nameof(projectId));


        Id = Guid.NewGuid();
        Title = title;
        Description = description;
        AssignedToUserId = assignedToUserId;
        ProjectId = projectId;
        Status = TaskItemStatus.ToDo;

    }


}
