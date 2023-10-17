using AutoMapper;
using RenterManager.Infrastructure.Models.Identity;
using RenterManager.Application.Responses.Identity;

namespace RenterManager.Infrastructure.Mappings
{
    public class RoleProfile : Profile
    {
        public RoleProfile()
        {
            CreateMap<RoleResponse, BlazorHeroRole>().ReverseMap();
        }
    }
}