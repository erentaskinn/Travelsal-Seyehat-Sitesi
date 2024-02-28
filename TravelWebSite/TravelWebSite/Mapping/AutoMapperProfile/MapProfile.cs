using AutoMapper;
using Travels_EntityLayer.Concrete;
using TravelsalDTOLayer.DTO_s.AnnouncementDTOs;
using TravelsalDTOLayer.DTO_s.AppUserDTOs;
using TravelsalDTOLayer.DTO_s.ContactDTOs;

namespace TravelWebSite.Mapping.AutoMapperProfile
{
    public class MapProfile:Profile
    {
        public MapProfile()
        {
            CreateMap<AnnouncementAddDTO, Announcement>();
            CreateMap<Announcement,AnnouncementAddDTO>();

            CreateMap<AppUserRegisterDTOs, AppUser>();
            CreateMap<AppUser, AppUserRegisterDTOs>();

            CreateMap<AppUserLoginDTO, AppUser>();
            CreateMap<AppUser, AppUserLoginDTO>();

            CreateMap<AnnouncementListDTO, Announcement>();
            CreateMap<Announcement, AnnouncementListDTO>();

            CreateMap<AnnouncementUptadeDto,Announcement>();
            CreateMap<Announcement, AnnouncementUptadeDto>();

            CreateMap<SendMessageDto,ContactUs>().ReverseMap();
            

        }
    }
}
