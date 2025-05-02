using WellnessTracker.Application.DTOs.UserDtos;
using WellnessTracker.Domain.Entities;

namespace WellnessTracker.Application.Interfaces
{
    public interface IUserService : ICrudService<User, UserDto, UserCreateDto, UserUpdateDto>
    {
    }
}