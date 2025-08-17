using Microsoft.EntityFrameworkCore;

namespace Backend.Models;

public class DigitalLouvreContext(DbContextOptions<DigitalLouvreContext> options) : DbContext(options)
{
    public DbSet<User> Users => Set<User>();

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder
            .Entity<User>()
            .Property(e => e.Id).UseIdentityAlwaysColumn();

        modelBuilder.Entity<User>().HasData(
            new User
            {
                FistName = "Test",
                LastName = "Test",
                Password = "test",
                Token = "test",
                TokenExpiry = DateTime.Parse("2025.08.03").ToUniversalTime(),
                UserId = Guid.Parse("c0387ac6-6e34-4a74-b705-5c2ad6f59727")
            },
            new User
            {
                FistName = "Test2",
                LastName = "Test2",
                Password = "test2",
                Token = "test2",
                TokenExpiry = DateTime.Parse("2025.08.03").ToUniversalTime(),
                UserId = Guid.Parse("c0377ac6-6e34-4a74-b705-5c2ad6f59727")
            });
    }
    
}