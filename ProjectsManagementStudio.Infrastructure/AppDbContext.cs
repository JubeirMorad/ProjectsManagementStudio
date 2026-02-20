using Microsoft.EntityFrameworkCore;

namespace ProjectsManagementStudio.Infrastructure;

public class AppDbContext : DbContext
{
    public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
    {
    }

    public DbSet<Domain.User> Users { get; set; }
    public DbSet<Domain.Project> Projects { get; set; }
    public DbSet<Domain.TaskItem> TaskItems { get; set; }
    public DbSet<Domain.MemberShip> MemberShips { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);

        // Configure relationships and constraints if needed
        modelBuilder.Entity<Domain.MemberShip>()
            .HasKey(ms => new { ms.UserId, ms.ProjectId }); // Composite key for many-to-many relationship
    }
}
