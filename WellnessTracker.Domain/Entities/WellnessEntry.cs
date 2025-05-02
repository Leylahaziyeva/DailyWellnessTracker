namespace WellnessTracker.Domain.Entities;
public class WellnessEntry : Entity
{
    public DateTime? Date { get; set; }
    public int UserId { get; set; }
    public User? User { get; set; }
    public required WellnessDetails Details { get; set; } // JSON mapped
}