using AutoMapper;
using RenterManager.Application.Features.DocumentTypes.Commands.AddEdit;
using RenterManager.Application.Features.DocumentTypes.Queries.GetAll;
using RenterManager.Application.Features.DocumentTypes.Queries.GetById;
using RenterManager.Domain.Entities.Misc;

namespace RenterManager.Application.Mappings
{
    public class DocumentTypeProfile : Profile
    {
        public DocumentTypeProfile()
        {
            CreateMap<AddEditDocumentTypeCommand, DocumentType>().ReverseMap();
            CreateMap<GetDocumentTypeByIdResponse, DocumentType>().ReverseMap();
            CreateMap<GetAllDocumentTypesResponse, DocumentType>().ReverseMap();
        }
    }
}