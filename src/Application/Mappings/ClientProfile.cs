using AutoMapper;
using RenterManager.Application.Features.Clients.Commands.AddEdit;
using RenterManager.Domain.Entities.Catalog;

namespace RenterManager.Application.Mappings
{
    public class ClientProfile : Profile
    {
        public ClientProfile()
        {
            CreateMap<AddEditClientCommand, Client>().ReverseMap();
        }
    }
}