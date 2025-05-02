namespace WellnessTracker.Application.DTOs.WellnessEntryDto;
public class WellnessEntryDto
{
    public int Id { get; set; }
    public DateTime Date { get; set; }
    public string? Mood { get; set; } 
    public int SleepHours { get; set; }
    public List<string> Activities { get; set; } = new();
    public string? Notes { get; set; }
    public int UserId { get; set; }
}

public class WellnessEntryCreateDto 
{
    public DateTime Date { get; set; }
    public string? Mood { get; set; }
    public int SleepHours { get; set; }
    public List<string> Activities { get; set; } = new();
    public string? Notes { get; set; }
    public int UserId { get; set; }
}

public class WellnessEntryUpdateDto
{
    public int Id { get; set; }
    public DateTime Date { get; set; }
    public string? Mood { get; set; }
    public int SleepHours { get; set; }
    public List<string> Activities { get; set; } = new();
    public string? Notes { get; set; }
    public int UserId { get; set; }
}