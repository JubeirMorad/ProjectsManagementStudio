using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ProjectsManagementStudio.Domain;

public class MemberShip
{
    [ForeignKey(nameof(User))]
    public Guid UserId { get; private set; }
    public User User { get; private set; }

    //
    [ForeignKey(nameof(Project))]
    public Guid ProjectId { get; private set; }
    public Project Project { get; private set; }

    //
    [Required]
    public ProjectRole Role { get; set; }

    //
    private MemberShip() { } // for EF Core

    public MemberShip(Guid userId, Guid projectId, ProjectRole role)
    {
        if (userId == Guid.Empty)
            throw new ArgumentException("User ID cannot be empty.", nameof(userId));

        if (projectId == Guid.Empty)
            throw new ArgumentException("Project ID cannot be empty.", nameof(projectId));

        UserId = userId;
        ProjectId = projectId;
        Role = role;

    }

    
}
