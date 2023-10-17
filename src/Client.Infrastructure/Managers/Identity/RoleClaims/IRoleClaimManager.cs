using System.Collections.Generic;
using System.Threading.Tasks;
using RenterManager.Application.Requests.Identity;
using RenterManager.Application.Responses.Identity;
using RenterManager.Shared.Wrapper;

namespace RenterManager.Client.Infrastructure.Managers.Identity.RoleClaims
{
    public interface IRoleClaimManager : IManager
    {
        Task<IResult<List<RoleClaimResponse>>> GetRoleClaimsAsync();

        Task<IResult<List<RoleClaimResponse>>> GetRoleClaimsByRoleIdAsync(string roleId);

        Task<IResult<string>> SaveAsync(RoleClaimRequest role);

        Task<IResult<string>> DeleteAsync(string id);
    }
}