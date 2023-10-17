using AutoMapper;
using RenterManager.Infrastructure.Models.Audit;
using RenterManager.Application.Responses.Audit;

namespace RenterManager.Infrastructure.Mappings
{
    public class AuditProfile : Profile
    {
        public AuditProfile()
        {
            CreateMap<AuditResponse, Audit>().ReverseMap();
        }
    }
}