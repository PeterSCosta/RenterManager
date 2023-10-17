using AutoMapper;
using RenterManager.Application.Features.Documents.Commands.AddEdit;
using RenterManager.Application.Features.Documents.Queries.GetById;
using RenterManager.Domain.Entities.Misc;

namespace RenterManager.Application.Mappings
{
    public class DocumentProfile : Profile
    {
        public DocumentProfile()
        {
            CreateMap<AddEditDocumentCommand, Document>().ReverseMap();
            CreateMap<GetDocumentByIdResponse, Document>().ReverseMap();
        }
    }
}