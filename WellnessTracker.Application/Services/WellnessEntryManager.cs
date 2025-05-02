using WellnessTracker.Application.DTOs.WellnessEntryDto;
using WellnessTracker.Application.Interfaces;
using WellnessTracker.Domain.Entities;

namespace WellnessTracker.Application.Services
{
    public class WellnessEntryManager : CrudManager<WellnessEntry, WellnessEntryDto, WellnessEntryCreateDto, WellnessEntryUpdateDto>, IWellnessEntryService
    {
    }
}