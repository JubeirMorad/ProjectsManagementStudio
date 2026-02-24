using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ProjectsManagementStudio.Domain;

public class User
{

    [Key]
    public Guid Id { get; private set; }


    [Required , MaxLength(50)]
    public string Name { get; set; }


    [Required, MaxLength(255)]
    public string Email { get; set; }


    [Required]
    public UserRole Role { get; private set; } = UserRole.User;


    [Required, Column(TypeName = "nvarchar(255)")]
    public string PasswordHash { get; private set; }

    //
    public ICollection<TaskItem>? AssignedTasks { get; private set; } = new HashSet<TaskItem>();

    //
    public ICollection<MemberShip>? MemberShips { get; private set; } = new HashSet<MemberShip>();

    private User() { } // for EF Core

    public User(string name, string email, string passwordHash)
    {
        if (string.IsNullOrWhiteSpace(name))
            throw new ArgumentException("Name cannot be empty.", nameof(name));

        if (string.IsNullOrWhiteSpace(email))
            throw new ArgumentException("Email cannot be empty.", nameof(email));

        if (string.IsNullOrWhiteSpace(passwordHash))
            throw new ArgumentException("Password hash cannot be empty.", nameof(passwordHash));

        Id = Guid.NewGuid();
        Name = name;
        Email = email;
        PasswordHash = passwordHash;
    }

}
