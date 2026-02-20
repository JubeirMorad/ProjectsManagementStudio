using System.ComponentModel.DataAnnotations;
using System.Linq.Expressions;

namespace ProjectsManagementStudio.Domain;

public class Project
{

    [Key]
    public Guid Id { get; private set; }


    [Required, MaxLength(50)]
    public string Name { get; private set; } = string.Empty ;


    [Required, MaxLength(250)]
    public string Description { get; private set; } = string.Empty ;


    [Required]
    public Guid CreatedByUserId { get; private set; }


    [Required]
    public DateTime StartDate { get; private set; } = DateTime.Now ;
    public DateTime? EndDate { get; private set; }


    //
    public ProjectStatus Status { get; private set; } = ProjectStatus.New;
    

    //
    public ICollection<MemberShip>? MemberShips { get; private set; } = new HashSet<MemberShip>();


    // 
    public ICollection<TaskItem>? Tasks { get; private set; } = new HashSet<TaskItem>();
     


    public Project(){} // for EF Core

    public Project(string name, string description,Guid createdByUserId, DateTime startDate)
    {
        Id = Guid.NewGuid();
        Name = name;
        Description = description;
        CreatedByUserId = createdByUserId;
        StartDate = startDate;
    }
}
