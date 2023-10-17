using AutoMapper;
using RenterManager.Application.Requests.Identity;
using RenterManager.Application.Responses.Identity;

namespace RenterManager.Client.Infrastructure.Mappings
{
    public class RoleProfile : Profile
    {
        public RoleProfile()
        {
            CreateMap<PermissionResponse, PermissionRequest>().ReverseMap();
            CreateMap<RoleClaimResponse, RoleClaimRequest>().ReverseMap();
        }
    }
}