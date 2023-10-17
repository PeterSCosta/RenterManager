using RenterManager.Application.Interfaces.Common;
using RenterManager.Application.Requests.Identity;
using RenterManager.Application.Responses.Identity;
using RenterManager.Shared.Wrapper;
using System.Threading.Tasks;

namespace RenterManager.Application.Interfaces.Services.Identity
{
    public interface ITokenService : IService
    {
        Task<Result<TokenResponse>> LoginAsync(TokenRequest model);

        Task<Result<TokenResponse>> GetRefreshTokenAsync(RefreshTokenRequest model);
    }
}