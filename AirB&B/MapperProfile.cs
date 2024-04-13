using AirB_B.Models.DTO;
using AirB_B.Models;
using AutoMapper;

namespace AirB_B
{
    public class MapperProfile : Profile
    {

        public MapperProfile()
        {
            CreateMap<Location, LocationDto>()
                .ForMember(d => d.LandlordAvatarURL, opt => opt.MapFrom(s => s.Landlord.Avatar.Url))
                .ForMember(d => d.ImageURL, opt => opt.MapFrom(s => s.Images.FirstOrDefault(img => img.IsCover).Url))
                .ForMember(d => d.SubTitle, opt => opt.MapFrom(s => s.SubTitle))
                .ForMember(d => d.Title, opt => opt.MapFrom(s => s.Title))
                .ForMember(d => d.Description, opt => opt.MapFrom(s => s.Description));
        }
    }
}
