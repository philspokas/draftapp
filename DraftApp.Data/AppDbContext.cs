using Microsoft.EntityFrameworkCore;
using DraftApp.Data.Models;

namespace DraftApp.Data;

[Coalesce]
public class AppDbContext : DbContext
{
    public DbSet<Widget> Widgets => Set<Widget>();
    public DbSet<Player> Players => Set<Player>();
    public DbSet<Team> Teams => Set<Team>();
    public DbSet<TourneyTeam> TourneyTeams => Set<TourneyTeam>();
    public DbSet<Pick> Picks => Set<Pick>();

    public AppDbContext() { }

    public AppDbContext(DbContextOptions options) : base(options) { }

    protected override void OnModelCreating(ModelBuilder builder)
    {
        base.OnModelCreating(builder);

        // Remove cascading deletes.
        foreach (var relationship in builder.Model.GetEntityTypes().SelectMany(e => e.GetForeignKeys()))
        {
            relationship.DeleteBehavior = DeleteBehavior.Restrict;
        }
    }
}
