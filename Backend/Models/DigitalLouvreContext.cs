using Microsoft.EntityFrameworkCore;

namespace Backend.Models;

public class DigitalLouvreContext : DbContext
{
    public DbSet<User> Users { get; set; }

    public DigitalLouvreContext(DbContextOptions<DigitalLouvreContext> options):base(options)
    {
        
    }
}