using RenterManager.Application.Interfaces.Common;

namespace RenterManager.Application.Interfaces.Services
{
    public interface ICurrentUserService : IService
    {
        string UserId { get; }
    }
}