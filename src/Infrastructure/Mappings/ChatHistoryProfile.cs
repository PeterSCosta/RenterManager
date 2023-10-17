using AutoMapper;
using RenterManager.Application.Interfaces.Chat;
using RenterManager.Application.Models.Chat;
using RenterManager.Infrastructure.Models.Identity;

namespace RenterManager.Infrastructure.Mappings
{
    public class ChatHistoryProfile : Profile
    {
        public ChatHistoryProfile()
        {
            CreateMap<ChatHistory<IChatUser>, ChatHistory<BlazorHeroUser>>().ReverseMap();
        }
    }
}