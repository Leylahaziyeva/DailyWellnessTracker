using WellnessTracker.Domain.Entities;
using WellnessTracker.Domain.Interfaces;

namespace WellnessTracker.Infrastructure.EfCore.Repositories;
public class UserRepository : EfCoreRepository<User>, IUserRepository
{
    public UserRepository() : base()
    {

    }
}