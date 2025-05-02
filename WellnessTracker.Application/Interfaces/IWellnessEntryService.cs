using WellnessTracker.Application.DTOs.WellnessEntryDto;
using WellnessTracker.Domain.Entities;

namespace WellnessTracker.Application.Interfaces;
public interface IWellnessEntryService : ICrudService<WellnessEntry, WellnessEntryDto, WellnessEntryCreateDto, WellnessEntryUpdateDto>
{
}