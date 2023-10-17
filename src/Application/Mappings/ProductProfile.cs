using AutoMapper;
using RenterManager.Application.Features.Products.Commands.AddEdit;
using RenterManager.Domain.Entities.Catalog;

namespace RenterManager.Application.Mappings
{
    public class ProductProfile : Profile
    {
        public ProductProfile()
        {
            CreateMap<AddEditProductCommand, Product>().ReverseMap();
        }
    }
}