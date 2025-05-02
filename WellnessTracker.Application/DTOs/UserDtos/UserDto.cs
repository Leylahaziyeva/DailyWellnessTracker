namespace WellnessTracker.Application.DTOs.UserDtos;
public class UserDto
{
    public int Id { get; set; }
    public string? Username { get; set; }
    public DateTime RegisteredDate { get; set; }
}

public class UserCreateDto
{
    public string? Username { get; set; }
    public DateTime RegisteredDate { get; set; }
}

public class UserUpdateDto
{
    public int Id { get; set; }
    public string? Username { get; set; }
    public DateTime RegisteredDate { get; set; }
}