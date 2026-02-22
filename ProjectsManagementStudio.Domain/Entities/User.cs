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

    public User(string name, string email, string password)
    {
        if (string.IsNullOrWhiteSpace(name))
            throw new ArgumentException("Name cannot be empty.", nameof(name));

        if (string.IsNullOrWhiteSpace(email))
            throw new ArgumentException("Email cannot be empty.", nameof(email));

        if (string.IsNullOrWhiteSpace(password))
            throw new ArgumentException("Password hash cannot be empty.", nameof(password));

        Id = Guid.NewGuid();
        Name = name;
        Email = email;
        PasswordHash = HashPassword(password);
    }

    //
    public void SetPasswordHash(string newPasswordHash)
    {
        if (string.IsNullOrWhiteSpace(newPasswordHash))
            throw new ArgumentException("New password hash cannot be empty.", nameof(newPasswordHash));

        PasswordHash = newPasswordHash;
    }

    private string HashPassword(string password)
    {
        return password;
    }

}
