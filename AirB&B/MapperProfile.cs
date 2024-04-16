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
            CreateMap<Location, PricedLocationDTO>()
                .ForMember(d => d.LandlordAvatarURL, opt => opt.MapFrom(s => s.Landlord.Avatar.Url))
                .ForMember(d => d.ImageURL, opt => opt.MapFrom(s => s.Images.FirstOrDefault(img => img.IsCover).Url))
                .ForMember(d => d.SubTitle, opt => opt.MapFrom(s => s.SubTitle))
                .ForMember(d => d.Title, opt => opt.MapFrom(s => s.Title))
                .ForMember(d => d.Description, opt => opt.MapFrom(s => s.Description))
                .ForMember(d => d.Id, opt => opt.MapFrom(s => s.Id))
                .ForMember(d => d.Type, opt => opt.MapFrom(s => s.Type))
                .ForMember(d => d.Price, opt => opt.MapFrom(s => s.PricePerDay));
            CreateMap<SearchDTO, Location>();
            CreateMap<Location, MaxPriceDTO>()
                .ForMember(d => d.Price, opt => opt.MapFrom(s => s.PricePerDay));
            CreateMap<Location, DetailsDTO>();
            CreateMap<Landlord, LandlordDTO>()
                .ForMember(d => d.name, opt => opt.MapFrom(s => s.FirstName + s.LastName))
                .ForMember(d => d.avatar, opt => opt.MapFrom(s => s.Avatar.Url));
            CreateMap<Image, ImageDTO>()
                .ForMember(d => d.URL, opt => opt.MapFrom(s => s.Url))
                .ForMember(d => d.IsCover, opt => opt.MapFrom(s => s.IsCover));
        }
    }
}
