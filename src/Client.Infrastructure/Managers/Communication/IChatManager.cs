using RenterManager.Application.Models.Chat;
using RenterManager.Application.Responses.Identity;
using RenterManager.Shared.Wrapper;
using System.Collections.Generic;
using System.Threading.Tasks;
using RenterManager.Application.Interfaces.Chat;

namespace RenterManager.Client.Infrastructure.Managers.Communication
{
    public interface IChatManager : IManager
    {
        Task<IResult<IEnumerable<ChatUserResponse>>> GetChatUsersAsync();

        Task<IResult> SaveMessageAsync(ChatHistory<IChatUser> chatHistory);

        Task<IResult<IEnumerable<ChatHistoryResponse>>> GetChatHistoryAsync(string cId);
    }
}