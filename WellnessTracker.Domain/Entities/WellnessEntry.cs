using Microsoft.EntityFrameworkCore;

namespace WellnessTracker.Domain.Entities;
public class WellnessEntry : Entity
{
    public DateTime? Date { get; set; }
    public int UserId { get; set; }
    public User? User { get; set; }
    public required WellnessDetails Details { get; set; } // JSON mapped
}

[Owned]  // JSON mapped
public class WellnessDetails
{
    public required string Mood { get; set; }
    public double SleepHours { get; set; }
    public required List<string> Activities { get; set; }
    public required string Notes { get; set; }
}