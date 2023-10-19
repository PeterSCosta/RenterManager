using RenterManager.Application.Features.Clients.Commands.AddEdit;
using RenterManager.Application.Features.Clients.Queries.GetAllPaged;
using RenterManager.Application.Requests.Catalog;
using RenterManager.Shared.Wrapper;
using System.Threading.Tasks;

namespace RenterManager.Client.Infrastructure.Managers.Catalog.Client
{
    public interface IClientManager : IManager
    {
        Task<PaginatedResult<GetAllPagedClientsResponse>> GetClientsAsync(GetAllPagedClientsRequest request);

        Task<IResult<int>> SaveAsync(AddEditClientCommand request);

        Task<IResult<int>> DeleteAsync(int id);

        Task<IResult<string>> ExportToExcelAsync(string searchString = "");
    }
}