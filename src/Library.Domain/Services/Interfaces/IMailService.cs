using System.Threading.Tasks;
using lab.Domain;

namespace lab.Domain.Services.Interfaces {
    public interface IMailService {
        Task SendPasswordResetMail(User user);
        Task SendActivationEmail(User user);
        Task SendCreationEmail(User user);
    }
}
