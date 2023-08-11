using Microsoft.EntityFrameworkCore;
using Skalaab_Exercise4.Entities;

namespace Skalaab_Exercise4.Persistence;

public class AppDbContext : DbContext
{
    public AppDbContext(DbContextOptions<AppDbContext> options)
    : base(options)
    { }

    public DbSet<LearnResource> LearnResources { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        //we can configure properties of entity
        base.OnModelCreating(modelBuilder);
    }
}

