using AutoMapper;
using RenterManager.Application.Features.Brands.Commands.AddEdit;
using RenterManager.Application.Features.Brands.Queries.GetAll;
using RenterManager.Application.Features.Brands.Queries.GetById;
using RenterManager.Domain.Entities.Catalog;

namespace RenterManager.Application.Mappings
{
    public class BrandProfile : Profile
    {
        public BrandProfile()
        {
            CreateMap<AddEditBrandCommand, Brand>().ReverseMap();
            CreateMap<GetBrandByIdResponse, Brand>().ReverseMap();
            CreateMap<GetAllBrandsResponse, Brand>().ReverseMap();
        }
    }
}