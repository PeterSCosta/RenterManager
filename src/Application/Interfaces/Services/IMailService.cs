using RenterManager.Application.Requests.Mail;
using System.Threading.Tasks;

namespace RenterManager.Application.Interfaces.Services
{
    public interface IMailService
    {
        Task SendAsync(MailRequest request);
    }
}