using WellnessTracker.Application.DTOs.UserDtos;
using WellnessTracker.Application.Interfaces;
using WellnessTracker.Domain.Entities;

namespace WellnessTracker.Application.Services
{
    public class UserManager : CrudManager<User, UserDto, UserCreateDto, UserUpdateDto>, IUserService
    {
    }
}