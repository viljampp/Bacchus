using System.Threading.Tasks;

namespace Bacchus.Services
{
    public interface IEmailSender
    {
        Task SendEmailAsync(string email, string subject, string message);
    }
}
