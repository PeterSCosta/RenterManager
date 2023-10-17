using RenterManager.Application.Features.Products.Commands.AddEdit;
using RenterManager.Application.Features.Products.Queries.GetAllPaged;
using RenterManager.Application.Requests.Catalog;
using RenterManager.Shared.Wrapper;
using System.Threading.Tasks;

namespace RenterManager.Client.Infrastructure.Managers.Catalog.Product
{
    public interface IProductManager : IManager
    {
        Task<PaginatedResult<GetAllPagedProductsResponse>> GetProductsAsync(GetAllPagedProductsRequest request);

        Task<IResult<string>> GetProductImageAsync(int id);

        Task<IResult<int>> SaveAsync(AddEditProductCommand request);

        Task<IResult<int>> DeleteAsync(int id);

        Task<IResult<string>> ExportToExcelAsync(string searchString = "");
    }
}