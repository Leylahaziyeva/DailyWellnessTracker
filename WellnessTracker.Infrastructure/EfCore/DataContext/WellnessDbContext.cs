using Microsoft.EntityFrameworkCore;
using WellnessTracker.Domain.Entities;

namespace WellnessTracker.Infrastructure.EfCore.DataContext;
public class WellnessDbContext : DbContext
{
    public DbSet<User> Users { get; set; } 
    public DbSet<WellnessEntry> WellnessEntries { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseSqlServer(@"Server=DESKTOP-JIHG98N\SQLEXPRESS;Database=DailyWellnessTracker;Trusted_Connection=True;TrustServerCertificate=True");
    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<WellnessEntry>().OwnsOne(e => e.Details, b =>
        {
            b.ToJson();
        });
    }
}