using System.ComponentModel.DataAnnotations;

namespace ProjectsManagementStudio.Application;

public record NewUserDTO
{
    [MaxLength(50, ErrorMessage = "Email length cannot be > 50.")]
    public required string Name { get; set; }

    [EmailAddress(ErrorMessage = "Email Adress is not valid."), MaxLength(255, ErrorMessage = "Email length cannot be > 255.")]
    public required string Email { get; set; }
    
    [StringLength(100, MinimumLength = 10, ErrorMessage = "Password length must be between 10 and 100.")]
    public required string Password { get; set; }

}