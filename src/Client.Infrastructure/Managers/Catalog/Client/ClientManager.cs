using RenterManager.Application.Features.Clients.Commands.AddEdit;
using RenterManager.Application.Features.Clients.Queries.GetAllPaged;
using RenterManager.Application.Requests.Catalog;
using RenterManager.Client.Infrastructure.Extensions;
using RenterManager.Shared.Wrapper;
using System.Net.Http;
using System.Net.Http.Json;
using System.Threading.Tasks;

namespace RenterManager.Client.Infrastructure.Managers.Catalog.Client
{
    public class ClientManager : IClientManager
    {
        private readonly HttpClient _httpClient;

        public ClientManager(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }

        public async Task<IResult<int>> DeleteAsync(int id)
        {
            var response = await _httpClient.DeleteAsync($"{Routes.ClientsEndpoints.Delete}/{id}");
            return await response.ToResult<int>();
        }

        public async Task<IResult<string>> ExportToExcelAsync(string searchString = "")
        {
            var response = await _httpClient.GetAsync(string.IsNullOrWhiteSpace(searchString)
                ? Routes.ClientsEndpoints.Export
                : Routes.ClientsEndpoints.ExportFiltered(searchString));
            return await response.ToResult<string>();
        }

        public async Task<PaginatedResult<GetAllPagedClientsResponse>> GetClientsAsync(GetAllPagedClientsRequest request)
        {
            var response = await _httpClient.GetAsync(Routes.ClientsEndpoints.GetAllPaged(request.PageNumber, request.PageSize, request.SearchString, request.Orderby));
            return await response.ToPaginatedResult<GetAllPagedClientsResponse>();
        }

        public async Task<IResult<int>> SaveAsync(AddEditClientCommand request)
        {
            var response = await _httpClient.PostAsJsonAsync(Routes.ClientsEndpoints.Save, request);
            return await response.ToResult<int>();
        }
    }
}