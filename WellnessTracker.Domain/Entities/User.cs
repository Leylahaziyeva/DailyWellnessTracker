namespace WellnessTracker.Domain.Entities;
public class User : Entity
{
    public required string UserName { get; set; }
    public DateTime RegisteredDate { get; set; }
    public List<WellnessEntry> Entries { get; set; } = new();
}