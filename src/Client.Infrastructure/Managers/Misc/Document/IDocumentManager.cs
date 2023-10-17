using RenterManager.Application.Features.Documents.Commands.AddEdit;
using RenterManager.Application.Features.Documents.Queries.GetAll;
using RenterManager.Application.Requests.Documents;
using RenterManager.Shared.Wrapper;
using System.Threading.Tasks;
using RenterManager.Application.Features.Documents.Queries.GetById;

namespace RenterManager.Client.Infrastructure.Managers.Misc.Document
{
    public interface IDocumentManager : IManager
    {
        Task<PaginatedResult<GetAllDocumentsResponse>> GetAllAsync(GetAllPagedDocumentsRequest request);

        Task<IResult<GetDocumentByIdResponse>> GetByIdAsync(GetDocumentByIdQuery request);

        Task<IResult<int>> SaveAsync(AddEditDocumentCommand request);

        Task<IResult<int>> DeleteAsync(int id);
    }
}