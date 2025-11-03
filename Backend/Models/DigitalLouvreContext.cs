using Microsoft.EntityFrameworkCore;

namespace Backend.Models;

public class DigitalLouvreContext(DbContextOptions<DigitalLouvreContext> options) : DbContext(options)
{
    public DbSet<User> Users => Set<User>();

    public static void Configure(IApplicationBuilder app, IWebHostEnvironment env, DigitalLouvreContext context)
    {
        if (env.IsDevelopment())
            context.Database.EnsureCreated();
        else
            context.Database.Migrate();
    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.HasDefaultSchema("data");
        modelBuilder.Entity<User>();
    }
}