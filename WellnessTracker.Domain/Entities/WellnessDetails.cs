using Microsoft.EntityFrameworkCore;

namespace WellnessTracker.Domain.Entities;

[Owned]  // JSON mapped
public class WellnessDetails
{
    public required string Mood { get; set; } 
    public double SleepHours { get; set; }
    public required List<string> Activities { get; set; } 
    public required string Notes { get; set; }
}