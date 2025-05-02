using AutoMapper;
using WellnessTracker.Application.DTOs.UserDtos;
using WellnessTracker.Application.DTOs.WellnessEntryDto;
using WellnessTracker.Domain.Entities;

namespace WellnessTracker.Application.AutoMapping;

public class MappingProfile : Profile
{
    public MappingProfile()
    {
        CreateMap<User, UserDto>().ReverseMap();
        CreateMap<User, UserCreateDto>().ReverseMap();
        CreateMap<User, UserUpdateDto>().ReverseMap();

        CreateMap<WellnessEntry, WellnessEntryDto>()
            .ForMember(x => x.Mood, opt => opt.MapFrom(src => src.Details.Mood))
            .ForMember(x => x.SleepHours, opt => opt.MapFrom(src => src.Details.SleepHours))
            .ForMember(x => x.Activities, opt => opt.MapFrom(src => src.Details.Activities))
            .ForMember(x => x.Notes, opt => opt.MapFrom(src => src.Details.Notes))
            .ReverseMap();

        CreateMap<WellnessEntryCreateDto, WellnessEntry>()
            .ForMember(x => x.Details, opt => opt.MapFrom(src => new WellnessDetails
            {
                Mood = src.Mood,
                SleepHours = src.SleepHours,
                Activities = src.Activities,
                Notes = src.Notes
            }));

        CreateMap<WellnessEntryUpdateDto, WellnessEntry>()
            .ForMember(x => x.Details, opt => opt.MapFrom(src => new WellnessDetails
            {
                Mood = src.Mood,
                SleepHours = src.SleepHours,
                Activities = src.Activities,
                Notes = src.Notes
            }));
    }
}