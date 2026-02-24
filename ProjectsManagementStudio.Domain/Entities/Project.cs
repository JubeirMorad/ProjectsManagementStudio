using System.ComponentModel.DataAnnotations;

namespace ProjectsManagementStudio.Domain;

public class Project
{

    [Key]
    public Guid Id { get; private set; }


    [Required, MaxLength(50)]
    public string Name { get; private set; }


    [Required, MaxLength(300)]
    public string Description { get; private set; }

    //
    [Required]
    public DateTime StartDate { get; private set; }
    public DateTime? EndDate { get; private set; }


    //
    public ProjectStatus Status { get; private set; }


    //
    public ICollection<MemberShip>? MemberShips { get; private set; } = new HashSet<MemberShip>();


    // 
    public ICollection<TaskItem>? Tasks { get; private set; } = new HashSet<TaskItem>();



    private Project() { } // for EF Core

    public Project(string name, string description)
    {
        if (string.IsNullOrWhiteSpace(name))
            throw new ArgumentException("Name cannot be empty.", nameof(name));

        if (string.IsNullOrWhiteSpace(description))
            throw new ArgumentException("Description cannot be empty.", nameof(description));

        this.Id = Guid.NewGuid();
        this.Name = name;
        this.Description = description;
        this.StartDate = DateTime.Now;
        this.Status = ProjectStatus.New;
    }


}
