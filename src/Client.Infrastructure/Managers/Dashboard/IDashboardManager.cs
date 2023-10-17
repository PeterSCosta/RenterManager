using RenterManager.Shared.Wrapper;
using System.Threading.Tasks;
using RenterManager.Application.Features.Dashboards.Queries.GetData;

namespace RenterManager.Client.Infrastructure.Managers.Dashboard
{
    public interface IDashboardManager : IManager
    {
        Task<IResult<DashboardDataResponse>> GetDataAsync();
    }
}