﻿using RenterManager.Application.Responses.Identity;
using RenterManager.Shared.Wrapper;
using System.Collections.Generic;
using System.Threading.Tasks;
using RenterManager.Application.Interfaces.Chat;
using RenterManager.Application.Models.Chat;

namespace RenterManager.Application.Interfaces.Services
{
    public interface IChatService
    {
        Task<Result<IEnumerable<ChatUserResponse>>> GetChatUsersAsync(string userId);

        Task<IResult> SaveMessageAsync(ChatHistory<IChatUser> message);

        Task<Result<IEnumerable<ChatHistoryResponse>>> GetChatHistoryAsync(string userId, string contactId);
    }
}