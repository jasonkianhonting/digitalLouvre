using Microsoft.EntityFrameworkCore;

namespace Backend.Models;

public class DigitalLouvreContext : DbContext
{
    public DbSet<User> Users { get; set; }

    public DigitalLouvreContext(DbContextOptions<DigitalLouvreContext> options):base(options)
    {
        
    }
    
    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder
            .Entity<User>()
            .Property(e => e.Id).UseIdentityAlwaysColumn();
    }

}