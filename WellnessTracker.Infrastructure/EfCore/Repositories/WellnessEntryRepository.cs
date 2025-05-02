using WellnessTracker.Domain.Entities;
using WellnessTracker.Domain.Interfaces;

namespace WellnessTracker.Infrastructure.EfCore.Repositories;
public class WellnessEntryRepository : EfCoreRepository<WellnessEntry>, IWellnessEntryRepository
{ 
    public WellnessEntryRepository() : base()
    { 

    }
}