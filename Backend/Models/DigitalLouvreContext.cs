using Microsoft.EntityFrameworkCore;

namespace Backend.Models;

public class DigitalLouvreContext(DbContextOptions<DigitalLouvreContext> options) : DbContext(options)
{
    public DbSet<User> Users => Set<User>();

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder
            .Entity<User>();
    }
}